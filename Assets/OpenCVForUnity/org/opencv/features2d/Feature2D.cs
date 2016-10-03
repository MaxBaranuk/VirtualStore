
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class Feature2D
//javadoc: Feature2D
    public class Feature2D : Algorithm
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
features2d_Feature2D_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected Feature2D (IntPtr addr) : base(addr)
        {
        }


        //
        // C++:  bool empty()
        //

        //javadoc: Feature2D::empty()
        public  bool empty ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = features2d_Feature2D_empty_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  int defaultNorm()
        //

        //javadoc: Feature2D::defaultNorm()
        public  int defaultNorm ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = features2d_Feature2D_defaultNorm_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int descriptorSize()
        //

        //javadoc: Feature2D::descriptorSize()
        public  int descriptorSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = features2d_Feature2D_descriptorSize_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int descriptorType()
        //

        //javadoc: Feature2D::descriptorType()
        public  int descriptorType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = features2d_Feature2D_descriptorType_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void compute(Mat image, vector_KeyPoint& keypoints, Mat& descriptors)
        //

        //javadoc: Feature2D::compute(image, keypoints, descriptors)
        public  void compute (Mat image, MatOfKeyPoint keypoints, Mat descriptors)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();
            if (descriptors != null)
                descriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat keypoints_mat = keypoints;
        features2d_Feature2D_compute_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        //

        //javadoc: Feature2D::detect(image, keypoints, mask)
        public  void detect (Mat image, MatOfKeyPoint keypoints, Mat mask)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();
            if (mask != null)
                mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detect_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, mask.nativeObj);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Feature2D::detect(image, keypoints)
        public  void detect (Mat image, MatOfKeyPoint keypoints)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detect_11(nativeObj, image.nativeObj, keypoints_mat.nativeObj);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void detectAndCompute(Mat image, Mat mask, vector_KeyPoint& keypoints, Mat& descriptors, bool useProvidedKeypoints = false)
        //

        //javadoc: Feature2D::detectAndCompute(image, mask, keypoints, descriptors, useProvidedKeypoints)
        public  void detectAndCompute (Mat image, Mat mask, MatOfKeyPoint keypoints, Mat descriptors, bool useProvidedKeypoints)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (mask != null)
                mask.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();
            if (descriptors != null)
                descriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detectAndCompute_10(nativeObj, image.nativeObj, mask.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj, useProvidedKeypoints);
        
        return;
#else
            return;
#endif
        }

        //javadoc: Feature2D::detectAndCompute(image, mask, keypoints, descriptors)
        public  void detectAndCompute (Mat image, Mat mask, MatOfKeyPoint keypoints, Mat descriptors)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (mask != null)
                mask.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();
            if (descriptors != null)
                descriptors.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat keypoints_mat = keypoints;
        features2d_Feature2D_detectAndCompute_11(nativeObj, image.nativeObj, mask.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);
        
        return;
#else
            return;
#endif
        }


        #if UNITY_IOS && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        #else
        const string LIBNAME = "opencvforunity";
        #endif



        // C++:  bool empty()
        [DllImport(LIBNAME)]
        private static extern bool features2d_Feature2D_empty_10 (IntPtr nativeObj);

        // C++:  int defaultNorm()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_defaultNorm_10 (IntPtr nativeObj);

        // C++:  int descriptorSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_descriptorSize_10 (IntPtr nativeObj);

        // C++:  int descriptorType()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_descriptorType_10 (IntPtr nativeObj);

        // C++:  void compute(Mat image, vector_KeyPoint& keypoints, Mat& descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_compute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // C++:  void detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr mask_nativeObj);

        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void detectAndCompute(Mat image, Mat mask, vector_KeyPoint& keypoints, Mat& descriptors, bool useProvidedKeypoints = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detectAndCompute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj, bool useProvidedKeypoints);

        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detectAndCompute_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_delete (IntPtr nativeObj);

    }
}
