using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using UnityEngine.UI;

#if UNITY_5_3
using UnityEngine.SceneManagement;
#endif
using OpenCVForUnity;
using OpenCVFaceTracker;

namespace FaceTrackerSample
{

		[RequireComponent(typeof(WebCamTextureToMatHelper))]
		public class FaceTrackerARSample : MonoBehaviour
		{

        [Header("Quality")]
        [Range(1,20)]
		public int quality = 5;

				bool autoResetMode = true;

				[Range(0, 50)]
				public float
						rvecNoiseFilterRange = 8;

				[Range(0, 360)]
				public float
						tvecNoiseFilterRange = 90;

				Color32[] colors;

				Mat grayMat;

				Texture2D texture;

				CascadeClassifier cascade;

				FaceTracker faceTracker;

				FaceTrackerParams faceTrackerParams;

				public Camera ARCamera;

				Mat camMatrix;

				MatOfDouble distCoeffs;

				Matrix4x4 invertYM;

				Matrix4x4 transformationM = new Matrix4x4 ();

				Matrix4x4 invertZM;

				Matrix4x4 ARM;

				public GameObject ARGameObject;

//				public bool shouldMoveARCamera;

				MatOfPoint3f objectPoints;

				MatOfPoint2f imagePoints;

				Mat rvec;

				Mat tvec;

				Mat rotM;

				Mat oldRvec;

				Mat oldTvec;

				WebCamTextureToMatHelper webCamTextureToMatHelper;

        int screenWidth;
        int screenHeight;
        bool needToReset;
        float counter;

        // Use this for initialization
        void Start ()
				{
						//set 3d face object points.
						objectPoints = new MatOfPoint3f (new Point3 (-31, 72, 86),//l eye
			                                              new Point3 (31, 72, 86),//r eye
			                                              new Point3 (0, 40, 114),//nose
			                                 new Point3 (-20, 15, 90),//l mouse
			                                 new Point3 (20, 15, 90)//r mouse
						);
						imagePoints = new MatOfPoint2f ();
						rvec = new Mat ();
						tvec = new Mat ();
						rotM = new Mat (3, 3, CvType.CV_64FC1);

						//initialize FaceTracker
						faceTracker = new FaceTracker (Utils.getFilePath ("tracker_model.json"));
						//initialize FaceTrackerParams
						faceTrackerParams = new FaceTrackerParams ();

                        screenWidth = quality * Screen.width / 20;
                        screenHeight = quality * Screen.height / 20;

                       webCamTextureToMatHelper = gameObject.GetComponent<WebCamTextureToMatHelper>();
                       webCamTextureToMatHelper.Init("", screenWidth, screenHeight, true);
        }

				public void OnWebCamTextureToMatHelperInited ()
				{
						Debug.Log ("OnWebCamTextureToMatHelperInited");
			
						Mat webCamTextureMat = webCamTextureToMatHelper.GetMat ();
			
						colors = new Color32[webCamTextureMat.cols () * webCamTextureMat.rows ()];
						texture = new Texture2D (webCamTextureMat.cols (), webCamTextureMat.rows (), TextureFormat.RGBA32, false);



						gameObject.transform.localScale = new Vector3 (webCamTextureMat.cols (), webCamTextureMat.rows (), 1);
			
						Debug.Log ("Screen.width " + Screen.width + " Screen.height " + Screen.height + " Screen.orientation " + Screen.orientation);
			
						float width = 0;
						float height = 0;
			
						width = gameObject.transform.localScale.x;
						height = gameObject.transform.localScale.y;

						float imageScale = 1.0f;
						float widthScale = (float)Screen.width / width;
						float heightScale = (float)Screen.height / height;
						if (widthScale < heightScale) {
								Camera.main.orthographicSize = (width * (float)Screen.height / (float)Screen.width) / 2;
								imageScale = (float)Screen.height / (float)Screen.width;
						} else {
								Camera.main.orthographicSize = height / 2;
						}
			
						gameObject.GetComponent<Renderer> ().material.mainTexture = texture;

						grayMat = new Mat (webCamTextureMat.rows (), webCamTextureMat.cols (), CvType.CV_8UC1);
									
						cascade = new CascadeClassifier (Utils.getFilePath ("haarcascade_frontalface_alt.xml"));
						if (cascade.empty ()) {
								Debug.LogError ("cascade file is not loaded.Please copy from “FaceTrackerSample/StreamingAssets/” to “Assets/StreamingAssets/” folder. ");
						}
									
									
						int max_d = Mathf.Max (webCamTextureMat.rows (), webCamTextureMat.cols ());
						camMatrix = new Mat (3, 3, CvType.CV_64FC1);
						camMatrix.put (0, 0, max_d);
						camMatrix.put (0, 1, 0);
						camMatrix.put (0, 2, webCamTextureMat.cols () / 2.0f);
						camMatrix.put (1, 0, 0);
						camMatrix.put (1, 1, max_d);
						camMatrix.put (1, 2, webCamTextureMat.rows () / 2.0f);
						camMatrix.put (2, 0, 0);
						camMatrix.put (2, 1, 0);
						camMatrix.put (2, 2, 1.0f);
									
						Size imageSize = new Size (webCamTextureMat.cols () * imageScale, webCamTextureMat.rows () * imageScale);
						double apertureWidth = 0;
						double apertureHeight = 0;
						double[] fovx = new double[1];
						double[] fovy = new double[1];
						double[] focalLength = new double[1];
						Point principalPoint = new Point ();
						double[] aspectratio = new double[1];
													
						Calib3d.calibrationMatrixValues (camMatrix, imageSize, apertureWidth, apertureHeight, fovx, fovy, focalLength, principalPoint, aspectratio);
									
						distCoeffs = new MatOfDouble (0, 0, 0, 0);
								
						invertYM = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, new Vector3 (1, -1, 1));
						
