
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class MSDDetector
//javadoc: MSDDetector
    public class MSDDetector : Feature2D
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_MSDDetector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected MSDDetector (IntPtr addr) : base(addr)
        {
        }


    



        // native support for java finalize()
        [DllImport("opencvforunity")]
        private static extern void xfeatures2d_MSDDetector_delete (IntPtr nativeObj);

    }
}
