
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class Board
//javadoc: Board
    public class Board : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
aruco_Board_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected Board (IntPtr addr) : base(addr)
        {
        }


        //
        // C++: vector_vector_Point3f Board::objPoints
        //

        //javadoc: Board::get_objPoints()
        public  List<MatOfPoint3f> get_objPoints ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        List<MatOfPoint3f> retVal = new List<MatOfPoint3f>();
        Mat retValMat = new Mat(aruco_Board_get_1objPoints_10(nativeObj));
        Converters.Mat_to_vector_vector_Point3f(retValMat, retVal);
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: Ptr_Dictionary Board::dictionary
        //

        //javadoc: Board::get_dictionary()
        public  Dictionary get_dictionary ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        Dictionary retVal = new Dictionary(aruco_Board_get_1dictionary_10(nativeObj));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++: vector_int Board::ids
        //

        //javadoc: Board::get_ids()
        public  MatOfInt get_ids ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        MatOfInt retVal = MatOfInt.fromNativeAddr(aruco_Board_get_1ids_10(nativeObj));
        
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


        // C++: vector_vector_Point3f Board::objPoints
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Board_get_1objPoints_10 (IntPtr nativeObj);

        // C++: Ptr_Dictionary Board::dictionary
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Board_get_1dictionary_10 (IntPtr nativeObj);

        // C++: vector_int Board::ids
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_Board_get_1ids_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_Board_delete (IntPtr nativeObj);

    }
}
