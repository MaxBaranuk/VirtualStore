
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class BIF
//javadoc: BIF
    public class BIF : Algorithm
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_BIF_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        public BIF (IntPtr addr) : base(addr)
        {
        }


        //
        // C++:  int getNumBands()
        //

        //javadoc: BIF::getNumBands()
        public  int getNumBands ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = face_BIF_getNumBands_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int getNumRotations()
        //

        //javadoc: BIF::getNumRotations()
        public  int getNumRotations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = face_BIF_getNumRotations_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void compute(Mat image, Mat& features)
        //

        //javadoc: BIF::compute(image, features)
        public  void compute (Mat image, Mat features)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (features != null)
                features.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        face_BIF_compute_10(nativeObj, image.nativeObj, features.nativeObj);
        
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


        // C++:  int getNumBands()
        [DllImport(LIBNAME)]
        private static extern int face_BIF_getNumBands_10 (IntPtr nativeObj);

        // C++:  int getNumRotations()
        [DllImport(LIBNAME)]
        private static extern int face_BIF_getNumRotations_10 (IntPtr nativeObj);

        // C++:  void compute(Mat image, Mat& features)
        [DllImport(LIBNAME)]
        private static extern void face_BIF_compute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr features_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_BIF_delete (IntPtr nativeObj);

    }
}
