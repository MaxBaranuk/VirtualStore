
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class SIFT
//javadoc: SIFT
    public class SIFT : Feature2D
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_SIFT_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected SIFT (IntPtr addr) : base(addr)
        {
        }


        //
        // C++: static Ptr_SIFT create(int nfeatures = 0, int nOctaveLayers = 3, double contrastThreshold = 0.04, double edgeThreshold = 10, double sigma = 1.6)
        //

        //javadoc: SIFT::create(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold, sigma)
        public static SIFT create (int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        SIFT retVal = new SIFT(xfeatures2d_SIFT_create_10(nfeatures, nOctaveLayers, contrastThreshold, edgeThreshold, sigma));
        
        return retVal;
#else
            return;
#endif
        }

        //javadoc: SIFT::create()
        public static SIFT create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        SIFT retVal = new SIFT(xfeatures2d_SIFT_create_11());
        
        return retVal;
#else
            return;
#endif
        }


        #if UNITY_IOS && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        #else
        const string LIBNAME = "opencvforunity";
        #endif



        // C++: static Ptr_SIFT create(int nfeatures = 0, int nOctaveLayers = 3, double contrastThreshold = 0.04, double edgeThreshold = 10, double sigma = 1.6)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_SIFT_create_10 (int nfeatures, int nOctaveLayers, double contrastThreshold, double edgeThreshold, double sigma);

        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_SIFT_create_11 ();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_SIFT_delete (IntPtr nativeObj);

    }
}
