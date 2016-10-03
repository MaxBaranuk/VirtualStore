
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
    public class Face
    {
        //
        // C++:  Ptr_BIF createBIF(int num_bands = 8, int num_rotations = 12)
        //
        
        //javadoc: createBIF(num_bands, num_rotations)
        public static BIF createBIF (int num_bands, int num_rotations)
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            BIF retVal = new BIF(face_Face_createBIF_10(num_bands, num_rotations));
            
            return retVal;
            #else
            return null;
            #endif
        }
        
        //javadoc: createBIF()
        public static BIF createBIF ()
        {
            #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
            
            
            BIF retVal = new BIF(face_Face_createBIF_11());
            
            return retVal;
            #else
            return null;
            #endif
        }

        //
        // C++:  Ptr_BasicFaceRecognizer createEigenFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
        //

        //javadoc: createEigenFaceRecognizer(num_components, threshold)
        public static BasicFaceRecognizer createEigenFaceRecognizer (int num_components, double threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createEigenFaceRecognizer_10(num_components, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createEigenFaceRecognizer()
        public static BasicFaceRecognizer createEigenFaceRecognizer ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createEigenFaceRecognizer_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_BasicFaceRecognizer createFisherFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
        //

        //javadoc: createFisherFaceRecognizer(num_components, threshold)
        public static BasicFaceRecognizer createFisherFaceRecognizer (int num_components, double threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createFisherFaceRecognizer_10(num_components, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createFisherFaceRecognizer()
        public static BasicFaceRecognizer createFisherFaceRecognizer ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        BasicFaceRecognizer retVal = new BasicFaceRecognizer(face_Face_createFisherFaceRecognizer_11());
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  Ptr_LBPHFaceRecognizer createLBPHFaceRecognizer(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        //

        //javadoc: createLBPHFaceRecognizer(radius, neighbors, grid_x, grid_y, threshold)
        public static LBPHFaceRecognizer createLBPHFaceRecognizer (int radius, int neighbors, int grid_x, int grid_y, double threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        LBPHFaceRecognizer retVal = new LBPHFaceRecognizer(face_Face_createLBPHFaceRecognizer_10(radius, neighbors, grid_x, grid_y, threshold));
        
        return retVal;
#else
            return null;
#endif
        }

        //javadoc: createLBPHFaceRecognizer()
        public static LBPHFaceRecognizer createLBPHFaceRecognizer ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5

        
        LBPHFaceRecognizer retVal = new LBPHFaceRecognizer(face_Face_createLBPHFaceRecognizer_11());
        
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

        // C++:  Ptr_BIF createBIF(int num_bands = 8, int num_rotations = 12)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createBIF_10 (int num_bands, int num_rotations);

        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createBIF_11 ();

        // C++:  Ptr_BasicFaceRecognizer createEigenFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createEigenFaceRecognizer_10 (int num_components, double threshold);

        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createEigenFaceRecognizer_11 ();

        // C++:  Ptr_BasicFaceRecognizer createFisherFaceRecognizer(int num_components = 0, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFisherFaceRecognizer_10 (int num_components, double threshold);

        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createFisherFaceRecognizer_11 ();

        // C++:  Ptr_LBPHFaceRecognizer createLBPHFaceRecognizer(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createLBPHFaceRecognizer_10 (int radius, int neighbors, int grid_x, int grid_y, double threshold);

        [DllImport(LIBNAME)]
        private static extern IntPtr face_Face_createLBPHFaceRecognizer_11 ();

    }
}
