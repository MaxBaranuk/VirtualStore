
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class SelectiveSearchSegmentationStrategyMultiple
//javadoc: SelectiveSearchSegmentationStrategyMultiple
    public class SelectiveSearchSegmentationStrategyMultiple : SelectiveSearchSegmentationStrategy
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_SelectiveSearchSegmentationStrategyMultiple_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        public SelectiveSearchSegmentationStrategyMultiple (IntPtr addr) : base(addr)
        {
        }


        //
        // C++:  void addStrategy(Ptr_SelectiveSearchSegmentationStrategy g, float weight)
        //

        //javadoc: SelectiveSearchSegmentationStrategyMultiple::addStrategy(g, weight)
        public  void addStrategy (SelectiveSearchSegmentationStrategy g, float weight)
        {
            ThrowIfDisposed ();
            if (g != null)
                g.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ximgproc_SelectiveSearchSegmentationStrategyMultiple_addStrategy_10(nativeObj, g.nativeObj, weight);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void clearStrategies()
        //

        //javadoc: SelectiveSearchSegmentationStrategyMultiple::clearStrategies()
        public  void clearStrategies ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        ximgproc_SelectiveSearchSegmentationStrategyMultiple_clearStrategies_10(nativeObj);
        
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



        // C++:  void addStrategy(Ptr_SelectiveSearchSegmentationStrategy g, float weight)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategyMultiple_addStrategy_10 (IntPtr nativeObj, IntPtr g_nativeObj, float weight);

        // C++:  void clearStrategies()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategyMultiple_clearStrategies_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategyMultiple_delete (IntPtr nativeObj);

    }
}
