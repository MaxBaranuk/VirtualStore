
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
    public class Ximgproc
    {
        
        public const int            DTF_NC = 0;
        public const int            DTF_IC = 1;
        public const int            DTF_RF = 2;
        public const int            GUIDED_FILTER = 3;
        public const int            AM_FILTER = 4;
        public const int            ARO_0_45 = 0;
        public const int            ARO_45_90 = 1;
        public const int            ARO_90_135 = 2;
        public const int            ARO_315_0 = 3;
        public const int            ARO_315_45 = 4;
        public const int            ARO_45_135 = 5;
        public const int            ARO_315_135 = 6;
        public const int            ARO_CTR_HOR = 7;
        public const int            ARO_CTR_VER = 8;
        public const int            FHT_MIN = 0;
        public const int            FHT_MAX = 1;
        public const int            FHT_ADD = 2;
        public const int            FHT_AVE = 3;
        public const int            HDO_RAW = 0;
        public const int            HDO_DESKEW = 1;
        public const int            SLIC = 100;
        public const int            SLICO = 101;
        public const int            WMF_EXP = 0;
        public const int            WMF_IV1 = 1;
        public const int            WMF_IV2 = 2;
        public const int            WMF_COS = 3;
        public const int            WMF_JAC = 4;
        public const int            WMF_OFF = 5;
        
        
        
        //
        // C++:  Ptr_AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        //
        
        //javadoc: createAMFilter(sigma_s, sigma_r, adjust_outliers)
        public static AdaptiveManifoldFilter createAMFilter (double sigma_s, double sigma_r, bool adjust_outliers)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            AdaptiveManifoldFilter retVal = new AdaptiveManifoldFilter(ximgproc_Ximgproc_createAMFilter_10(sigma_s, sigma_r, adjust_outliers));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createAMFilter(sigma_s, sigma_r)
        public static AdaptiveManifoldFilter createAMFilter (double sigma_s, double sigma_r)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            AdaptiveManifoldFilter retVal = new AdaptiveManifoldFilter(ximgproc_Ximgproc_createAMFilter_11(sigma_s, sigma_r));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //
        
        //javadoc: createDTFilter(guide, sigmaSpatial, sigmaColor, mode, numIters)
        public static DTFilter createDTFilter (Mat guide, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            DTFilter retVal = new DTFilter(ximgproc_Ximgproc_createDTFilter_10(guide.nativeObj, sigmaSpatial, sigmaColor, mode, numIters));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createDTFilter(guide, sigmaSpatial, sigmaColor)
        public static DTFilter createDTFilter (Mat guide, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            DTFilter retVal = new DTFilter(ximgproc_Ximgproc_createDTFilter_11(guide.nativeObj, sigmaSpatial, sigmaColor));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_DisparityWLSFilter createDisparityWLSFilter(Ptr_StereoMatcher matcher_left)
        //
        
        // Unknown type 'Ptr_StereoMatcher' (I), skipping the function
        
        
        //
        // C++:  Ptr_DisparityWLSFilter createDisparityWLSFilterGeneric(bool use_confidence)
        //
        
        //javadoc: createDisparityWLSFilterGeneric(use_confidence)
        public static DisparityWLSFilter createDisparityWLSFilterGeneric (bool use_confidence)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            DisparityWLSFilter retVal = new DisparityWLSFilter(ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10(use_confidence));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_EdgeAwareInterpolator createEdgeAwareInterpolator()
        //
        
        //javadoc: createEdgeAwareInterpolator()
        public static EdgeAwareInterpolator createEdgeAwareInterpolator ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            EdgeAwareInterpolator retVal = new EdgeAwareInterpolator(ximgproc_Ximgproc_createEdgeAwareInterpolator_10());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //
        
        //javadoc: createFastGlobalSmootherFilter(guide, lambda, sigma_color, lambda_attenuation, num_iter)
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter (Mat guide, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            FastGlobalSmootherFilter retVal = new FastGlobalSmootherFilter(ximgproc_Ximgproc_createFastGlobalSmootherFilter_10(guide.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createFastGlobalSmootherFilter(guide, lambda, sigma_color)
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter (Mat guide, double lambda, double sigma_color)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            FastGlobalSmootherFilter retVal = new FastGlobalSmootherFilter(ximgproc_Ximgproc_createFastGlobalSmootherFilter_11(guide.nativeObj, lambda, sigma_color));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_GraphSegmentation createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        //
        
        //javadoc: createGraphSegmentation(sigma, k, min_size)
        public static GraphSegmentation createGraphSegmentation (double sigma, float k, int min_size)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            GraphSegmentation retVal = new GraphSegmentation(ximgproc_Ximgproc_createGraphSegmentation_10(sigma, k, min_size));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createGraphSegmentation()
        public static GraphSegmentation createGraphSegmentation ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            GraphSegmentation retVal = new GraphSegmentation(ximgproc_Ximgproc_createGraphSegmentation_11());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_GuidedFilter createGuidedFilter(Mat guide, int radius, double eps)
        //
        
        //javadoc: createGuidedFilter(guide, radius, eps)
        public static GuidedFilter createGuidedFilter (Mat guide, int radius, double eps)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            GuidedFilter retVal = new GuidedFilter(ximgproc_Ximgproc_createGuidedFilter_10(guide.nativeObj, radius, eps));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_RFFeatureGetter createRFFeatureGetter()
        //
        
        //javadoc: createRFFeatureGetter()
        public static RFFeatureGetter createRFFeatureGetter ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            RFFeatureGetter retVal = new RFFeatureGetter(ximgproc_Ximgproc_createRFFeatureGetter_10());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentation createSelectiveSearchSegmentation()
        //
        
        //javadoc: createSelectiveSearchSegmentation()
        public static SelectiveSearchSegmentation createSelectiveSearchSegmentation ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentation retVal = new SelectiveSearchSegmentation(ximgproc_Ximgproc_createSelectiveSearchSegmentation_10());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor()
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyColor()
        public static SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyColor retVal = new SelectiveSearchSegmentationStrategyColor(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill()
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyFill()
        public static SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyFill retVal = new SelectiveSearchSegmentationStrategyFill(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2, s3, s4)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3, SelectiveSearchSegmentationStrategy s4)
        {
            if (s1 != null)
                s1.ThrowIfDisposed ();
            if (s2 != null)
                s2.ThrowIfDisposed ();
            if (s3 != null)
                s3.ThrowIfDisposed ();
            if (s4 != null)
                s4.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10(s1.nativeObj, s2.nativeObj, s3.nativeObj, s4.nativeObj));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2, s3)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3)
        {
            if (s1 != null)
                s1.ThrowIfDisposed ();
            if (s2 != null)
                s2.ThrowIfDisposed ();
            if (s3 != null)
                s3.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11(s1.nativeObj, s2.nativeObj, s3.nativeObj));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2)
        {
            if (s1 != null)
                s1.ThrowIfDisposed ();
            if (s2 != null)
                s2.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12(s1.nativeObj, s2.nativeObj));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1)
        {
            if (s1 != null)
                s1.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13(s1.nativeObj));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple()
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyMultiple()
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize()
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategySize()
        public static SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategySize retVal = new SelectiveSearchSegmentationStrategySize(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture()
        //
        
        //javadoc: createSelectiveSearchSegmentationStrategyTexture()
        public static SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SelectiveSearchSegmentationStrategyTexture retVal = new SelectiveSearchSegmentationStrategyTexture(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10());
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_StereoMatcher createRightMatcher(Ptr_StereoMatcher matcher_left)
        //
        
        // Return type 'Ptr_StereoMatcher' is not supported, skipping the function
        
        
        //
        // C++:  Ptr_StructuredEdgeDetection createStructuredEdgeDetection(string model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        //
        
        //javadoc: createStructuredEdgeDetection(model, howToGetFeatures)
        public static StructuredEdgeDetection createStructuredEdgeDetection (string model, RFFeatureGetter howToGetFeatures)
        {
            if (howToGetFeatures != null)
                howToGetFeatures.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            StructuredEdgeDetection retVal = new StructuredEdgeDetection(ximgproc_Ximgproc_createStructuredEdgeDetection_10(model, howToGetFeatures.nativeObj));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createStructuredEdgeDetection(model)
        public static StructuredEdgeDetection createStructuredEdgeDetection (string model)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            StructuredEdgeDetection retVal = new StructuredEdgeDetection(ximgproc_Ximgproc_createStructuredEdgeDetection_11(model));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SuperpixelLSC createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        //
        
        //javadoc: createSuperpixelLSC(image, region_size, ratio)
        public static SuperpixelLSC createSuperpixelLSC (Mat image, int region_size, float ratio)
        {
            if (image != null)
                image.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SuperpixelLSC retVal = new SuperpixelLSC(ximgproc_Ximgproc_createSuperpixelLSC_10(image.nativeObj, region_size, ratio));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createSuperpixelLSC(image)
        public static SuperpixelLSC createSuperpixelLSC (Mat image)
        {
            if (image != null)
                image.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SuperpixelLSC retVal = new SuperpixelLSC(ximgproc_Ximgproc_createSuperpixelLSC_11(image.nativeObj));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        //
        
        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins, double_step)
        public static SuperpixelSEEDS createSuperpixelSEEDS (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, bool double_step)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SuperpixelSEEDS retVal = new SuperpixelSEEDS(ximgproc_Ximgproc_createSuperpixelSEEDS_10(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins, double_step));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels)
        public static SuperpixelSEEDS createSuperpixelSEEDS (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SuperpixelSEEDS retVal = new SuperpixelSEEDS(ximgproc_Ximgproc_createSuperpixelSEEDS_11(image_width, image_height, image_channels, num_superpixels, num_levels));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  Ptr_SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        //
        
        //javadoc: createSuperpixelSLIC(image, algorithm, region_size, ruler)
        public static SuperpixelSLIC createSuperpixelSLIC (Mat image, int algorithm, int region_size, float ruler)
        {
            if (image != null)
                image.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SuperpixelSLIC retVal = new SuperpixelSLIC(ximgproc_Ximgproc_createSuperpixelSLIC_10(image.nativeObj, algorithm, region_size, ruler));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createSuperpixelSLIC(image)
        public static SuperpixelSLIC createSuperpixelSLIC (Mat image)
        {
            if (image != null)
                image.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            SuperpixelSLIC retVal = new SuperpixelSLIC(ximgproc_Ximgproc_createSuperpixelSLIC_11(image.nativeObj));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        
        //
        // C++:  void amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        //
        
        //javadoc: amFilter(joint, src, dst, sigma_s, sigma_r, adjust_outliers)
        public static void amFilter (Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r, bool adjust_outliers)
        {
            if (joint != null)
                joint.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_amFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r, adjust_outliers);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: amFilter(joint, src, dst, sigma_s, sigma_r)
        public static void amFilter (Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r)
        {
            if (joint != null)
                joint.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_amFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        //
        
        //javadoc: bilateralTextureFilter(src, dst, fr, numIter, sigmaAlpha, sigmaAvg)
        public static void bilateralTextureFilter (Mat src, Mat dst, int fr, int numIter, double sigmaAlpha, double sigmaAvg)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_bilateralTextureFilter_10(src.nativeObj, dst.nativeObj, fr, numIter, sigmaAlpha, sigmaAvg);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: bilateralTextureFilter(src, dst)
        public static void bilateralTextureFilter (Mat src, Mat dst)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_bilateralTextureFilter_11(src.nativeObj, dst.nativeObj);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        //
        
        //javadoc: covarianceEstimation(src, dst, windowRows, windowCols)
        public static void covarianceEstimation (Mat src, Mat dst, int windowRows, int windowCols)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_covarianceEstimation_10(src.nativeObj, dst.nativeObj, windowRows, windowCols);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //
        
        //javadoc: dtFilter(guide, src, dst, sigmaSpatial, sigmaColor, mode, numIters)
        public static void dtFilter (Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_dtFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor, mode, numIters);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: dtFilter(guide, src, dst, sigmaSpatial, sigmaColor)
        public static void dtFilter (Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_dtFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //
        
        //javadoc: fastGlobalSmootherFilter(guide, src, dst, lambda, sigma_color, lambda_attenuation, num_iter)
        public static void fastGlobalSmootherFilter (Mat guide, Mat src, Mat dst, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_fastGlobalSmootherFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: fastGlobalSmootherFilter(guide, src, dst, lambda, sigma_color)
        public static void fastGlobalSmootherFilter (Mat guide, Mat src, Mat dst, double lambda, double sigma_color)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_fastGlobalSmootherFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        //
        
        //javadoc: guidedFilter(guide, src, dst, radius, eps, dDepth)
        public static void guidedFilter (Mat guide, Mat src, Mat dst, int radius, double eps, int dDepth)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_guidedFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps, dDepth);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: guidedFilter(guide, src, dst, radius, eps)
        public static void guidedFilter (Mat guide, Mat src, Mat dst, int radius, double eps)
        {
            if (guide != null)
                guide.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_guidedFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        //
        
        //javadoc: jointBilateralFilter(joint, src, dst, d, sigmaColor, sigmaSpace, borderType)
        public static void jointBilateralFilter (Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int borderType)
        {
            if (joint != null)
                joint.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_jointBilateralFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, borderType);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: jointBilateralFilter(joint, src, dst, d, sigmaColor, sigmaSpace)
        public static void jointBilateralFilter (Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace)
        {
            if (joint != null)
                joint.ThrowIfDisposed ();
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_jointBilateralFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        //
        
        //javadoc: l0Smooth(src, dst, lambda, kappa)
        public static void l0Smooth (Mat src, Mat dst, double lambda, double kappa)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_l0Smooth_10(src.nativeObj, dst.nativeObj, lambda, kappa);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: l0Smooth(src, dst)
        public static void l0Smooth (Mat src, Mat dst)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_l0Smooth_11(src.nativeObj, dst.nativeObj);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double delta)
        //
        
        //javadoc: niBlackThreshold(_src, _dst, maxValue, type, blockSize, delta)
        public static void niBlackThreshold (Mat _src, Mat _dst, double maxValue, int type, int blockSize, double delta)
        {
            if (_src != null)
                _src.ThrowIfDisposed ();
            if (_dst != null)
                _dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_niBlackThreshold_10(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, delta);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        //
        
        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor, sigmaSpace, numOfIter, borderType)
        public static void rollingGuidanceFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_rollingGuidanceFilter_10(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter, borderType);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor, sigmaSpace, numOfIter)
        public static void rollingGuidanceFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_rollingGuidanceFilter_11(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter);
            
            return;
            #else
            return;
            #endif
        }
        
        //javadoc: rollingGuidanceFilter(src, dst)
        public static void rollingGuidanceFilter (Mat src, Mat dst)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_rollingGuidanceFilter_12(src.nativeObj, dst.nativeObj);
            
            return;
            #else
            return;
            #endif
        }
        
        
        //
        // C++:  void thinning(Mat src, Mat& dst)
        //
        
        //javadoc: thinning(src, dst)
        public static void thinning (Mat src, Mat dst)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            ximgproc_Ximgproc_thinning_10(src.nativeObj, dst.nativeObj);
            
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
        
        
        // C++:  Ptr_AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_10 (double sigma_s, double sigma_r, bool adjust_outliers);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_11 (double sigma_s, double sigma_r);
        
        // C++:  Ptr_DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_10 (IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_11 (IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor);
        
        // C++:  Ptr_DisparityWLSFilter createDisparityWLSFilterGeneric(bool use_confidence)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10 (bool use_confidence);
        
        // C++:  Ptr_EdgeAwareInterpolator createEdgeAwareInterpolator()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeAwareInterpolator_10 ();
        
        // C++:  Ptr_FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_10 (IntPtr guide_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_11 (IntPtr guide_nativeObj, double lambda, double sigma_color);
        
        // C++:  Ptr_GraphSegmentation createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_10 (double sigma, float k, int min_size);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_11 ();
        
        // C++:  Ptr_GuidedFilter createGuidedFilter(Mat guide, int radius, double eps)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGuidedFilter_10 (IntPtr guide_nativeObj, int radius, double eps);
        
        // C++:  Ptr_RFFeatureGetter createRFFeatureGetter()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createRFFeatureGetter_10 ();
        
        // C++:  Ptr_SelectiveSearchSegmentation createSelectiveSearchSegmentation()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentation_10 ();
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10 ();
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10 ();
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10 (IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj, IntPtr s4_nativeObj);
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11 (IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj);
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12 (IntPtr s1_nativeObj, IntPtr s2_nativeObj);
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13 (IntPtr s1_nativeObj);
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14 ();
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10 ();
        
        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10 ();
        
        // C++:  Ptr_StructuredEdgeDetection createStructuredEdgeDetection(string model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_10 (string model, IntPtr howToGetFeatures_nativeObj);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_11 (string model);
        
        // C++:  Ptr_SuperpixelLSC createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_10 (IntPtr image_nativeObj, int region_size, float ratio);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_11 (IntPtr image_nativeObj);
        
        // C++:  Ptr_SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_10 (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, bool double_step);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_11 (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels);
        
        // C++:  Ptr_SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_10 (IntPtr image_nativeObj, int algorithm, int region_size, float ruler);

        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_11 (IntPtr image_nativeObj);
        
        // C++:  void amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_10 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r, bool adjust_outliers);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_11 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r);
        
        // C++:  void bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter, double sigmaAlpha, double sigmaAvg);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_covarianceEstimation_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int windowRows, int windowCols);
        
        // C++:  void dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_10 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_11 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor);
        
        // C++:  void fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_10 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_11 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color);
        
        // C++:  void guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_10 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps, int dDepth);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_11 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps);
        
        // C++:  void jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_10 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int borderType);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_11 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);
        
        // C++:  void l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double kappa);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
        
        // C++:  void niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double delta)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_10 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double delta);
        
        // C++:  void rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter);

        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
        
        // C++:  void thinning(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_Ximgproc_thinning_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

    }
}
