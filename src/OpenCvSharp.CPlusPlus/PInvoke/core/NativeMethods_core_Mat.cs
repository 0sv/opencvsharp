﻿using System;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace OpenCvSharp.CPlusPlus
{
    static partial class NativeMethods
    {
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong core_Mat_sizeof();

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new1();
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new2(int rows, int cols, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new3(int rows, int cols, int type, CvScalar scalar);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new4(IntPtr mat, Range rowRange, Range colRange);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new5(IntPtr mat, Range rowRange);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new6(IntPtr mat, [MarshalAs(UnmanagedType.LPArray)] Range[] rowRange);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new7(IntPtr mat, CvRect roi);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new8(int rows, int cols, int type, IntPtr data, IntPtr step);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new9(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, 
            int type, IntPtr data, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] steps);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new9(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes,
                                int type, IntPtr data, IntPtr steps);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new10(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new11(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type, CvScalar s);
        
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new_FromIplImage(IntPtr img, int copyData);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_new_FromCvMat(IntPtr mat, int copyData);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_release(IntPtr mat);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_delete(IntPtr mat);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_adjustROI(IntPtr nativeObj, int dtop, int dbottom, int dleft, int dright);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_assignTo1")]
        public static extern void core_Mat_assignTo(IntPtr self, IntPtr m);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_assignTo2")]
        public static extern void core_Mat_assignTo(IntPtr self, IntPtr m, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_channels(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_checkVector1")]
        public static extern int core_Mat_checkVector(IntPtr self, int elemChannels);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_checkVector2")]
        public static extern int core_Mat_checkVector(IntPtr self, int elemChannels, int depth);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_checkVector3")]
        public static extern int core_Mat_checkVector(IntPtr self, int elemChannels, int depth, int requireContinuous);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_clone(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_col_toMat(IntPtr self, int x);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_col_toMatExpr(IntPtr self, int x);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_cols(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_colRange_toMat(IntPtr self, int startCol, int endCol);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_colRange_toMatExpr(IntPtr self, int startCol, int endCol);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_dims(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_convertTo(IntPtr self, IntPtr m, int rtype, double alpha, double beta);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_copyTo(IntPtr self, IntPtr m, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_create1")]
        public static extern void core_Mat_create(IntPtr self, int rows, int cols, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_create2")]
        public static extern void core_Mat_create(IntPtr self, int ndims, 
            [MarshalAs(UnmanagedType.LPArray)] int[] sizes, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_cross(IntPtr self, IntPtr m);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_refcount(IntPtr self);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe byte* core_Mat_data(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_datastart(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_dataend(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_datalimit(IntPtr self);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_depth(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_diag1")]
        public static extern IntPtr core_Mat_diag(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_diag2")]
        public static extern IntPtr core_Mat_diag(IntPtr self, int d);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern double core_Mat_dot(IntPtr self, IntPtr m);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong core_Mat_elemSize(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong core_Mat_elemSize1(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_empty(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_eye(int rows, int cols, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_inv1")]
        public static extern IntPtr core_Mat_inv(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_inv2")]
        public static extern IntPtr core_Mat_inv(IntPtr self, int method);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_isContinuous(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_isSubmatrix(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_locateROI(IntPtr self, out CvSize wholeSize, out CvPoint ofs);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_mul1")]
        public static extern IntPtr core_Mat_mul(IntPtr self, IntPtr m);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_mul2")]
        public static extern IntPtr core_Mat_mul(IntPtr self, IntPtr m, double scale);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_ones1")]
        public static extern IntPtr core_Mat_ones(int rows, int cols, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_ones2")]
        public static extern IntPtr core_Mat_ones(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sz, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_reshape1")]
        public static extern IntPtr core_Mat_reshape(IntPtr self, int cn);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_reshape2")]
        public static extern IntPtr core_Mat_reshape(IntPtr self, int cn, int rows);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_reshape3")]
        public static extern IntPtr core_Mat_reshape(IntPtr self, int cn, int newndims, [MarshalAs(UnmanagedType.LPArray)] int[] newsz);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_rows(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_row_toMat(IntPtr self, int y);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_row_toMatExpr(IntPtr self, int y);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_rowRange_toMat(IntPtr self, int startRow, int endRow);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_rowRange_toMatExpr(IntPtr self, int startRow, int endRow);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_setTo_Scalar")]
        public static extern IntPtr core_Mat_setTo(IntPtr self, CvScalar value, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_setTo_InputArray")]
        public static extern IntPtr core_Mat_setTo(IntPtr self, IntPtr value, IntPtr mask);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern CvSize core_Mat_size(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_sizeAt(IntPtr self, int i);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_step11")]
        public static extern ulong core_Mat_step1(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_step12")]
        public static extern ulong core_Mat_step1(IntPtr self, int i);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern long core_Mat_step(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong core_Mat_stepAt(IntPtr self, int i);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_subMat1")]
        public static extern IntPtr core_Mat_subMat(IntPtr self, int rowStart, int rowEnd, int colStart, int colEnd);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_subMat2")]
        public static extern IntPtr core_Mat_subMat(IntPtr self, int nRanges, CvSlice[] ranges);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_t(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong core_Mat_total(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_type(IntPtr self);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_zeros1")]
        public static extern IntPtr core_Mat_zeros(int rows, int cols, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, EntryPoint = "core_Mat_zeros2")]
        public static extern IntPtr core_Mat_zeros(int ndims, [MarshalAs(UnmanagedType.LPArray)] int[] sz, int type);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern unsafe sbyte* core_Mat_dump(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string format);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void core_Mat_dump_delete(sbyte* buf);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_ptr1d(IntPtr self, int i0);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_ptr2d(IntPtr self, int i0, int i1);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_ptr3d(IntPtr self, int i0, int i1, int i2);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_Mat_ptrnd(IntPtr self, [MarshalAs(UnmanagedType.LPArray)] int[] idx);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_assignment_FromMat(IntPtr self, IntPtr newMat);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_assignment_FromMatExpr(IntPtr self, IntPtr newMatExpr);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_assignment_FromScalar(IntPtr self, CvScalar scalar);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_IplImage(IntPtr self, IntPtr outImage);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_IplImage_alignment(IntPtr self, out IntPtr outImage);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_CvMat(IntPtr self, IntPtr outMat);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorUnaryMinus_Mat(IntPtr mat);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorAdd_MatMat(IntPtr a, IntPtr b);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorAdd_MatScalar(IntPtr a, CvScalar s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorAdd_ScalarMat(CvScalar s, IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorMinus_Mat(IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorSubtract_MatMat(IntPtr a, IntPtr b);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorSubtract_MatScalar(IntPtr a, CvScalar s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorSubtract_ScalarMat(CvScalar s, IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorMultiply_MatMat(IntPtr a, IntPtr b);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorMultiply_MatDouble(IntPtr a, double s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorMultiply_DoubleMat(double s, IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorDivide_MatMat(IntPtr a, IntPtr b);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorDivide_MatDouble(IntPtr a, double s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorDivide_DoubleMat(double s, IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorAnd_MatMat(IntPtr a, IntPtr b);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorAnd_MatDouble(IntPtr a, double s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorAnd_DoubleMat(double s, IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorOr_MatMat(IntPtr a, IntPtr b);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorOr_MatDouble(IntPtr a, double s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorOr_DoubleMat(double s, IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorXor_MatMat(IntPtr a, IntPtr b);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorXor_MatDouble(IntPtr a, double s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorXor_DoubleMat(double s, IntPtr a);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_operatorNot_Mat(IntPtr a);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr core_abs_Mat(IntPtr e);

        #region nSet
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetB(IntPtr obj, int row, int col, 
            [In, MarshalAs(UnmanagedType.LPArray)] byte[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetB(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] byte[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetS(IntPtr obj, int row, int col, 
            [In, MarshalAs(UnmanagedType.LPArray)] short[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetS(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] short[,] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetS(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] ushort[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetS(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] ushort[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetI(IntPtr obj, int row, int col, 
            [In, MarshalAs(UnmanagedType.LPArray)] int[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetI(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] int[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetF(IntPtr obj, int row, int col, 
            [In, MarshalAs(UnmanagedType.LPArray)] float[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetF(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] float[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetD(IntPtr obj, int row, int col, 
            [In, MarshalAs(UnmanagedType.LPArray)] double[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetD(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] double[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec3b(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3b[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec3b(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3b[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec3d(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3d[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec3d(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec3d[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec4f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec4f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec6f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec6f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec6f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec6f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec4i(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4i[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetVec4i(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Vec4i[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint2f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint2f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint2d(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2d[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint2d(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point2d[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint3i(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3i[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint3i(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3i[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint3f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint3f(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint3d(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3d[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetPoint3d(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Point3d[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetRect(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Rect[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nSetRect(IntPtr obj, int row, int col,
            [In, MarshalAs(UnmanagedType.LPArray)] Rect[,] vals, int valsLength);
        #endregion

        #region nGet
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetB(IntPtr obj, int row, int col, 
            [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetB(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetS(IntPtr obj, int row, int col, 
            [In, Out, MarshalAs(UnmanagedType.LPArray)] short[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetS(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] short[,] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetS(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] ushort[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetS(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] ushort[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetI(IntPtr obj, int row, int col, 
            [In, Out, MarshalAs(UnmanagedType.LPArray)] int[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetI(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] int[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetF(IntPtr obj, int row, int col, 
            [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetF(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] float[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetD(IntPtr obj, int row, int col, 
            [In, Out, MarshalAs(UnmanagedType.LPArray)] double[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetD(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] double[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec3b(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3b[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec3b(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3b[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec3d(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3d[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec3d(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec3d[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec4f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec4f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec6f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec6f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec6f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec6f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec4i(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4i[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetVec4i(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Vec4i[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint2f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint2f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint2d(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2d[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint2d(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point2d[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint3i(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3i[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint3i(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3i[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint3f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3f[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint3f(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3f[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint3d(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3d[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetPoint3d(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Point3d[,] vals, int valsLength);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetRect(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Rect[] vals, int valsLength);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern int core_Mat_nGetRect(IntPtr obj, int row, int col,
            [In, Out, MarshalAs(UnmanagedType.LPArray)] Rect[,] vals, int valsLength);
        #endregion

        #region push_back
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Mat(IntPtr self, IntPtr m);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_char(IntPtr self, sbyte v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_uchar(IntPtr self, byte v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_short(IntPtr self, short v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_ushort(IntPtr self, ushort v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_int(IntPtr self, int v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_float(IntPtr self, float v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_double(IntPtr self, double v);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec2b(IntPtr self, Vec2b v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec3b(IntPtr self, Vec3b v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec4b(IntPtr self, Vec4b v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec6b(IntPtr self, Vec6b v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec2s(IntPtr self, Vec2s v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec3s(IntPtr self, Vec3s v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec4s(IntPtr self, Vec4s v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec6s(IntPtr self, Vec6s v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec2w(IntPtr self, Vec2w v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec3w(IntPtr self, Vec3w v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec4w(IntPtr self, Vec4w v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec6w(IntPtr self, Vec6w v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec2i(IntPtr self, Vec2i v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec3i(IntPtr self, Vec3i v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec4i(IntPtr self, Vec4i v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec6i(IntPtr self, Vec6i v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec2f(IntPtr self, Vec2f v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec3f(IntPtr self, Vec3f v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec4f(IntPtr self, Vec4f v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec6f(IntPtr self, Vec6f v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec2d(IntPtr self, Vec2d v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec3d(IntPtr self, Vec3d v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Vec6d(IntPtr self, Vec6d v);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Point(IntPtr self, Point v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Point2f(IntPtr self, Point2f v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Point2d(IntPtr self, Point2d v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Point3i(IntPtr self, Point3i v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Point3f(IntPtr self, Point3f v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Point3d(IntPtr self, Point3d v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Size(IntPtr self, Size v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Size2f(IntPtr self, Size2f v);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_push_back_Rect(IntPtr self, Rect v);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_reserve(IntPtr obj, IntPtr sz);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_resize1(IntPtr obj, IntPtr sz);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_resize2(IntPtr obj, IntPtr sz, CvScalar s);
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void core_Mat_pop_back(IntPtr obj, IntPtr nelems);
        #endregion
    }
}