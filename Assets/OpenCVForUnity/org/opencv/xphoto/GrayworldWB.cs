
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class GrayworldWB
//javadoc: GrayworldWB
    public class GrayworldWB : WhiteBalancer
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xphoto_GrayworldWB_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        public GrayworldWB (IntPtr addr) : base(addr)
        {
        }


        //
        // C++:  float getSaturationThreshold()
        //

        //javadoc: GrayworldWB::getSaturationThreshold()
        public  float getSaturationThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        float retVal = xphoto_GrayworldWB_getSaturationThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void setSaturationThreshold(float val)
        //

        //javadoc: GrayworldWB::setSaturationThreshold(val)
        public  void setSaturationThreshold (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xphoto_GrayworldWB_setSaturationThreshold_10(nativeObj, val);
        
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



        // C++:  float getSaturationThreshold()
        [DllImport(LIBNAME)]
        private static extern float xphoto_GrayworldWB_getSaturationThreshold_10 (IntPtr nativeObj);

        // C++:  void setSaturationThreshold(float val)
        [DllImport(LIBNAME)]
        private static extern void xphoto_GrayworldWB_setSaturationThreshold_10 (IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_GrayworldWB_delete (IntPtr nativeObj);

    }
}
