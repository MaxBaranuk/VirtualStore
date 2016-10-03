
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class StarDetector
//javadoc: StarDetector
    public class StarDetector : Feature2D
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_StarDetector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected StarDetector (IntPtr addr) : base(addr)
        {
        }


        //
        // C++: static Ptr_StarDetector create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        //

        //javadoc: StarDetector::create(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized, suppressNonmaxSize)
        public static StarDetector create (int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        StarDetector retVal = new StarDetector(xfeatures2d_StarDetector_create_10(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized, suppressNonmaxSize));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: StarDetector::create()
        public static StarDetector create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        StarDetector retVal = new StarDetector(xfeatures2d_StarDetector_create_11());
        
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



        // C++: static Ptr_StarDetector create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_10 (int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize);

        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_11 ();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_StarDetector_delete (IntPtr nativeObj);

    }
}