						invertZM = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, new Vector3 (1, 1, -1));
						
				}

				public void OnWebCamTextureToMatHelperDisposed ()
				{
						Debug.Log ("OnWebCamTextureToMatHelperDisposed");
									
						faceTracker.reset ();

						grayMat.Dispose ();
						cascade.Dispose ();
						camMatrix.Dispose ();
						distCoeffs.Dispose ();
				}

				// Update is called once per frame
				void Update ()
				{

						if (webCamTextureToMatHelper.isPlaying () && webCamTextureToMatHelper.didUpdateThisFrame ()) {
				
								Mat rgbaMat = webCamTextureToMatHelper.GetMat ();

                //convert image to greyscale
								Imgproc.cvtColor (rgbaMat, grayMat, Imgproc.COLOR_RGBA2GRAY);
										
										
								if (autoResetMode || faceTracker.getPoints ().Count <= 0) {

										using (Mat equalizeHistMat = new Mat ()) 
										using (MatOfRect faces = new MatOfRect ()) {
												
												Imgproc.equalizeHist (grayMat, equalizeHistMat);
												
												cascade.detectMultiScale (equalizeHistMat, faces, 1.1f, 2, 0
														| Objdetect.CASCADE_FIND_BIGGEST_OBJECT
														| Objdetect.CASCADE_SCALE_IMAGE, new OpenCVForUnity.Size (equalizeHistMat.cols () * 0.15, equalizeHistMat.cols () * 0.15), new Size ());
												
												
												
												if (faces.rows () > 0) {

														List<OpenCVForUnity.Rect> rectsList = faces.toList ();
														List<Point[]> pointsList = faceTracker.getPoints ();
						
														if (autoResetMode) {
																//add initial face points from MatOfRect
																if (pointsList.Count <= 0) {
																		faceTracker.addPoints (faces);							
																} else {
							
																		for (int i = 0; i < rectsList.Count; i++) {
								
																				OpenCVForUnity.Rect trackRect = new OpenCVForUnity.Rect (rectsList [i].x + rectsList [i].width / 3, rectsList [i].y + rectsList [i].height / 2, rectsList [i].width / 3, rectsList [i].height / 3);
																				//It determines whether nose point has been included in trackRect.										
																				if (i < pointsList.Count && !trackRect.contains (pointsList [i] [67])) {
																						rectsList.RemoveAt (i);
																						pointsList.RemoveAt (i);
																				}
																		}
																}
														} else {
																faceTracker.addPoints (faces);
														}

												} else {
														if (autoResetMode) {
																faceTracker.reset ();
														}
												}
												
										}
											
								}
										
										
								//track face points.if face points <= 0, always return false.
								if (faceTracker.track (grayMat, faceTrackerParams)) {
										
										#if OPENCV_2
					Core.putText (rgbaMat, "'Tap' or 'Space Key' to Reset", new Point (5, rgbaMat.rows () - 5), Core.FONT_HERSHEY_SIMPLEX, 0.8, new Scalar (255, 255, 255, 255), 2, Core.LINE_AA, false);
										#else
										Imgproc.putText (rgbaMat, "'Tap' or 'Space Key' to Reset", new Point (5, rgbaMat.rows () - 5), Core.FONT_HERSHEY_SIMPLEX, 0.8, new Scalar (255, 255, 255, 255), 2, Imgproc.LINE_AA, false);
										#endif	
											
										Point[] points = faceTracker.getPoints () [0];
											
											
										if (points.Length > 0) {
												
//												for (int i = 0; i < points.Length; i++) {
//														#if OPENCV_2
//							Core.putText (rgbaMat, "" + i, new Point (points [i].x, points [i].y), Core.FONT_HERSHEY_SIMPLEX, 0.3, new Scalar (0, 0, 255, 255), 2, Core.LINE_AA, false);
//														#else
//														Imgproc.putText (rgbaMat, "" + i, new Point (points [i].x, points [i].y), Core.FONT_HERSHEY_SIMPLEX, 0.3, new Scalar (0, 0, 255, 255), 2, Core.LINE_AA, false);
//														#endif
//												}
												
												
												imagePoints.fromArray (
													points [31],//l eye
													points [36],//r eye
													points [67],//nose
													points [48],//l mouth
													points [54] //r mouth
//																				,
//																								points [0],//l ear
//																								points [14]//r ear
												);
												
												
												Calib3d.solvePnP (objectPoints, imagePoints, camMatrix, distCoeffs, rvec, tvec);
												
												bool isRefresh = false;
												
												if (tvec.get (2, 0) [0] > 0 && tvec.get (2, 0) [0] < 1200 * ((float)rgbaMat.cols () / (float)webCamTextureToMatHelper.requestWidth)) {
													
														isRefresh = true;
													
														if (oldRvec == null) {
																oldRvec = new Mat ();
																rvec.copyTo (oldRvec);
														}
														if (oldTvec == null) {
																oldTvec = new Mat ();
																tvec.copyTo (oldTvec);
														}
													
													
														//filter Rvec Noise.
														using (Mat absDiffRvec = new Mat ()) {
																Core.absdiff (rvec, oldRvec, absDiffRvec);
														
																//				Debug.Log ("absDiffRvec " + absDiffRvec.dump());
														
																using (Mat cmpRvec = new Mat ()) {
																		Core.compare (absDiffRvec, new Scalar (rvecNoiseFilterRange), cmpRvec, Core.CMP_GT);
															
																		if (Core.countNonZero (cmpRvec) > 0)
																				isRefresh = false;
																}
														}
													
													
													
														//filter Tvec Noise.
														using (Mat absDiffTvec = new Mat ()) {
																Core.absdiff (tvec, oldTvec, absDiffTvec);
														
																//				Debug.Log ("absDiffRvec " + absDiffRvec.dump());
														
																using (Mat cmpTvec = new Mat ()) {
																		Core.compare (absDiffTvec, new Scalar (tvecNoiseFilterRange), cmpTvec, Core.CMP_GT);
															
																		if (Core.countNonZero (cmpTvec) > 0)
																				isRefresh = false;
																}
														}
													
													
													
												}
												
												if (isRefresh) {
													
														
														if ((Mathf.Abs ((float)(points [48].x - points [56].x)) < Mathf.Abs ((float)(points [31].x - points [36].x)) / 2.2 
																&& Mathf.Abs ((float)(points [51].y - points [57].y)) > Mathf.Abs ((float)(points [31].x - points [36].x)) / 2.9)
																|| Mathf.Abs ((float)(points [51].y - points [57].y)) > Mathf.Abs ((float)(points [31].x - points [36].x)) / 2.7) {
														
			
														
														} 

														rvec.copyTo (oldRvec);
														tvec.copyTo (oldTvec);
													
														Calib3d.Rodrigues (rvec, rotM);
													
														transformationM .SetRow (0, new Vector4 ((float)rotM.get (0, 0) [0], (float)rotM.get (0, 1) [0], (float)rotM.get (0, 2) [0], (float)tvec.get (0, 0) [0]));
														transformationM.SetRow (1, new Vector4 ((float)rotM.get (1, 0) [0], (float)rotM.get (1, 1) [0], (float)rotM.get (1, 2) [0], (float)tvec.get (1, 0) [0]));
														transformationM.SetRow (2, new Vector4 ((float)rotM.get (2, 0) [0], (float)rotM.get (2, 1) [0], (float)rotM.get (2, 2) [0], (float)tvec.get (2, 0) [0]));
														transformationM.SetRow (3, new Vector4 (0, 0, 0, 1));
													
													
																ARM = ARCamera.transform.localToWorldMatrix * invertYM * transformationM * invertZM;

																if (ARGameObject != null) {
																		ARUtils.SetTransformFromMatrix (ARGameObject.transform, ref ARM);
																		ARGameObject.SetActive (true);
																}
												}
										}
								}
										
//								Core.putText (rgbaMat, "W:" + rgbaMat.width () + " H:" + rgbaMat.height () + " SO:" + Screen.orientation, new Point (5, rgbaMat.rows () - 10), Core.FONT_HERSHEY_SIMPLEX, 1.0, new Scalar (255, 255, 255, 255), 2, Core.LINE_AA, false);
										
								Utils.matToTexture2D (rgbaMat, texture, colors);
										
						}
									
						if (Input.GetKeyUp (KeyCode.Space) || Input.touchCount > 0) {
								faceTracker.reset ();
								if (oldRvec != null) {
										oldRvec.Dispose ();
										oldRvec = null;
								}
								if (oldTvec != null) {
										oldTvec.Dispose ();
										oldTvec = null;
								}
							
						}
					
				}

				void OnDisable ()
				{
						webCamTextureToMatHelper.Dispose ();
				}
		
		}
}