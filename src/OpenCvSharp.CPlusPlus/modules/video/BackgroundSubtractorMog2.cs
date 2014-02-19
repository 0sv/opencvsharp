using System;
using OpenCvSharp.Utilities;

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// The Base Class for Background/Foreground Segmentation.
    /// The class is only used to define the common interface for
    /// the whole family of background/foreground segmentation algorithms.
    /// </summary>
    public class BackgroundSubtractorMog2 : BackgroundSubtractor
    {
        /// <summary>
        /// sizeof(BackgroundSubtractorMOG2)
        /// </summary>
        public static new readonly int SizeOf = CppInvoke.video_BackgroundSubtractorMOG2_sizeof().ToInt32();

        #region Init
        /// <summary>
        /// the default constructor
        /// </summary>
        public BackgroundSubtractorMog2()
        {
            ptr = CppInvoke.video_BackgroundSubtractorMOG2_new1();
            if (ptr == IntPtr.Zero)
                throw new OpenCvSharpException();
        }
        /// <summary>
        /// the full constructor that takes the length of the history, the number of gaussian mixtures, the background ratio parameter and the noise strength
        /// </summary>
        /// <param name="history"></param>
        /// <param name="varThreshold"></param>
        /// <param name="bShadowDetection"></param>
        public BackgroundSubtractorMog2(int history, float varThreshold, bool bShadowDetection = true)
        {
            ptr = CppInvoke.video_BackgroundSubtractorMOG2_new2(history, varThreshold, bShadowDetection ? 1 : 0);
            if (ptr == IntPtr.Zero)
                throw new OpenCvSharpException();
        }
        #endregion
        #region Dispose
#if LANG_JP
    /// <summary>
    /// ���\�[�X�̉��
    /// </summary>
#else
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
#endif
        public void Release()
        {
            Dispose(true);
        }
#if LANG_JP
    /// <summary>
    /// ���\�[�X�̉��
    /// </summary>
    /// <param name="disposing">
    /// true�̏ꍇ�́A���̃��\�b�h�����[�U�R�[�h���璼�ڂ��Ă΂ꂽ���Ƃ������B�}�l�[�W�E�A���}�l�[�W�o���̃��\�[�X����������B
    /// false�̏ꍇ�́A���̃��\�b�h�̓����^�C������t�@�C�i���C�U�ɂ���ČĂ΂�A�����ق��̃I�u�W�F�N�g����Q�Ƃ���Ă��Ȃ����Ƃ������B�A���}�l�[�W���\�[�X�̂݉�������B
    ///</param>
#else
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// If disposing equals true, the method has been called directly or indirectly by a user's code. Managed and unmanaged resources can be disposed.
        /// If false, the method has been called by the runtime from inside the finalizer and you should not reference other objects. Only unmanaged resources can be disposed.
        /// </param>
#endif
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // �p�������N���X�Ǝ��̉������
                try
                {
                    if (disposing)
                    {
                    }
                    if (IsEnabledDispose)
                    {
                        CppInvoke.video_BackgroundSubtractorMOG2_delete(ptr);
                    }
                    disposed = true;
                }
                finally
                {
                    // �e�̉������
                    base.Dispose(disposing);
                }
            }
        }
        #endregion

        /// <summary>
        /// the update operator
        /// </summary>
        /// <param name="image"></param>
        /// <param name="fgmask"></param>
        /// <param name="learningRate"></param>
        public override void Run(InputArray image, OutputArray fgmask, double learningRate = 0)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            if (fgmask == null)
                throw new ArgumentNullException("fgmask");
            CppInvoke.video_BackgroundSubtractorMOG2_operator(ptr, image.CvPtr, fgmask.CvPtr, learningRate);
        }

        /// <summary>
        /// computes a background image
        /// </summary>
        /// <param name="backgroundImage"></param>
        public override void GetBackgroundImage(OutputArray backgroundImage)
        {
            if (backgroundImage == null)
                throw new ArgumentNullException("backgroundImage");
            CppInvoke.video_BackgroundSubtractorMOG2_getBackgroundImage(ptr, backgroundImage.CvPtr);
        }

        /// <summary>
        /// re-initiaization method
        /// </summary>
        /// <param name="frameSize"></param>
        /// <param name="frameType"></param>
        public virtual void Initialize(CvSize frameSize, int frameType)
        {
            CppInvoke.video_BackgroundSubtractorMOG2_initialize(ptr, frameSize, frameType);
        }

        #region Properties
        /*
        /// <summary>
        /// 
        /// </summary>
        public CvSize FrameSize
        {
            get
            {
                return CppInvoke.BackgroundSubtractorMOG2_frameSize_get(_ptr);
            }
            set
            {
                CppInvoke.BackgroundSubtractorMOG2_frameSize_set(_ptr, value);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int FrameType
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_frameType(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_frameType(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Mat BgModel
        {
            get
            {
                unsafe
                {
                    return new Mat(CppInvoke.BackgroundSubtractorMOG2_bgmodel(_ptr));
                }
            }
        }
        /// <summary>
        /// keep track of number of modes per pixel
        /// </summary>
        public Mat BgmodelUsedModes
        {
            get
            {
                unsafe
                {
                    return new Mat(CppInvoke.BackgroundSubtractorMOG2_bgmodelUsedModes(_ptr));
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Nframes
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_nframes(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_nframes(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int History
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_history(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_history(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Nmixtures
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_nmixtures(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_nmixtures(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// here it is the maximum allowed number of mixture comonents.
        /// Actual number is determined dynamically per pixel.
        /// </summary>
        public float VarThreshold
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_varThreshold(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_varThreshold(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public float BackgroundRatio
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_backgroundRatio(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_backgroundRatio(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public float VarThresholdGen
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_varThresholdGen(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_varThresholdGen(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public float FVarInit
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_fVarInit(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_fVarInit(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public float FVarMin
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_fVarMin(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_fVarMin(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public float fVarMax
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_fVarMax(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_fVarMax(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// CT - complexity reduction prior
        /// </summary>
        public float FCT
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_fCT(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_fCT(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// default 1 - do shadow detection
        /// </summary>
        public bool BShadowDetection
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_bShadowDetection(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_bShadowDetection(_ptr) = value;
                }
            }
        }//
        /// <summary>
        /// do shadow detection - insert this value as the detection result - 127 default value
        /// </summary>
        public byte NShadowDetection
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_nShadowDetection(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_nShadowDetection(_ptr) = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public float FTau
        {
            get
            {
                unsafe
                {
                    return *CppInvoke.BackgroundSubtractorMOG2_fTau(_ptr);
                }
            }
            set
            {
                unsafe
                {
                    *CppInvoke.BackgroundSubtractorMOG2_fTau(_ptr) = value;
                }
            }
        }
        //*/
        #endregion
    }
}