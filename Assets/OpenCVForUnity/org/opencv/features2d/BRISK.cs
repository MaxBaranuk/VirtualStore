
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class BRISK
//javadoc: BRISK
    public class BRISK : Feature2D
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
features2d_BRISK_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected BRISK (IntPtr addr) : base(addr)
        {
        }


        //
        // C++: static Ptr_BRISK create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        //

        //javadoc: BRISK::create(thresh, octaves, patternScale)
        public static BRISK create (int thresh, int octaves, float patternScale)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BRISK retVal = new BRISK(features2d_BRISK_create_10(thresh, octaves, patternScale));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create()
        public static BRISK create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BRISK retVal = new BRISK(features2d_BRISK_create_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: static Ptr_BRISK create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        //

        //javadoc: BRISK::create(radiusList, numberList, dMax, dMin, indexChange)
        public static BRISK create (MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin, MatOfInt indexChange)
        {
            if (radiusList != null)
                radiusList.ThrowIfDisposed ();
            if (numberList != null)
                numberList.ThrowIfDisposed ();
            if (indexChange != null)
                indexChange.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        Mat indexChange_mat = indexChange;
        BRISK retVal = new BRISK(features2d_BRISK_create_12(radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin, indexChange_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: BRISK::create(radiusList, numberList)
        public static BRISK create (MatOfFloat radiusList, MatOfInt numberList)
        {
            if (radiusList != null)
                radiusList.ThrowIfDisposed ();
            if (numberList != null)
                numberList.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        Mat radiusList_mat = radiusList;
        Mat numberList_mat = numberList;
        BRISK retVal = new BRISK(features2d_BRISK_create_13(radiusList_mat.nativeObj, numberList_mat.nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        #if UNITY_IOS && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        #else
        const string LIBNAME = "opencvforunity";
        #endif



        // C++: static Ptr_BRISK create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_10 (int thresh, int octaves, float patternScale);

        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_11 ();

        // C++: static Ptr_BRISK create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_12 (IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin, IntPtr indexChange_mat_nativeObj);

        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_13 (IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BRISK_delete (IntPtr nativeObj);

    }
}
