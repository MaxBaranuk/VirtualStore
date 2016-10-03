
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class LATCH
//javadoc: LATCH
    public class LATCH : Feature2D
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_LATCH_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected LATCH (IntPtr addr) : base(addr)
        {
        }


        //
        // C++: static Ptr_LATCH create(int bytes = 32, bool rotationInvariance = true, int half_ssd_size = 3)
        //

        //javadoc: LATCH::create(bytes, rotationInvariance, half_ssd_size)
        public static LATCH create (int bytes, bool rotationInvariance, int half_ssd_size)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        LATCH retVal = new LATCH(xfeatures2d_LATCH_create_10(bytes, rotationInvariance, half_ssd_size));
        
        return retVal;
#else
            return;
#endif
        }

        //javadoc: LATCH::create()
        public static LATCH create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        LATCH retVal = new LATCH(xfeatures2d_LATCH_create_11());
        
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



        // C++: static Ptr_LATCH create(int bytes = 32, bool rotationInvariance = true, int half_ssd_size = 3)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_10 (int bytes, bool rotationInvariance, int half_ssd_size);

        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LATCH_create_11 ();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LATCH_delete (IntPtr nativeObj);

    }
}
