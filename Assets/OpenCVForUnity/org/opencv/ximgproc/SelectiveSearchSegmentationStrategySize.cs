
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class SelectiveSearchSegmentationStrategySize
//javadoc: SelectiveSearchSegmentationStrategySize
    public class SelectiveSearchSegmentationStrategySize : SelectiveSearchSegmentationStrategy
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_SelectiveSearchSegmentationStrategySize_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        public SelectiveSearchSegmentationStrategySize (IntPtr addr) : base(addr)
        {
        }


        #if UNITY_IOS && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        #else
        const string LIBNAME = "opencvforunity";
        #endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategySize_delete (IntPtr nativeObj);

    }
}
