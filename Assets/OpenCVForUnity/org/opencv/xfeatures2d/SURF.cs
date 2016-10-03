
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class SURF
//javadoc: SURF
    public class SURF : Feature2D
    {
        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_SURF_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected SURF (IntPtr addr) : base(addr)
        {
        }


        //
        // C++: static Ptr_SURF create(double hessianThreshold = 100, int nOctaves = 4, int nOctaveLayers = 3, bool extended = false, bool upright = false)
        //

        //javadoc: SURF::create(hessianThreshold, nOctaves, nOctaveLayers, extended, upright)
        public static SURF create (double hessianThreshold, int nOctaves, int nOctaveLayers, bool extended, bool upright)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        SURF retVal = new SURF(xfeatures2d_SURF_create_10(hessianThreshold, nOctaves, nOctaveLayers, extended, upright));
        
        return retVal;
#else
            return;
#endif
        }

        //javadoc: SURF::create()
        public static SURF create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        SURF retVal = new SURF(xfeatures2d_SURF_create_11());
        
        return retVal;
#else
            return;
#endif
        }


        //
        // C++:  bool getExtended()
        //

        //javadoc: SURF::getExtended()
        public  bool getExtended ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = xfeatures2d_SURF_getExtended_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  bool getUpright()
        //

        //javadoc: SURF::getUpright()
        public  bool getUpright ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        bool retVal = xfeatures2d_SURF_getUpright_10(nativeObj);
        
        return retVal;
#else
            return false;
#endif
        }


        //
        // C++:  double getHessianThreshold()
        //

        //javadoc: SURF::getHessianThreshold()
        public  double getHessianThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        double retVal = xfeatures2d_SURF_getHessianThreshold_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int getNOctaveLayers()
        //

        //javadoc: SURF::getNOctaveLayers()
        public  int getNOctaveLayers ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = xfeatures2d_SURF_getNOctaveLayers_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  int getNOctaves()
        //

        //javadoc: SURF::getNOctaves()
        public  int getNOctaves ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        int retVal = xfeatures2d_SURF_getNOctaves_10(nativeObj);
        
        return retVal;
#else
            return -1;
#endif
        }


        //
        // C++:  void setExtended(bool extended)
        //

        //javadoc: SURF::setExtended(extended)
        public  void setExtended (bool extended)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xfeatures2d_SURF_setExtended_10(nativeObj, extended);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void setHessianThreshold(double hessianThreshold)
        //

        //javadoc: SURF::setHessianThreshold(hessianThreshold)
        public  void setHessianThreshold (double hessianThreshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xfeatures2d_SURF_setHessianThreshold_10(nativeObj, hessianThreshold);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void setNOctaveLayers(int nOctaveLayers)
        //

        //javadoc: SURF::setNOctaveLayers(nOctaveLayers)
        public  void setNOctaveLayers (int nOctaveLayers)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xfeatures2d_SURF_setNOctaveLayers_10(nativeObj, nOctaveLayers);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void setNOctaves(int nOctaves)
        //

        //javadoc: SURF::setNOctaves(nOctaves)
        public  void setNOctaves (int nOctaves)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xfeatures2d_SURF_setNOctaves_10(nativeObj, nOctaves);
        
        return;
#else
            return;
#endif
        }


        //
        // C++:  void setUpright(bool upright)
        //

        //javadoc: SURF::setUpright(upright)
        public  void setUpright (bool upright)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        xfeatures2d_SURF_setUpright_10(nativeObj, upright);
        
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



        // C++: static Ptr_SURF create(double hessianThreshold = 100, int nOctaves = 4, int nOctaveLayers = 3, bool extended = false, bool upright = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_SURF_create_10 (double hessianThreshold, int nOctaves, int nOctaveLayers, bool extended, bool upright);

        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_SURF_create_11 ();

        // C++:  bool getExtended()
        [DllImport(LIBNAME)]
        private static extern bool xfeatures2d_SURF_getExtended_10 (IntPtr nativeObj);

        // C++:  bool getUpright()
        [DllImport(LIBNAME)]
        private static extern bool xfeatures2d_SURF_getUpright_10 (IntPtr nativeObj);

        // C++:  double getHessianThreshold()
        [DllImport(LIBNAME)]
        private static extern double xfeatures2d_SURF_getHessianThreshold_10 (IntPtr nativeObj);

        // C++:  int getNOctaveLayers()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_SURF_getNOctaveLayers_10 (IntPtr nativeObj);

        // C++:  int getNOctaves()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_SURF_getNOctaves_10 (IntPtr nativeObj);

        // C++:  void setExtended(bool extended)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_SURF_setExtended_10 (IntPtr nativeObj, bool extended);

        // C++:  void setHessianThreshold(double hessianThreshold)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_SURF_setHessianThreshold_10 (IntPtr nativeObj, double hessianThreshold);

        // C++:  void setNOctaveLayers(int nOctaveLayers)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_SURF_setNOctaveLayers_10 (IntPtr nativeObj, int nOctaveLayers);

        // C++:  void setNOctaves(int nOctaves)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_SURF_setNOctaves_10 (IntPtr nativeObj, int nOctaves);

        // C++:  void setUpright(bool upright)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_SURF_setUpright_10 (IntPtr nativeObj, bool upright);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_SURF_delete (IntPtr nativeObj);

    }
}
