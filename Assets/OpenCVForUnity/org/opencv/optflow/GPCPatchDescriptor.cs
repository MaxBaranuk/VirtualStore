
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class GPCPatchDescriptor
//javadoc: GPCPatchDescriptor
    public class GPCPatchDescriptor : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
optflow_GPCPatchDescriptor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected GPCPatchDescriptor (IntPtr addr) : base(addr)
        {
        }


        #if UNITY_IOS && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        #else
        const string LIBNAME = "opencvforunity";
        #endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void optflow_GPCPatchDescriptor_delete (IntPtr nativeObj);

    }
}
