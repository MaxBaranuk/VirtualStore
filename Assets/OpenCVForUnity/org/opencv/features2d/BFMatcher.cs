
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class BFMatcher
//javadoc: BFMatcher
    public class BFMatcher : DescriptorMatcher
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
features2d_BFMatcher_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected BFMatcher (IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        //

        //javadoc: BFMatcher::BFMatcher(normType, crossCheck)
        public   BFMatcher (int normType, bool crossCheck) : 
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            base( features2d_BFMatcher_BFMatcher_10(normType, crossCheck) )
            #else
            base(IntPtr.Zero)
            #endif
        {

            return;

        }

        //javadoc: BFMatcher::BFMatcher()
        public   BFMatcher () : 
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            base( features2d_BFMatcher_BFMatcher_11() )
            #else
            base(IntPtr.Zero)
            #endif
        {

            return;

        }


        #if UNITY_IOS && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        #else
        const string LIBNAME = "opencvforunity";
        #endif



        // C++:   BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_10 (int normType, bool crossCheck);

        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_11 ();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BFMatcher_delete (IntPtr nativeObj);

    }
}
