
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class LUCID
//javadoc: LUCID
    public class LUCID : Feature2D
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_LUCID_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected LUCID (IntPtr addr) : base(addr)
        {
        }


        //
        // C++: static Ptr_LUCID create(int lucid_kernel, int blur_kernel)
        //

        //javadoc: LUCID::create(lucid_kernel, blur_kernel)
        public static LUCID create (int lucid_kernel, int blur_kernel)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        LUCID retVal = new LUCID(xfeatures2d_LUCID_create_10(lucid_kernel, blur_kernel));
        
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



        // C++: static Ptr_LUCID create(int lucid_kernel, int blur_kernel)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_10 (int lucid_kernel, int blur_kernel);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LUCID_delete (IntPtr nativeObj);

    }
}
