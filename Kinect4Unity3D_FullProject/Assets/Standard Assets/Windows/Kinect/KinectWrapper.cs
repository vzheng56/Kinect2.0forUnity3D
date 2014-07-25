using RootSystem = System;
using System.Linq;
using System.Collections.Generic;
namespace Windows.Kinect
{

    #region Enums

    //
    // Windows.Kinect.KinectCapabilities
    //
    [RootSystem.Flags]
    public enum KinectCapabilities : uint
    {
        None                                     =0,
        Vision                                   =1,
        Audio                                    =2,
        Face                                     =4,
        Expressions                              =8,
        Gamechat                                 =16,
    }

    //
    // Windows.Kinect.FrameSourceTypes
    //
    [RootSystem.Flags]
    public enum FrameSourceTypes : uint
    {
        None                                     =0,
        Color                                    =1,
        Infrared                                 =2,
        LongExposureInfrared                     =4,
        Depth                                    =8,
        BodyIndex                                =16,
        Body                                     =32,
        Audio                                    =64,
    }

    //
    // Windows.Kinect.ColorImageFormat
    //
    public enum ColorImageFormat : int
    {
        None                                     =0,
        Rgba                                     =1,
        Yuv                                      =2,
        Bgra                                     =3,
        Bayer                                    =4,
        Yuy2                                     =5,
    }

    //
    // Windows.Kinect.HandState
    //
    public enum HandState : int
    {
        Unknown                                  =0,
        NotTracked                               =1,
        Open                                     =2,
        Closed                                   =3,
        Lasso                                    =4,
    }

    //
    // Windows.Kinect.Expression
    //
    public enum Expression : int
    {
        Neutral                                  =0,
        Happy                                    =1,
    }

    //
    // Windows.Kinect.DetectionResult
    //
    public enum DetectionResult : int
    {
        Unknown                                  =0,
        No                                       =1,
        Maybe                                    =2,
        Yes                                      =3,
    }

    //
    // Windows.Kinect.TrackingConfidence
    //
    public enum TrackingConfidence : int
    {
        Low                                      =0,
        High                                     =1,
    }

    //
    // Windows.Kinect.Activity
    //
    public enum Activity : int
    {
        EyeLeftClosed                            =0,
        EyeRightClosed                           =1,
        MouthOpen                                =2,
        MouthMoved                               =3,
        LookingAway                              =4,
    }

    //
    // Windows.Kinect.Appearance
    //
    public enum Appearance : int
    {
        WearingGlasses                           =0,
    }

    //
    // Windows.Kinect.JointType
    //
    public enum JointType : int
    {
        SpineBase                                =0,
        SpineMid                                 =1,
        Neck                                     =2,
        Head                                     =3,
        ShoulderLeft                             =4,
        ElbowLeft                                =5,
        WristLeft                                =6,
        HandLeft                                 =7,
        ShoulderRight                            =8,
        ElbowRight                               =9,
        WristRight                               =10,
        HandRight                                =11,
        HipLeft                                  =12,
        KneeLeft                                 =13,
        AnkleLeft                                =14,
        FootLeft                                 =15,
        HipRight                                 =16,
        KneeRight                                =17,
        AnkleRight                               =18,
        FootRight                                =19,
        SpineShoulder                            =20,
        HandTipLeft                              =21,
        ThumbLeft                                =22,
        HandTipRight                             =23,
        ThumbRight                               =24,
    }

    //
    // Windows.Kinect.TrackingState
    //
    public enum TrackingState : int
    {
        NotTracked                               =0,
        Inferred                                 =1,
        Tracked                                  =2,
    }

    //
    // Windows.Kinect.FrameEdges
    //
    [RootSystem.Flags]
    public enum FrameEdges : uint
    {
        None                                     =0,
        Right                                    =1,
        Left                                     =2,
        Top                                      =4,
        Bottom                                   =8,
    }

    //
    // Windows.Kinect.FrameCapturedStatus
    //
    public enum FrameCapturedStatus : int
    {
        Unknown                                  =0,
        Queued                                   =1,
        Dropped                                  =2,
    }

    //
    // Windows.Kinect.AudioBeamMode
    //
    public enum AudioBeamMode : int
    {
        Automatic                                =0,
        Manual                                   =1,
    }

    //
    // Windows.Kinect.KinectAudioCalibrationState
    //
    public enum KinectAudioCalibrationState : int
    {
        Unknown                                  =0,
        CalibrationRequired                      =1,
        Calibrated                               =2,
    }

    #endregion // Enums

    #region Structs

    //
    // Windows.Kinect.Vector4
    //
    [RootSystem.Runtime.InteropServices.StructLayout(RootSystem.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Vector4
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vector4))
            {
                return false;
            }

            return this.Equals((Vector4)obj);
        }

        public bool Equals(Vector4 obj)
        {
            return X.Equals(obj) && Y.Equals(obj) && Z.Equals(obj) && W.Equals(obj);
        }

        public static bool operator ==(Vector4 a, Vector4 b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Vector4 a, Vector4 b)
        {
            return !(a.Equals(b));
        }
    }

    //
    // Windows.Kinect.ColorSpacePoint
    //
    [RootSystem.Runtime.InteropServices.StructLayout(RootSystem.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct ColorSpacePoint
    {
        public float X { get; set; }
        public float Y { get; set; }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ColorSpacePoint))
            {
                return false;
            }

            return this.Equals((ColorSpacePoint)obj);
        }

        public bool Equals(ColorSpacePoint obj)
        {
            return X.Equals(obj) && Y.Equals(obj);
        }

        public static bool operator ==(ColorSpacePoint a, ColorSpacePoint b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(ColorSpacePoint a, ColorSpacePoint b)
        {
            return !(a.Equals(b));
        }
    }

    //
    // Windows.Kinect.DepthSpacePoint
    //
    [RootSystem.Runtime.InteropServices.StructLayout(RootSystem.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct DepthSpacePoint
    {
        public float X { get; set; }
        public float Y { get; set; }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is DepthSpacePoint))
            {
                return false;
            }

            return this.Equals((DepthSpacePoint)obj);
        }

        public bool Equals(DepthSpacePoint obj)
        {
            return X.Equals(obj) && Y.Equals(obj);
        }

        public static bool operator ==(DepthSpacePoint a, DepthSpacePoint b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(DepthSpacePoint a, DepthSpacePoint b)
        {
            return !(a.Equals(b));
        }
    }

    //
    // Windows.Kinect.CameraSpacePoint
    //
    [RootSystem.Runtime.InteropServices.StructLayout(RootSystem.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CameraSpacePoint
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CameraSpacePoint))
            {
                return false;
            }

            return this.Equals((CameraSpacePoint)obj);
        }

        public bool Equals(CameraSpacePoint obj)
        {
            return X.Equals(obj) && Y.Equals(obj) && Z.Equals(obj);
        }

        public static bool operator ==(CameraSpacePoint a, CameraSpacePoint b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(CameraSpacePoint a, CameraSpacePoint b)
        {
            return !(a.Equals(b));
        }
    }

    //
    // Windows.Kinect.Joint
    //
    [RootSystem.Runtime.InteropServices.StructLayout(RootSystem.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Joint
    {
        public Windows.Kinect.JointType JointType { get; set; }
        public Windows.Kinect.CameraSpacePoint Position { get; set; }
        public Windows.Kinect.TrackingState TrackingState { get; set; }

        public override int GetHashCode()
        {
            return JointType.GetHashCode() ^ Position.GetHashCode() ^ TrackingState.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Joint))
            {
                return false;
            }

            return this.Equals((Joint)obj);
        }

        public bool Equals(Joint obj)
        {
            return JointType.Equals(obj) && Position.Equals(obj) && TrackingState.Equals(obj);
        }

        public static bool operator ==(Joint a, Joint b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Joint a, Joint b)
        {
            return !(a.Equals(b));
        }
    }

    //
    // Windows.Kinect.JointOrientation
    //
    [RootSystem.Runtime.InteropServices.StructLayout(RootSystem.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct JointOrientation
    {
        public Windows.Kinect.JointType JointType { get; set; }
        public Windows.Kinect.Vector4 Orientation { get; set; }

        public override int GetHashCode()
        {
            return JointType.GetHashCode() ^ Orientation.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is JointOrientation))
            {
                return false;
            }

            return this.Equals((JointOrientation)obj);
        }

        public bool Equals(JointOrientation obj)
        {
            return JointType.Equals(obj) && Orientation.Equals(obj);
        }

        public static bool operator ==(JointOrientation a, JointOrientation b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(JointOrientation a, JointOrientation b)
        {
            return !(a.Equals(b));
        }
    }

    #endregion // Structs

    #region Classes

    //
    // Windows.Kinect.KinectSensor
    //
    public sealed partial class KinectSensor
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal KinectSensor(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_KinectSensor_AddRefObject(ref _pNative);
        }

        ~KinectSensor()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_KinectSensor_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_KinectSensor_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<KinectSensor>(_pNative);
                Windows_Kinect_KinectSensor_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_AudioSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.AudioSource AudioSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_AudioSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_BodyFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyFrameSource BodyFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_BodyFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_BodyIndexFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyIndexFrameSource BodyIndexFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_BodyIndexFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyIndexFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_ColorFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.ColorFrameSource ColorFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_ColorFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.ColorFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_CoordinateMapper(RootSystem.IntPtr pNative);
        public  Windows.Kinect.CoordinateMapper CoordinateMapper
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_CoordinateMapper(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.CoordinateMapper>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.CoordinateMapper(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.CoordinateMapper>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_DepthFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.DepthFrameSource DepthFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_DepthFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.DepthFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_InfraredFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.InfraredFrameSource InfraredFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_InfraredFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.InfraredFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_KinectSensor_get_IsAvailable(RootSystem.IntPtr pNative);
        public  bool IsAvailable
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                return Windows_Kinect_KinectSensor_get_IsAvailable(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_KinectSensor_get_IsOpen(RootSystem.IntPtr pNative);
        public  bool IsOpen
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                return Windows_Kinect_KinectSensor_get_IsOpen(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.KinectCapabilities Windows_Kinect_KinectSensor_get_KinectCapabilities(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectCapabilities KinectCapabilities
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                return Windows_Kinect_KinectSensor_get_KinectCapabilities(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_LongExposureInfraredFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.LongExposureInfraredFrameSource LongExposureInfraredFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_LongExposureInfraredFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.LongExposureInfraredFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_get_UniqueKinectId(RootSystem.IntPtr pNative);
        public  string UniqueKinectId
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("KinectSensor");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_get_UniqueKinectId(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                return RootSystem.Runtime.InteropServices.Marshal.PtrToStringUni(objectPointer);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_IsAvailableChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_IsAvailableChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.IsAvailableChangedEventArgs>>> Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.IsAvailableChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_IsAvailableChangedEventArgs_Delegate))]
        private static void Windows_Kinect_IsAvailableChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.IsAvailableChangedEventArgs>>();
            }
            var callbackList = Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<KinectSensor>(pNative);
                    var args = new Windows.Kinect.IsAvailableChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_KinectSensor_add_IsAvailableChanged(RootSystem.IntPtr pNative, _Windows_Kinect_IsAvailableChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.IsAvailableChangedEventArgs> IsAvailableChanged
        {
            add
            {
            if(!Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.IsAvailableChangedEventArgs>>());
            }
            var callbackList = Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_IsAvailableChangedEventArgs_Delegate(Windows_Kinect_IsAvailableChangedEventArgs_Delegate_Handler);
                        _Windows_Kinect_IsAvailableChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_KinectSensor_add_IsAvailableChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.IsAvailableChangedEventArgs>>();
            }
            var callbackList = Windows_Kinect_IsAvailableChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_KinectSensor_add_IsAvailableChanged(_pNative, Windows_Kinect_IsAvailableChangedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_IsAvailableChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<KinectSensor>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_KinectSensor_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_KinectSensor_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_KinectSensor_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Static Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_GetDefault();
        public static Windows.Kinect.KinectSensor GetDefault()
        {
            RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_GetDefault();
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.KinectSensor(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
            }

            return obj;
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_KinectSensor_Open(RootSystem.IntPtr pNative);
        public void Open()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("KinectSensor");
            }

            Windows_Kinect_KinectSensor_Open(_pNative);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_KinectSensor_Close(RootSystem.IntPtr pNative);
        public void Close()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("KinectSensor");
            }

            Windows_Kinect_KinectSensor_Close(_pNative);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_KinectSensor_OpenMultiSourceFrameReader(RootSystem.IntPtr pNative, Windows.Kinect.FrameSourceTypes enabledFrameSourceTypes);
        public Windows.Kinect.MultiSourceFrameReader OpenMultiSourceFrameReader(Windows.Kinect.FrameSourceTypes enabledFrameSourceTypes)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("KinectSensor");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_KinectSensor_OpenMultiSourceFrameReader(_pNative, enabledFrameSourceTypes);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.MultiSourceFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.MultiSourceFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.MultiSourceFrameReader>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.IsAvailableChangedEventArgs
    //
    public sealed partial class IsAvailableChangedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal IsAvailableChangedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_IsAvailableChangedEventArgs_AddRefObject(ref _pNative);
        }

        ~IsAvailableChangedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_IsAvailableChangedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_IsAvailableChangedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<IsAvailableChangedEventArgs>(_pNative);
                Windows_Kinect_IsAvailableChangedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_IsAvailableChangedEventArgs_get_IsAvailable(RootSystem.IntPtr pNative);
        public  bool IsAvailable
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("IsAvailableChangedEventArgs");
                }

                return Windows_Kinect_IsAvailableChangedEventArgs_get_IsAvailable(_pNative);
            }
        }

    }

    //
    // Windows.Kinect.ColorFrameSource
    //
    public sealed partial class ColorFrameSource
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal ColorFrameSource(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_ColorFrameSource_AddRefObject(ref _pNative);
        }

        ~ColorFrameSource()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameSource_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameSource_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<ColorFrameSource>(_pNative);
                Windows_Kinect_ColorFrameSource_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameSource_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameSource_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_ColorFrameSource_get_IsActive(RootSystem.IntPtr pNative);
        public  bool IsActive
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameSource");
                }

                return Windows_Kinect_ColorFrameSource_get_IsActive(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameSource_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameSource_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_FrameCapturedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>> Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_FrameCapturedEventArgs_Delegate))]
        private static void Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<ColorFrameSource>(pNative);
                    var args = new Windows.Kinect.FrameCapturedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameSource_add_FrameCaptured(RootSystem.IntPtr pNative, _Windows_Kinect_FrameCapturedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs> FrameCaptured
        {
            add
            {
            if(!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>());
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_FrameCapturedEventArgs_Delegate(Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_ColorFrameSource_add_FrameCaptured(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_ColorFrameSource_add_FrameCaptured(_pNative, Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<ColorFrameSource>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameSource_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_ColorFrameSource_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_ColorFrameSource_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameSource_OpenReader(RootSystem.IntPtr pNative);
        public Windows.Kinect.ColorFrameReader OpenReader()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("ColorFrameSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameSource_OpenReader(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.ColorFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrameReader>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameSource_CreateFrameDescription(RootSystem.IntPtr pNative, Windows.Kinect.ColorImageFormat format);
        public Windows.Kinect.FrameDescription CreateFrameDescription(Windows.Kinect.ColorImageFormat format)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("ColorFrameSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameSource_CreateFrameDescription(_pNative, format);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.FrameDescription(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.DepthFrameSource
    //
    public sealed partial class DepthFrameSource
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal DepthFrameSource(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_DepthFrameSource_AddRefObject(ref _pNative);
        }

        ~DepthFrameSource()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameSource_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameSource_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<DepthFrameSource>(_pNative);
                Windows_Kinect_DepthFrameSource_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern ushort Windows_Kinect_DepthFrameSource_get_DepthMaxReliableDistance(RootSystem.IntPtr pNative);
        public  ushort DepthMaxReliableDistance
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameSource");
                }

                return Windows_Kinect_DepthFrameSource_get_DepthMaxReliableDistance(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern ushort Windows_Kinect_DepthFrameSource_get_DepthMinReliableDistance(RootSystem.IntPtr pNative);
        public  ushort DepthMinReliableDistance
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameSource");
                }

                return Windows_Kinect_DepthFrameSource_get_DepthMinReliableDistance(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrameSource_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrameSource_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_DepthFrameSource_get_IsActive(RootSystem.IntPtr pNative);
        public  bool IsActive
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameSource");
                }

                return Windows_Kinect_DepthFrameSource_get_IsActive(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrameSource_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrameSource_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_FrameCapturedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>> Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_FrameCapturedEventArgs_Delegate))]
        private static void Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<DepthFrameSource>(pNative);
                    var args = new Windows.Kinect.FrameCapturedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameSource_add_FrameCaptured(RootSystem.IntPtr pNative, _Windows_Kinect_FrameCapturedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs> FrameCaptured
        {
            add
            {
            if(!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>());
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_FrameCapturedEventArgs_Delegate(Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_DepthFrameSource_add_FrameCaptured(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_DepthFrameSource_add_FrameCaptured(_pNative, Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<DepthFrameSource>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameSource_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_DepthFrameSource_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_DepthFrameSource_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrameSource_OpenReader(RootSystem.IntPtr pNative);
        public Windows.Kinect.DepthFrameReader OpenReader()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("DepthFrameSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrameSource_OpenReader(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.DepthFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrameReader>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.BodyFrameSource
    //
    public sealed partial class BodyFrameSource
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyFrameSource(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyFrameSource_AddRefObject(ref _pNative);
        }

        ~BodyFrameSource()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameSource_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameSource_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyFrameSource>(_pNative);
                Windows_Kinect_BodyFrameSource_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_BodyFrameSource_get_BodyCount(RootSystem.IntPtr pNative);
        public  int BodyCount
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameSource");
                }

                return Windows_Kinect_BodyFrameSource_get_BodyCount(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_BodyFrameSource_get_IsActive(RootSystem.IntPtr pNative);
        public  bool IsActive
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameSource");
                }

                return Windows_Kinect_BodyFrameSource_get_IsActive(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyFrameSource_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyFrameSource_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_FrameCapturedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>> Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_FrameCapturedEventArgs_Delegate))]
        private static void Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyFrameSource>(pNative);
                    var args = new Windows.Kinect.FrameCapturedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameSource_add_FrameCaptured(RootSystem.IntPtr pNative, _Windows_Kinect_FrameCapturedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs> FrameCaptured
        {
            add
            {
            if(!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>());
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_FrameCapturedEventArgs_Delegate(Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyFrameSource_add_FrameCaptured(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyFrameSource_add_FrameCaptured(_pNative, Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyFrameSource>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameSource_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyFrameSource_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyFrameSource_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyFrameSource_OpenReader(RootSystem.IntPtr pNative);
        public Windows.Kinect.BodyFrameReader OpenReader()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyFrameSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_BodyFrameSource_OpenReader(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.BodyFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrameReader>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameSource_OverrideHandTracking(RootSystem.IntPtr pNative, ulong trackingId);
        public void OverrideHandTracking(ulong trackingId)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyFrameSource");
            }

            Windows_Kinect_BodyFrameSource_OverrideHandTracking(_pNative, trackingId);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameSource_OverrideHandTracking_1(RootSystem.IntPtr pNative, ulong oldTrackingId, ulong newTrackingId);
        public void OverrideHandTracking(ulong oldTrackingId, ulong newTrackingId)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyFrameSource");
            }

            Windows_Kinect_BodyFrameSource_OverrideHandTracking_1(_pNative, oldTrackingId, newTrackingId);
        }

    }

    //
    // Windows.Kinect.BodyIndexFrameSource
    //
    public sealed partial class BodyIndexFrameSource
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyIndexFrameSource(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyIndexFrameSource_AddRefObject(ref _pNative);
        }

        ~BodyIndexFrameSource()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameSource_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameSource_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyIndexFrameSource>(_pNative);
                Windows_Kinect_BodyIndexFrameSource_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrameSource_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrameSource_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_BodyIndexFrameSource_get_IsActive(RootSystem.IntPtr pNative);
        public  bool IsActive
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameSource");
                }

                return Windows_Kinect_BodyIndexFrameSource_get_IsActive(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrameSource_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrameSource_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_FrameCapturedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>> Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_FrameCapturedEventArgs_Delegate))]
        private static void Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyIndexFrameSource>(pNative);
                    var args = new Windows.Kinect.FrameCapturedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameSource_add_FrameCaptured(RootSystem.IntPtr pNative, _Windows_Kinect_FrameCapturedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs> FrameCaptured
        {
            add
            {
            if(!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>());
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_FrameCapturedEventArgs_Delegate(Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyIndexFrameSource_add_FrameCaptured(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyIndexFrameSource_add_FrameCaptured(_pNative, Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyIndexFrameSource>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameSource_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyIndexFrameSource_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyIndexFrameSource_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrameSource_OpenReader(RootSystem.IntPtr pNative);
        public Windows.Kinect.BodyIndexFrameReader OpenReader()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyIndexFrameSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrameSource_OpenReader(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.BodyIndexFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrameReader>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.InfraredFrameSource
    //
    public sealed partial class InfraredFrameSource
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal InfraredFrameSource(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_InfraredFrameSource_AddRefObject(ref _pNative);
        }

        ~InfraredFrameSource()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameSource_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameSource_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<InfraredFrameSource>(_pNative);
                Windows_Kinect_InfraredFrameSource_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrameSource_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrameSource_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_InfraredFrameSource_get_IsActive(RootSystem.IntPtr pNative);
        public  bool IsActive
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameSource");
                }

                return Windows_Kinect_InfraredFrameSource_get_IsActive(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrameSource_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrameSource_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_FrameCapturedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>> Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_FrameCapturedEventArgs_Delegate))]
        private static void Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<InfraredFrameSource>(pNative);
                    var args = new Windows.Kinect.FrameCapturedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameSource_add_FrameCaptured(RootSystem.IntPtr pNative, _Windows_Kinect_FrameCapturedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs> FrameCaptured
        {
            add
            {
            if(!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>());
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_FrameCapturedEventArgs_Delegate(Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_InfraredFrameSource_add_FrameCaptured(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_InfraredFrameSource_add_FrameCaptured(_pNative, Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<InfraredFrameSource>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameSource_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_InfraredFrameSource_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_InfraredFrameSource_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrameSource_OpenReader(RootSystem.IntPtr pNative);
        public Windows.Kinect.InfraredFrameReader OpenReader()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("InfraredFrameSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrameSource_OpenReader(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.InfraredFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrameReader>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.LongExposureInfraredFrameSource
    //
    public sealed partial class LongExposureInfraredFrameSource
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal LongExposureInfraredFrameSource(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_LongExposureInfraredFrameSource_AddRefObject(ref _pNative);
        }

        ~LongExposureInfraredFrameSource()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameSource_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameSource_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<LongExposureInfraredFrameSource>(_pNative);
                Windows_Kinect_LongExposureInfraredFrameSource_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrameSource_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrameSource_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_LongExposureInfraredFrameSource_get_IsActive(RootSystem.IntPtr pNative);
        public  bool IsActive
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameSource");
                }

                return Windows_Kinect_LongExposureInfraredFrameSource_get_IsActive(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrameSource_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrameSource_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_FrameCapturedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>> Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_FrameCapturedEventArgs_Delegate))]
        private static void Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<LongExposureInfraredFrameSource>(pNative);
                    var args = new Windows.Kinect.FrameCapturedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameSource_add_FrameCaptured(RootSystem.IntPtr pNative, _Windows_Kinect_FrameCapturedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs> FrameCaptured
        {
            add
            {
            if(!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>());
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_FrameCapturedEventArgs_Delegate(Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_LongExposureInfraredFrameSource_add_FrameCaptured(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_LongExposureInfraredFrameSource_add_FrameCaptured(_pNative, Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<LongExposureInfraredFrameSource>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameSource_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_LongExposureInfraredFrameSource_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_LongExposureInfraredFrameSource_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrameSource_OpenReader(RootSystem.IntPtr pNative);
        public Windows.Kinect.LongExposureInfraredFrameReader OpenReader()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrameSource_OpenReader(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.LongExposureInfraredFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrameReader>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.AudioSource
    //
    public sealed partial class AudioSource
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioSource(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioSource_AddRefObject(ref _pNative);
        }

        ~AudioSource()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioSource_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioSource_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioSource>(_pNative);
                Windows_Kinect_AudioSource_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioSource_get_AudioBeams(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] RootSystem.IntPtr[] outCollection, int collectionSize);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioSource_get_AudioBeams_Length(RootSystem.IntPtr pNative);
        public  RootSystem.Collections.Generic.IList<Windows.Kinect.AudioBeam> AudioBeams
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioSource");
                }

                int collectionSize = Windows_Kinect_AudioSource_get_AudioBeams_Length(_pNative);
                var outCollection = new RootSystem.IntPtr[collectionSize];
                var managedCollection = new Windows.Kinect.AudioBeam[collectionSize];

                collectionSize = Windows_Kinect_AudioSource_get_AudioBeams(_pNative, outCollection, collectionSize);
                for(int i=0;i<collectionSize;i++)
                {
                    if(outCollection[i] == RootSystem.IntPtr.Zero)
                    {
                        continue;
                    }

                    outCollection[i] = Helper.NativeObjectCache.MapToIUnknown(outCollection[i]);
                    var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioBeam>(outCollection[i]);
                    if (obj == null)
                    {
                        obj = new Windows.Kinect.AudioBeam(outCollection[i]);
                        Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioBeam>(outCollection[i], obj);
                    }

                    managedCollection[i] = obj;
                }
                return managedCollection;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_AudioSource_get_IsActive(RootSystem.IntPtr pNative);
        public  bool IsActive
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioSource");
                }

                return Windows_Kinect_AudioSource_get_IsActive(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_AudioSource_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioSource");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_AudioSource_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern uint Windows_Kinect_AudioSource_get_MaxSubFrameCount(RootSystem.IntPtr pNative);
        public  uint MaxSubFrameCount
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioSource");
                }

                return Windows_Kinect_AudioSource_get_MaxSubFrameCount(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_AudioSource_get_SubFrameDuration(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan SubFrameDuration
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioSource");
                }

                return Windows_Kinect_AudioSource_get_SubFrameDuration(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern uint Windows_Kinect_AudioSource_get_SubFrameLengthInBytes(RootSystem.IntPtr pNative);
        public  uint SubFrameLengthInBytes
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioSource");
                }

                return Windows_Kinect_AudioSource_get_SubFrameLengthInBytes(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.KinectAudioCalibrationState Windows_Kinect_AudioSource_get_AudioCalibrationState(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectAudioCalibrationState AudioCalibrationState
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioSource");
                }

                return Windows_Kinect_AudioSource_get_AudioCalibrationState(_pNative);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_FrameCapturedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>> Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_FrameCapturedEventArgs_Delegate))]
        private static void Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<AudioSource>(pNative);
                    var args = new Windows.Kinect.FrameCapturedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioSource_add_FrameCaptured(RootSystem.IntPtr pNative, _Windows_Kinect_FrameCapturedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs> FrameCaptured
        {
            add
            {
            if(!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>());
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_FrameCapturedEventArgs_Delegate(Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_AudioSource_add_FrameCaptured(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.FrameCapturedEventArgs>>();
            }
            var callbackList = Windows_Kinect_FrameCapturedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_AudioSource_add_FrameCaptured(_pNative, Windows_Kinect_FrameCapturedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_FrameCapturedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<AudioSource>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioSource_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_AudioSource_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_AudioSource_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_AudioSource_OpenReader(RootSystem.IntPtr pNative);
        public Windows.Kinect.AudioBeamFrameReader OpenReader()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("AudioSource");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_AudioSource_OpenReader(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioBeamFrameReader>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.AudioBeamFrameReader(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioBeamFrameReader>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.MultiSourceFrameReader
    //
    public sealed partial class MultiSourceFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal MultiSourceFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_MultiSourceFrameReader_AddRefObject(ref _pNative);
        }

        ~MultiSourceFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<MultiSourceFrameReader>(_pNative);
                Windows_Kinect_MultiSourceFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_MultiSourceFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.FrameSourceTypes Windows_Kinect_MultiSourceFrameReader_get_FrameSourceTypes(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameSourceTypes FrameSourceTypes
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrameReader");
                }

                return Windows_Kinect_MultiSourceFrameReader_get_FrameSourceTypes(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_MultiSourceFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrameReader");
                }

                return Windows_Kinect_MultiSourceFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrameReader");
                }

                Windows_Kinect_MultiSourceFrameReader_put_IsPaused(_pNative, value);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrameReader_get_KinectSensor(RootSystem.IntPtr pNative);
        public  Windows.Kinect.KinectSensor KinectSensor
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrameReader_get_KinectSensor(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.KinectSensor>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.KinectSensor(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.KinectSensor>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.MultiSourceFrameArrivedEventArgs>>> Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.MultiSourceFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.MultiSourceFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<MultiSourceFrameReader>(pNative);
                    var args = new Windows.Kinect.MultiSourceFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReader_add_MultiSourceFrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.MultiSourceFrameArrivedEventArgs> MultiSourceFrameArrived
        {
            add
            {
            if(!Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.MultiSourceFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate(Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_MultiSourceFrameReader_add_MultiSourceFrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.MultiSourceFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_MultiSourceFrameReader_add_MultiSourceFrameArrived(_pNative, Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_MultiSourceFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<MultiSourceFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_MultiSourceFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_MultiSourceFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrameReader_AcquireLatestFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.MultiSourceFrame AcquireLatestFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("MultiSourceFrameReader");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrameReader_AcquireLatestFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.MultiSourceFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.MultiSourceFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.MultiSourceFrame>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.CoordinateMapper
    //
    public sealed partial class CoordinateMapper
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal CoordinateMapper(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_CoordinateMapper_AddRefObject(ref _pNative);
        }

        ~CoordinateMapper()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<CoordinateMapper>(_pNative);
                Windows_Kinect_CoordinateMapper_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.CoordinateMappingChangedEventArgs>>> Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.CoordinateMappingChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate))]
        private static void Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.CoordinateMappingChangedEventArgs>>();
            }
            var callbackList = Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<CoordinateMapper>(pNative);
                    var args = new Windows.Kinect.CoordinateMappingChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_add_CoordinateMappingChanged(RootSystem.IntPtr pNative, _Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.CoordinateMappingChangedEventArgs> CoordinateMappingChanged
        {
            add
            {
            if(!Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.CoordinateMappingChangedEventArgs>>());
            }
            var callbackList = Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate(Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_Handler);
                        _Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_CoordinateMapper_add_CoordinateMappingChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.CoordinateMappingChangedEventArgs>>();
            }
            var callbackList = Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_CoordinateMapper_add_CoordinateMappingChanged(_pNative, Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_CoordinateMappingChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.DepthSpacePoint Windows_Kinect_CoordinateMapper_MapCameraPointToDepthSpace(RootSystem.IntPtr pNative, Windows.Kinect.CameraSpacePoint cameraPoint);
        public Windows.Kinect.DepthSpacePoint MapCameraPointToDepthSpace(Windows.Kinect.CameraSpacePoint cameraPoint)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            return Windows_Kinect_CoordinateMapper_MapCameraPointToDepthSpace(_pNative, cameraPoint);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.ColorSpacePoint Windows_Kinect_CoordinateMapper_MapCameraPointToColorSpace(RootSystem.IntPtr pNative, Windows.Kinect.CameraSpacePoint cameraPoint);
        public Windows.Kinect.ColorSpacePoint MapCameraPointToColorSpace(Windows.Kinect.CameraSpacePoint cameraPoint)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            return Windows_Kinect_CoordinateMapper_MapCameraPointToColorSpace(_pNative, cameraPoint);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.CameraSpacePoint Windows_Kinect_CoordinateMapper_MapDepthPointToCameraSpace(RootSystem.IntPtr pNative, Windows.Kinect.DepthSpacePoint depthPoint, ushort depth);
        public Windows.Kinect.CameraSpacePoint MapDepthPointToCameraSpace(Windows.Kinect.DepthSpacePoint depthPoint, ushort depth)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            return Windows_Kinect_CoordinateMapper_MapDepthPointToCameraSpace(_pNative, depthPoint, depth);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.ColorSpacePoint Windows_Kinect_CoordinateMapper_MapDepthPointToColorSpace(RootSystem.IntPtr pNative, Windows.Kinect.DepthSpacePoint depthPoint, ushort depth);
        public Windows.Kinect.ColorSpacePoint MapDepthPointToColorSpace(Windows.Kinect.DepthSpacePoint depthPoint, ushort depth)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            return Windows_Kinect_CoordinateMapper_MapDepthPointToColorSpace(_pNative, depthPoint, depth);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapCameraPointsToDepthSpace(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.CameraSpacePoint[] cameraPoints, int cameraPointsSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.DepthSpacePoint[] depthPoints, int depthPointsSize);
        public void MapCameraPointsToDepthSpace(Windows.Kinect.CameraSpacePoint[] cameraPoints, Windows.Kinect.DepthSpacePoint[] depthPoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapCameraPointsToDepthSpace(_pNative, cameraPoints, cameraPoints.Length, depthPoints, depthPoints.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapCameraPointsToColorSpace(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.CameraSpacePoint[] cameraPoints, int cameraPointsSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.ColorSpacePoint[] colorPoints, int colorPointsSize);
        public void MapCameraPointsToColorSpace(Windows.Kinect.CameraSpacePoint[] cameraPoints, Windows.Kinect.ColorSpacePoint[] colorPoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapCameraPointsToColorSpace(_pNative, cameraPoints, cameraPoints.Length, colorPoints, colorPoints.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapDepthPointsToCameraSpace(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.DepthSpacePoint[] depthPoints, int depthPointsSize, ushort[] depths, int depthsSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.CameraSpacePoint[] cameraPoints, int cameraPointsSize);
        public void MapDepthPointsToCameraSpace(Windows.Kinect.DepthSpacePoint[] depthPoints, ushort[] depths, Windows.Kinect.CameraSpacePoint[] cameraPoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapDepthPointsToCameraSpace(_pNative, depthPoints, depthPoints.Length, depths, depths.Length, cameraPoints, cameraPoints.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapDepthPointsToColorSpace(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.DepthSpacePoint[] depthPoints, int depthPointsSize, ushort[] depths, int depthsSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.ColorSpacePoint[] colorPoints, int colorPointsSize);
        public void MapDepthPointsToColorSpace(Windows.Kinect.DepthSpacePoint[] depthPoints, ushort[] depths, Windows.Kinect.ColorSpacePoint[] colorPoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapDepthPointsToColorSpace(_pNative, depthPoints, depthPoints.Length, depths, depths.Length, colorPoints, colorPoints.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapDepthFrameToCameraSpace(RootSystem.IntPtr pNative, ushort[] depthFrameData, int depthFrameDataSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.CameraSpacePoint[] cameraSpacePoints, int cameraSpacePointsSize);
        public void MapDepthFrameToCameraSpace(ushort[] depthFrameData, Windows.Kinect.CameraSpacePoint[] cameraSpacePoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapDepthFrameToCameraSpace(_pNative, depthFrameData, depthFrameData.Length, cameraSpacePoints, cameraSpacePoints.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapDepthFrameToColorSpace(RootSystem.IntPtr pNative, ushort[] depthFrameData, int depthFrameDataSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.ColorSpacePoint[] colorSpacePoints, int colorSpacePointsSize);
        public void MapDepthFrameToColorSpace(ushort[] depthFrameData, Windows.Kinect.ColorSpacePoint[] colorSpacePoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapDepthFrameToColorSpace(_pNative, depthFrameData, depthFrameData.Length, colorSpacePoints, colorSpacePoints.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapColorFrameToDepthSpace(RootSystem.IntPtr pNative, ushort[] depthFrameData, int depthFrameDataSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.DepthSpacePoint[] depthSpacePoints, int depthSpacePointsSize);
        public void MapColorFrameToDepthSpace(ushort[] depthFrameData, Windows.Kinect.DepthSpacePoint[] depthSpacePoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapColorFrameToDepthSpace(_pNative, depthFrameData, depthFrameData.Length, depthSpacePoints, depthSpacePoints.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMapper_MapColorFrameToCameraSpace(RootSystem.IntPtr pNative, ushort[] depthFrameData, int depthFrameDataSize, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.CameraSpacePoint[] cameraSpacePoints, int cameraSpacePointsSize);
        public void MapColorFrameToCameraSpace(ushort[] depthFrameData, Windows.Kinect.CameraSpacePoint[] cameraSpacePoints)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("CoordinateMapper");
            }

            Windows_Kinect_CoordinateMapper_MapColorFrameToCameraSpace(_pNative, depthFrameData, depthFrameData.Length, cameraSpacePoints, cameraSpacePoints.Length);
        }

    }

    //
    // Windows.Kinect.MultiSourceFrameArrivedEventArgs
    //
    public sealed partial class MultiSourceFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal MultiSourceFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_MultiSourceFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~MultiSourceFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<MultiSourceFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_MultiSourceFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.MultiSourceFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.MultiSourceFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.MultiSourceFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.MultiSourceFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.MultiSourceFrame
    //
    public sealed partial class MultiSourceFrame
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal MultiSourceFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_MultiSourceFrame_AddRefObject(ref _pNative);
        }

        ~MultiSourceFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<MultiSourceFrame>(_pNative);
                Windows_Kinect_MultiSourceFrame_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrame_get_BodyFrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyFrameReference BodyFrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrame_get_BodyFrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrame_get_BodyIndexFrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyIndexFrameReference BodyIndexFrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrame_get_BodyIndexFrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyIndexFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrame_get_ColorFrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.ColorFrameReference ColorFrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrame_get_ColorFrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.ColorFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrame_get_DepthFrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.DepthFrameReference DepthFrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrame_get_DepthFrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.DepthFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrame_get_InfraredFrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.InfraredFrameReference InfraredFrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrame_get_InfraredFrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.InfraredFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrame_get_LongExposureInfraredFrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.LongExposureInfraredFrameReference LongExposureInfraredFrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("MultiSourceFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrame_get_LongExposureInfraredFrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.LongExposureInfraredFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Public Methods
    }

    //
    // Windows.Kinect.MultiSourceFrameReference
    //
    public sealed partial class MultiSourceFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal MultiSourceFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_MultiSourceFrameReference_AddRefObject(ref _pNative);
        }

        ~MultiSourceFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_MultiSourceFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<MultiSourceFrameReference>(_pNative);
                Windows_Kinect_MultiSourceFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_MultiSourceFrameReference_AcquireFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.MultiSourceFrame AcquireFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("MultiSourceFrameReference");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_MultiSourceFrameReference_AcquireFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.MultiSourceFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.MultiSourceFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.MultiSourceFrame>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.ColorFrameReference
    //
    public sealed partial class ColorFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal ColorFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_ColorFrameReference_AddRefObject(ref _pNative);
        }

        ~ColorFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<ColorFrameReference>(_pNative);
                Windows_Kinect_ColorFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_ColorFrameReference_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameReference");
                }

                return Windows_Kinect_ColorFrameReference_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameReference_AcquireFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.ColorFrame AcquireFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("ColorFrameReference");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameReference_AcquireFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.ColorFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrame>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.DepthFrameReference
    //
    public sealed partial class DepthFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal DepthFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_DepthFrameReference_AddRefObject(ref _pNative);
        }

        ~DepthFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<DepthFrameReference>(_pNative);
                Windows_Kinect_DepthFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_DepthFrameReference_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameReference");
                }

                return Windows_Kinect_DepthFrameReference_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrameReference_AcquireFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.DepthFrame AcquireFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("DepthFrameReference");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrameReference_AcquireFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.DepthFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrame>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.BodyFrameReference
    //
    public sealed partial class BodyFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyFrameReference_AddRefObject(ref _pNative);
        }

        ~BodyFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyFrameReference>(_pNative);
                Windows_Kinect_BodyFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_BodyFrameReference_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameReference");
                }

                return Windows_Kinect_BodyFrameReference_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyFrameReference_AcquireFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.BodyFrame AcquireFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyFrameReference");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_BodyFrameReference_AcquireFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.BodyFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrame>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.BodyIndexFrameReference
    //
    public sealed partial class BodyIndexFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyIndexFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyIndexFrameReference_AddRefObject(ref _pNative);
        }

        ~BodyIndexFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyIndexFrameReference>(_pNative);
                Windows_Kinect_BodyIndexFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_BodyIndexFrameReference_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameReference");
                }

                return Windows_Kinect_BodyIndexFrameReference_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrameReference_AcquireFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.BodyIndexFrame AcquireFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyIndexFrameReference");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrameReference_AcquireFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.BodyIndexFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrame>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.InfraredFrameReference
    //
    public sealed partial class InfraredFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal InfraredFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_InfraredFrameReference_AddRefObject(ref _pNative);
        }

        ~InfraredFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<InfraredFrameReference>(_pNative);
                Windows_Kinect_InfraredFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_InfraredFrameReference_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameReference");
                }

                return Windows_Kinect_InfraredFrameReference_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrameReference_AcquireFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.InfraredFrame AcquireFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("InfraredFrameReference");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrameReference_AcquireFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.InfraredFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrame>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.LongExposureInfraredFrameReference
    //
    public sealed partial class LongExposureInfraredFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal LongExposureInfraredFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_LongExposureInfraredFrameReference_AddRefObject(ref _pNative);
        }

        ~LongExposureInfraredFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<LongExposureInfraredFrameReference>(_pNative);
                Windows_Kinect_LongExposureInfraredFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_LongExposureInfraredFrameReference_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameReference");
                }

                return Windows_Kinect_LongExposureInfraredFrameReference_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrameReference_AcquireFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.LongExposureInfraredFrame AcquireFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameReference");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrameReference_AcquireFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.LongExposureInfraredFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrame>(objectPointer, obj);
            }

            return obj;
        }

    }

    //
    // Windows.Kinect.ColorFrame
    //
    public sealed partial class ColorFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal ColorFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_ColorFrame_AddRefObject(ref _pNative);
        }

        ~ColorFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<ColorFrame>(_pNative);
                Windows_Kinect_ColorFrame_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_ColorFrame_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrame_get_ColorCameraSettings(RootSystem.IntPtr pNative);
        public  Windows.Kinect.ColorCameraSettings ColorCameraSettings
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrame_get_ColorCameraSettings(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorCameraSettings>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.ColorCameraSettings(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorCameraSettings>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrame_get_ColorFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.ColorFrameSource ColorFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrame_get_ColorFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.ColorFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrame_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrame_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.ColorImageFormat Windows_Kinect_ColorFrame_get_RawColorImageFormat(RootSystem.IntPtr pNative);
        public  Windows.Kinect.ColorImageFormat RawColorImageFormat
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrame");
                }

                return Windows_Kinect_ColorFrame_get_RawColorImageFormat(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_ColorFrame_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrame");
                }

                return Windows_Kinect_ColorFrame_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrame_CopyRawFrameDataToArray(RootSystem.IntPtr pNative, byte[] frameData, int frameDataSize);
        public void CopyRawFrameDataToArray(byte[] frameData)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("ColorFrame");
            }

            Windows_Kinect_ColorFrame_CopyRawFrameDataToArray(_pNative, frameData, frameData.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrame_CopyConvertedFrameDataToArray(RootSystem.IntPtr pNative, byte[] frameData, int frameDataSize, Windows.Kinect.ColorImageFormat colorFormat);
        public void CopyConvertedFrameDataToArray(byte[] frameData, Windows.Kinect.ColorImageFormat colorFormat)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("ColorFrame");
            }

            Windows_Kinect_ColorFrame_CopyConvertedFrameDataToArray(_pNative, frameData, frameData.Length, colorFormat);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrame_CreateFrameDescription(RootSystem.IntPtr pNative, Windows.Kinect.ColorImageFormat format);
        public Windows.Kinect.FrameDescription CreateFrameDescription(Windows.Kinect.ColorImageFormat format)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("ColorFrame");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrame_CreateFrameDescription(_pNative, format);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.FrameDescription(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrame_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.FrameCapturedEventArgs
    //
    public sealed partial class FrameCapturedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal FrameCapturedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_FrameCapturedEventArgs_AddRefObject(ref _pNative);
        }

        ~FrameCapturedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_FrameCapturedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_FrameCapturedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<FrameCapturedEventArgs>(_pNative);
                Windows_Kinect_FrameCapturedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.FrameCapturedStatus Windows_Kinect_FrameCapturedEventArgs_get_FrameStatus(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameCapturedStatus FrameStatus
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameCapturedEventArgs");
                }

                return Windows_Kinect_FrameCapturedEventArgs_get_FrameStatus(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.FrameSourceTypes Windows_Kinect_FrameCapturedEventArgs_get_FrameType(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameSourceTypes FrameType
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameCapturedEventArgs");
                }

                return Windows_Kinect_FrameCapturedEventArgs_get_FrameType(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_FrameCapturedEventArgs_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameCapturedEventArgs");
                }

                return Windows_Kinect_FrameCapturedEventArgs_get_RelativeTime(_pNative);
            }
        }

    }

    //
    // Windows.Kinect.ColorFrameReader
    //
    public sealed partial class ColorFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal ColorFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_ColorFrameReader_AddRefObject(ref _pNative);
        }

        ~ColorFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<ColorFrameReader>(_pNative);
                Windows_Kinect_ColorFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_ColorFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameReader_get_ColorFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.ColorFrameSource ColorFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameReader_get_ColorFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.ColorFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_ColorFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameReader");
                }

                return Windows_Kinect_ColorFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameReader");
                }

                Windows_Kinect_ColorFrameReader_put_IsPaused(_pNative, value);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_ColorFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.ColorFrameArrivedEventArgs>>> Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.ColorFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_ColorFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.ColorFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<ColorFrameReader>(pNative);
                    var args = new Windows.Kinect.ColorFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReader_add_FrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_ColorFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.ColorFrameArrivedEventArgs> FrameArrived
        {
            add
            {
            if(!Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.ColorFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_ColorFrameArrivedEventArgs_Delegate(Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_ColorFrameReader_add_FrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.ColorFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_ColorFrameReader_add_FrameArrived(_pNative, Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_ColorFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<ColorFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_ColorFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_ColorFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameReader_AcquireLatestFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.ColorFrame AcquireLatestFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("ColorFrameReader");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameReader_AcquireLatestFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.ColorFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrame>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.FrameDescription
    //
    public sealed partial class FrameDescription
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal FrameDescription(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_FrameDescription_AddRefObject(ref _pNative);
        }

        ~FrameDescription()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_FrameDescription_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_FrameDescription_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<FrameDescription>(_pNative);
                Windows_Kinect_FrameDescription_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern uint Windows_Kinect_FrameDescription_get_BytesPerPixel(RootSystem.IntPtr pNative);
        public  uint BytesPerPixel
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameDescription");
                }

                return Windows_Kinect_FrameDescription_get_BytesPerPixel(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_FrameDescription_get_DiagonalFieldOfView(RootSystem.IntPtr pNative);
        public  float DiagonalFieldOfView
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameDescription");
                }

                return Windows_Kinect_FrameDescription_get_DiagonalFieldOfView(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_FrameDescription_get_Height(RootSystem.IntPtr pNative);
        public  int Height
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameDescription");
                }

                return Windows_Kinect_FrameDescription_get_Height(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_FrameDescription_get_HorizontalFieldOfView(RootSystem.IntPtr pNative);
        public  float HorizontalFieldOfView
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameDescription");
                }

                return Windows_Kinect_FrameDescription_get_HorizontalFieldOfView(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern uint Windows_Kinect_FrameDescription_get_LengthInPixels(RootSystem.IntPtr pNative);
        public  uint LengthInPixels
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameDescription");
                }

                return Windows_Kinect_FrameDescription_get_LengthInPixels(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_FrameDescription_get_VerticalFieldOfView(RootSystem.IntPtr pNative);
        public  float VerticalFieldOfView
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameDescription");
                }

                return Windows_Kinect_FrameDescription_get_VerticalFieldOfView(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_FrameDescription_get_Width(RootSystem.IntPtr pNative);
        public  int Width
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("FrameDescription");
                }

                return Windows_Kinect_FrameDescription_get_Width(_pNative);
            }
        }

    }

    //
    // Windows.Kinect.ColorFrameArrivedEventArgs
    //
    public sealed partial class ColorFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal ColorFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_ColorFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~ColorFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<ColorFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_ColorFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_ColorFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.ColorFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_ColorFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.ColorFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.ColorFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.ColorFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.ColorCameraSettings
    //
    public sealed partial class ColorCameraSettings
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal ColorCameraSettings(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_ColorCameraSettings_AddRefObject(ref _pNative);
        }

        ~ColorCameraSettings()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorCameraSettings_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_ColorCameraSettings_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<ColorCameraSettings>(_pNative);
                Windows_Kinect_ColorCameraSettings_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_ColorCameraSettings_get_ExposureTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan ExposureTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorCameraSettings");
                }

                return Windows_Kinect_ColorCameraSettings_get_ExposureTime(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_ColorCameraSettings_get_FrameInterval(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan FrameInterval
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorCameraSettings");
                }

                return Windows_Kinect_ColorCameraSettings_get_FrameInterval(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_ColorCameraSettings_get_Gain(RootSystem.IntPtr pNative);
        public  float Gain
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorCameraSettings");
                }

                return Windows_Kinect_ColorCameraSettings_get_Gain(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_ColorCameraSettings_get_Gamma(RootSystem.IntPtr pNative);
        public  float Gamma
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("ColorCameraSettings");
                }

                return Windows_Kinect_ColorCameraSettings_get_Gamma(_pNative);
            }
        }

    }

    //
    // Windows.Kinect.DepthFrame
    //
    public sealed partial class DepthFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal DepthFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_DepthFrame_AddRefObject(ref _pNative);
        }

        ~DepthFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<DepthFrame>(_pNative);
                Windows_Kinect_DepthFrame_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_DepthFrame_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrame_get_DepthFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.DepthFrameSource DepthFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrame_get_DepthFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.DepthFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern ushort Windows_Kinect_DepthFrame_get_DepthMaxReliableDistance(RootSystem.IntPtr pNative);
        public  ushort DepthMaxReliableDistance
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrame");
                }

                return Windows_Kinect_DepthFrame_get_DepthMaxReliableDistance(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern ushort Windows_Kinect_DepthFrame_get_DepthMinReliableDistance(RootSystem.IntPtr pNative);
        public  ushort DepthMinReliableDistance
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrame");
                }

                return Windows_Kinect_DepthFrame_get_DepthMinReliableDistance(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrame_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrame_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_DepthFrame_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrame");
                }

                return Windows_Kinect_DepthFrame_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrame_CopyFrameDataToArray(RootSystem.IntPtr pNative, ushort[] frameData, int frameDataSize);
        public void CopyFrameDataToArray(ushort[] frameData)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("DepthFrame");
            }

            Windows_Kinect_DepthFrame_CopyFrameDataToArray(_pNative, frameData, frameData.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrame_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.DepthFrameReader
    //
    public sealed partial class DepthFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal DepthFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_DepthFrameReader_AddRefObject(ref _pNative);
        }

        ~DepthFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<DepthFrameReader>(_pNative);
                Windows_Kinect_DepthFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_DepthFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrameReader_get_DepthFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.DepthFrameSource DepthFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrameReader_get_DepthFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.DepthFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_DepthFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameReader");
                }

                return Windows_Kinect_DepthFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameReader");
                }

                Windows_Kinect_DepthFrameReader_put_IsPaused(_pNative, value);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_DepthFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.DepthFrameArrivedEventArgs>>> Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.DepthFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_DepthFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.DepthFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<DepthFrameReader>(pNative);
                    var args = new Windows.Kinect.DepthFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReader_add_FrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_DepthFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.DepthFrameArrivedEventArgs> FrameArrived
        {
            add
            {
            if(!Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.DepthFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_DepthFrameArrivedEventArgs_Delegate(Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_DepthFrameReader_add_FrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.DepthFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_DepthFrameReader_add_FrameArrived(_pNative, Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_DepthFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<DepthFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_DepthFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_DepthFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrameReader_AcquireLatestFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.DepthFrame AcquireLatestFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("DepthFrameReader");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrameReader_AcquireLatestFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.DepthFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrame>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.DepthFrameArrivedEventArgs
    //
    public sealed partial class DepthFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal DepthFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_DepthFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~DepthFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_DepthFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<DepthFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_DepthFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_DepthFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.DepthFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("DepthFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_DepthFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.DepthFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.DepthFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.DepthFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.BodyFrame
    //
    public sealed partial class BodyFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyFrame_AddRefObject(ref _pNative);
        }

        ~BodyFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyFrame>(_pNative);
                Windows_Kinect_BodyFrame_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_BodyFrame_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_BodyFrame_get_BodyCount(RootSystem.IntPtr pNative);
        public  int BodyCount
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrame");
                }

                return Windows_Kinect_BodyFrame_get_BodyCount(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyFrame_get_BodyFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyFrameSource BodyFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyFrame_get_BodyFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_BodyFrame_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrame");
                }

                return Windows_Kinect_BodyFrame_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrame_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.BodyFrameReader
    //
    public sealed partial class BodyFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyFrameReader_AddRefObject(ref _pNative);
        }

        ~BodyFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyFrameReader>(_pNative);
                Windows_Kinect_BodyFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_BodyFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyFrameReader_get_BodyFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyFrameSource BodyFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyFrameReader_get_BodyFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_BodyFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameReader");
                }

                return Windows_Kinect_BodyFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameReader");
                }

                Windows_Kinect_BodyFrameReader_put_IsPaused(_pNative, value);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_BodyFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.BodyFrameArrivedEventArgs>>> Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.BodyFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_BodyFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.BodyFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyFrameReader>(pNative);
                    var args = new Windows.Kinect.BodyFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReader_add_FrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_BodyFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.BodyFrameArrivedEventArgs> FrameArrived
        {
            add
            {
            if(!Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.BodyFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_BodyFrameArrivedEventArgs_Delegate(Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyFrameReader_add_FrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.BodyFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyFrameReader_add_FrameArrived(_pNative, Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_BodyFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyFrameReader_AcquireLatestFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.BodyFrame AcquireLatestFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyFrameReader");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_BodyFrameReader_AcquireLatestFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.BodyFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrame>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.BodyFrameArrivedEventArgs
    //
    public sealed partial class BodyFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~BodyFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_BodyFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.Body
    //
    public sealed partial class Body
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal Body(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_Body_AddRefObject(ref _pNative);
        }

        ~Body()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_Body_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_Body_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<Body>(_pNative);
                Windows_Kinect_Body_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Activities(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.Activity[] outKeys, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.DetectionResult[] outValues, int collectionSize);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Activities_Length(RootSystem.IntPtr pNative);
        public  RootSystem.Collections.Generic.Dictionary<Windows.Kinect.Activity, Windows.Kinect.DetectionResult> Activities
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                int collectionSize = Windows_Kinect_Body_get_Activities_Length(_pNative);
                var outKeys = new Windows.Kinect.Activity[collectionSize];
                var outValues = new Windows.Kinect.DetectionResult[collectionSize];
                var managedDictionary = new RootSystem.Collections.Generic.Dictionary<Windows.Kinect.Activity, Windows.Kinect.DetectionResult>();

                collectionSize = Windows_Kinect_Body_get_Activities(_pNative, outKeys, outValues, collectionSize);
                for(int i=0;i<collectionSize;i++)
                {
                    managedDictionary.Add(outKeys[i], outValues[i]);
                }
                return managedDictionary;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Appearance(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.Appearance[] outKeys, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.DetectionResult[] outValues, int collectionSize);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Appearance_Length(RootSystem.IntPtr pNative);
        public  RootSystem.Collections.Generic.Dictionary<Windows.Kinect.Appearance, Windows.Kinect.DetectionResult> Appearance
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                int collectionSize = Windows_Kinect_Body_get_Appearance_Length(_pNative);
                var outKeys = new Windows.Kinect.Appearance[collectionSize];
                var outValues = new Windows.Kinect.DetectionResult[collectionSize];
                var managedDictionary = new RootSystem.Collections.Generic.Dictionary<Windows.Kinect.Appearance, Windows.Kinect.DetectionResult>();

                collectionSize = Windows_Kinect_Body_get_Appearance(_pNative, outKeys, outValues, collectionSize);
                for(int i=0;i<collectionSize;i++)
                {
                    managedDictionary.Add(outKeys[i], outValues[i]);
                }
                return managedDictionary;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.FrameEdges Windows_Kinect_Body_get_ClippedEdges(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameEdges ClippedEdges
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_ClippedEdges(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.DetectionResult Windows_Kinect_Body_get_Engaged(RootSystem.IntPtr pNative);
        public  Windows.Kinect.DetectionResult Engaged
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_Engaged(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Expressions(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.Expression[] outKeys, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.DetectionResult[] outValues, int collectionSize);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Expressions_Length(RootSystem.IntPtr pNative);
        public  RootSystem.Collections.Generic.Dictionary<Windows.Kinect.Expression, Windows.Kinect.DetectionResult> Expressions
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                int collectionSize = Windows_Kinect_Body_get_Expressions_Length(_pNative);
                var outKeys = new Windows.Kinect.Expression[collectionSize];
                var outValues = new Windows.Kinect.DetectionResult[collectionSize];
                var managedDictionary = new RootSystem.Collections.Generic.Dictionary<Windows.Kinect.Expression, Windows.Kinect.DetectionResult>();

                collectionSize = Windows_Kinect_Body_get_Expressions(_pNative, outKeys, outValues, collectionSize);
                for(int i=0;i<collectionSize;i++)
                {
                    managedDictionary.Add(outKeys[i], outValues[i]);
                }
                return managedDictionary;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.TrackingConfidence Windows_Kinect_Body_get_HandLeftConfidence(RootSystem.IntPtr pNative);
        public  Windows.Kinect.TrackingConfidence HandLeftConfidence
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_HandLeftConfidence(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.HandState Windows_Kinect_Body_get_HandLeftState(RootSystem.IntPtr pNative);
        public  Windows.Kinect.HandState HandLeftState
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_HandLeftState(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.TrackingConfidence Windows_Kinect_Body_get_HandRightConfidence(RootSystem.IntPtr pNative);
        public  Windows.Kinect.TrackingConfidence HandRightConfidence
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_HandRightConfidence(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.HandState Windows_Kinect_Body_get_HandRightState(RootSystem.IntPtr pNative);
        public  Windows.Kinect.HandState HandRightState
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_HandRightState(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_Body_get_IsRestricted(RootSystem.IntPtr pNative);
        public  bool IsRestricted
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_IsRestricted(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_Body_get_IsTracked(RootSystem.IntPtr pNative);
        public  bool IsTracked
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_IsTracked(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_JointOrientations(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.JointType[] outKeys, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.JointOrientation[] outValues, int collectionSize);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_JointOrientations_Length(RootSystem.IntPtr pNative);
        public  RootSystem.Collections.Generic.Dictionary<Windows.Kinect.JointType, Windows.Kinect.JointOrientation> JointOrientations
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                int collectionSize = Windows_Kinect_Body_get_JointOrientations_Length(_pNative);
                var outKeys = new Windows.Kinect.JointType[collectionSize];
                var outValues = new Windows.Kinect.JointOrientation[collectionSize];
                var managedDictionary = new RootSystem.Collections.Generic.Dictionary<Windows.Kinect.JointType, Windows.Kinect.JointOrientation>();

                collectionSize = Windows_Kinect_Body_get_JointOrientations(_pNative, outKeys, outValues, collectionSize);
                for(int i=0;i<collectionSize;i++)
                {
                    managedDictionary.Add(outKeys[i], outValues[i]);
                }
                return managedDictionary;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Joints(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.JointType[] outKeys, [RootSystem.Runtime.InteropServices.Out] Windows.Kinect.Joint[] outValues, int collectionSize);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_Joints_Length(RootSystem.IntPtr pNative);
        public  RootSystem.Collections.Generic.Dictionary<Windows.Kinect.JointType, Windows.Kinect.Joint> Joints
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                int collectionSize = Windows_Kinect_Body_get_Joints_Length(_pNative);
                var outKeys = new Windows.Kinect.JointType[collectionSize];
                var outValues = new Windows.Kinect.Joint[collectionSize];
                var managedDictionary = new RootSystem.Collections.Generic.Dictionary<Windows.Kinect.JointType, Windows.Kinect.Joint>();

                collectionSize = Windows_Kinect_Body_get_Joints(_pNative, outKeys, outValues, collectionSize);
                for(int i=0;i<collectionSize;i++)
                {
                    managedDictionary.Add(outKeys[i], outValues[i]);
                }
                return managedDictionary;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.TrackingState Windows_Kinect_Body_get_LeanTrackingState(RootSystem.IntPtr pNative);
        public  Windows.Kinect.TrackingState LeanTrackingState
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_LeanTrackingState(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern ulong Windows_Kinect_Body_get_TrackingId(RootSystem.IntPtr pNative);
        public  ulong TrackingId
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("Body");
                }

                return Windows_Kinect_Body_get_TrackingId(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_Body_get_JointCount();
        public static int JointCount
        {
            get
            {
                return Windows_Kinect_Body_get_JointCount();
            }
        }


        // Public Methods
    }

    //
    // Windows.Kinect.BodyIndexFrame
    //
    public sealed partial class BodyIndexFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyIndexFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyIndexFrame_AddRefObject(ref _pNative);
        }

        ~BodyIndexFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyIndexFrame>(_pNative);
                Windows_Kinect_BodyIndexFrame_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_BodyIndexFrame_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrame_get_BodyIndexFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyIndexFrameSource BodyIndexFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrame_get_BodyIndexFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyIndexFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrame_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrame_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_BodyIndexFrame_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrame");
                }

                return Windows_Kinect_BodyIndexFrame_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrame_CopyFrameDataToArray(RootSystem.IntPtr pNative, byte[] frameData, int frameDataSize);
        public void CopyFrameDataToArray(byte[] frameData)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyIndexFrame");
            }

            Windows_Kinect_BodyIndexFrame_CopyFrameDataToArray(_pNative, frameData, frameData.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrame_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.BodyIndexFrameReader
    //
    public sealed partial class BodyIndexFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyIndexFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyIndexFrameReader_AddRefObject(ref _pNative);
        }

        ~BodyIndexFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyIndexFrameReader>(_pNative);
                Windows_Kinect_BodyIndexFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_BodyIndexFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrameReader_get_BodyIndexFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyIndexFrameSource BodyIndexFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrameReader_get_BodyIndexFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyIndexFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_BodyIndexFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameReader");
                }

                return Windows_Kinect_BodyIndexFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameReader");
                }

                Windows_Kinect_BodyIndexFrameReader_put_IsPaused(_pNative, value);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.BodyIndexFrameArrivedEventArgs>>> Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.BodyIndexFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.BodyIndexFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyIndexFrameReader>(pNative);
                    var args = new Windows.Kinect.BodyIndexFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReader_add_FrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.BodyIndexFrameArrivedEventArgs> FrameArrived
        {
            add
            {
            if(!Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.BodyIndexFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate(Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyIndexFrameReader_add_FrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.BodyIndexFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyIndexFrameReader_add_FrameArrived(_pNative, Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_BodyIndexFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<BodyIndexFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_BodyIndexFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_BodyIndexFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrameReader_AcquireLatestFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.BodyIndexFrame AcquireLatestFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("BodyIndexFrameReader");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrameReader_AcquireLatestFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.BodyIndexFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrame>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.BodyIndexFrameArrivedEventArgs
    //
    public sealed partial class BodyIndexFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal BodyIndexFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_BodyIndexFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~BodyIndexFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_BodyIndexFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<BodyIndexFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_BodyIndexFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_BodyIndexFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.BodyIndexFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("BodyIndexFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_BodyIndexFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.BodyIndexFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.BodyIndexFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.BodyIndexFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.InfraredFrame
    //
    public sealed partial class InfraredFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal InfraredFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_InfraredFrame_AddRefObject(ref _pNative);
        }

        ~InfraredFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<InfraredFrame>(_pNative);
                Windows_Kinect_InfraredFrame_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_InfraredFrame_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrame_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrame_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrame_get_InfraredFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.InfraredFrameSource InfraredFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrame_get_InfraredFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.InfraredFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_InfraredFrame_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrame");
                }

                return Windows_Kinect_InfraredFrame_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrame_CopyFrameDataToArray(RootSystem.IntPtr pNative, ushort[] frameData, int frameDataSize);
        public void CopyFrameDataToArray(ushort[] frameData)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("InfraredFrame");
            }

            Windows_Kinect_InfraredFrame_CopyFrameDataToArray(_pNative, frameData, frameData.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrame_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.InfraredFrameReader
    //
    public sealed partial class InfraredFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal InfraredFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_InfraredFrameReader_AddRefObject(ref _pNative);
        }

        ~InfraredFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<InfraredFrameReader>(_pNative);
                Windows_Kinect_InfraredFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_InfraredFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrameReader_get_InfraredFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.InfraredFrameSource InfraredFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrameReader_get_InfraredFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.InfraredFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_InfraredFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameReader");
                }

                return Windows_Kinect_InfraredFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameReader");
                }

                Windows_Kinect_InfraredFrameReader_put_IsPaused(_pNative, value);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.InfraredFrameArrivedEventArgs>>> Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.InfraredFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.InfraredFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<InfraredFrameReader>(pNative);
                    var args = new Windows.Kinect.InfraredFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReader_add_FrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.InfraredFrameArrivedEventArgs> FrameArrived
        {
            add
            {
            if(!Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.InfraredFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate(Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_InfraredFrameReader_add_FrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.InfraredFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_InfraredFrameReader_add_FrameArrived(_pNative, Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_InfraredFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<InfraredFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_InfraredFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_InfraredFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrameReader_AcquireLatestFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.InfraredFrame AcquireLatestFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("InfraredFrameReader");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrameReader_AcquireLatestFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.InfraredFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrame>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.InfraredFrameArrivedEventArgs
    //
    public sealed partial class InfraredFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal InfraredFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_InfraredFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~InfraredFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_InfraredFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<InfraredFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_InfraredFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_InfraredFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.InfraredFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("InfraredFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_InfraredFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.InfraredFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.InfraredFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.InfraredFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.LongExposureInfraredFrame
    //
    public sealed partial class LongExposureInfraredFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal LongExposureInfraredFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_LongExposureInfraredFrame_AddRefObject(ref _pNative);
        }

        ~LongExposureInfraredFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<LongExposureInfraredFrame>(_pNative);
                Windows_Kinect_LongExposureInfraredFrame_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_LongExposureInfraredFrame_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrame_get_FrameDescription(RootSystem.IntPtr pNative);
        public  Windows.Kinect.FrameDescription FrameDescription
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrame_get_FrameDescription(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.FrameDescription>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.FrameDescription(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.FrameDescription>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrame_get_LongExposureInfraredFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.LongExposureInfraredFrameSource LongExposureInfraredFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrame_get_LongExposureInfraredFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.LongExposureInfraredFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_LongExposureInfraredFrame_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrame");
                }

                return Windows_Kinect_LongExposureInfraredFrame_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrame_CopyFrameDataToArray(RootSystem.IntPtr pNative, ushort[] frameData, int frameDataSize);
        public void CopyFrameDataToArray(ushort[] frameData)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrame");
            }

            Windows_Kinect_LongExposureInfraredFrame_CopyFrameDataToArray(_pNative, frameData, frameData.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrame_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.LongExposureInfraredFrameReader
    //
    public sealed partial class LongExposureInfraredFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal LongExposureInfraredFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_LongExposureInfraredFrameReader_AddRefObject(ref _pNative);
        }

        ~LongExposureInfraredFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<LongExposureInfraredFrameReader>(_pNative);
                Windows_Kinect_LongExposureInfraredFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_LongExposureInfraredFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_LongExposureInfraredFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameReader");
                }

                return Windows_Kinect_LongExposureInfraredFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameReader");
                }

                Windows_Kinect_LongExposureInfraredFrameReader_put_IsPaused(_pNative, value);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrameReader_get_LongExposureInfraredFrameSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.LongExposureInfraredFrameSource LongExposureInfraredFrameSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrameReader_get_LongExposureInfraredFrameSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrameSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.LongExposureInfraredFrameSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrameSource>(objectPointer, obj);
                }

                return obj;
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs>>> Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<LongExposureInfraredFrameReader>(pNative);
                    var args = new Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReader_add_FrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs> FrameArrived
        {
            add
            {
            if(!Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate(Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_LongExposureInfraredFrameReader_add_FrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_LongExposureInfraredFrameReader_add_FrameArrived(_pNative, Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<LongExposureInfraredFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_LongExposureInfraredFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_LongExposureInfraredFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrameReader_AcquireLatestFrame(RootSystem.IntPtr pNative);
        public Windows.Kinect.LongExposureInfraredFrame AcquireLatestFrame()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameReader");
            }

            RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrameReader_AcquireLatestFrame(_pNative);
            if (objectPointer == RootSystem.IntPtr.Zero)
            {
                return null;
            }

            objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
            var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrame>(objectPointer);
            if (obj == null)
            {
                obj = new Windows.Kinect.LongExposureInfraredFrame(objectPointer);
                Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrame>(objectPointer, obj);
            }

            return obj;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.LongExposureInfraredFrameArrivedEventArgs
    //
    public sealed partial class LongExposureInfraredFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal LongExposureInfraredFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~LongExposureInfraredFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<LongExposureInfraredFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.LongExposureInfraredFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("LongExposureInfraredFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_LongExposureInfraredFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.LongExposureInfraredFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.LongExposureInfraredFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.LongExposureInfraredFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.AudioBeam
    //
    public sealed partial class AudioBeam
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBeam(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBeam_AddRefObject(ref _pNative);
        }

        ~AudioBeam()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeam_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeam_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioBeam>(_pNative);
                Windows_Kinect_AudioBeam_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.AudioBeamMode Windows_Kinect_AudioBeam_get_AudioBeamMode(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeam_put_AudioBeamMode(RootSystem.IntPtr pNative, Windows.Kinect.AudioBeamMode audioBeamMode);
        public  Windows.Kinect.AudioBeamMode AudioBeamMode
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeam");
                }

                return Windows_Kinect_AudioBeam_get_AudioBeamMode(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeam");
                }

                Windows_Kinect_AudioBeam_put_AudioBeamMode(_pNative, value);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_AudioBeam_get_AudioSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.AudioSource AudioSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeam");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_AudioBeam_get_AudioSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_AudioBeam_get_BeamAngle(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeam_put_BeamAngle(RootSystem.IntPtr pNative, float beamAngle);
        public  float BeamAngle
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeam");
                }

                return Windows_Kinect_AudioBeam_get_BeamAngle(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeam");
                }

                Windows_Kinect_AudioBeam_put_BeamAngle(_pNative, value);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_AudioBeam_get_BeamAngleConfidence(RootSystem.IntPtr pNative);
        public  float BeamAngleConfidence
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeam");
                }

                return Windows_Kinect_AudioBeam_get_BeamAngleConfidence(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_AudioBeam_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeam");
                }

                return Windows_Kinect_AudioBeam_get_RelativeTime(_pNative);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<AudioBeam>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeam_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_AudioBeam_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_AudioBeam_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
    }

    //
    // Windows.Kinect.AudioBeamSubFrame
    //
    public sealed partial class AudioBeamSubFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBeamSubFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBeamSubFrame_AddRefObject(ref _pNative);
        }

        ~AudioBeamSubFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamSubFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamSubFrame_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioBeamSubFrame>(_pNative);
                Windows_Kinect_AudioBeamSubFrame_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_AudioBeamSubFrame_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern Windows.Kinect.AudioBeamMode Windows_Kinect_AudioBeamSubFrame_get_AudioBeamMode(RootSystem.IntPtr pNative);
        public  Windows.Kinect.AudioBeamMode AudioBeamMode
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
                }

                return Windows_Kinect_AudioBeamSubFrame_get_AudioBeamMode(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioBeamSubFrame_get_AudioBodyCorrelations(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] RootSystem.IntPtr[] outCollection, int collectionSize);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioBeamSubFrame_get_AudioBodyCorrelations_Length(RootSystem.IntPtr pNative);
        public  RootSystem.Collections.Generic.IList<Windows.Kinect.AudioBodyCorrelation> AudioBodyCorrelations
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
                }

                int collectionSize = Windows_Kinect_AudioBeamSubFrame_get_AudioBodyCorrelations_Length(_pNative);
                var outCollection = new RootSystem.IntPtr[collectionSize];
                var managedCollection = new Windows.Kinect.AudioBodyCorrelation[collectionSize];

                collectionSize = Windows_Kinect_AudioBeamSubFrame_get_AudioBodyCorrelations(_pNative, outCollection, collectionSize);
                for(int i=0;i<collectionSize;i++)
                {
                    if(outCollection[i] == RootSystem.IntPtr.Zero)
                    {
                        continue;
                    }

                    outCollection[i] = Helper.NativeObjectCache.MapToIUnknown(outCollection[i]);
                    var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioBodyCorrelation>(outCollection[i]);
                    if (obj == null)
                    {
                        obj = new Windows.Kinect.AudioBodyCorrelation(outCollection[i]);
                        Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioBodyCorrelation>(outCollection[i], obj);
                    }

                    managedCollection[i] = obj;
                }
                return managedCollection;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_AudioBeamSubFrame_get_BeamAngle(RootSystem.IntPtr pNative);
        public  float BeamAngle
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
                }

                return Windows_Kinect_AudioBeamSubFrame_get_BeamAngle(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern float Windows_Kinect_AudioBeamSubFrame_get_BeamAngleConfidence(RootSystem.IntPtr pNative);
        public  float BeamAngleConfidence
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
                }

                return Windows_Kinect_AudioBeamSubFrame_get_BeamAngleConfidence(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_AudioBeamSubFrame_get_Duration(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan Duration
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
                }

                return Windows_Kinect_AudioBeamSubFrame_get_Duration(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern uint Windows_Kinect_AudioBeamSubFrame_get_FrameLengthInBytes(RootSystem.IntPtr pNative);
        public  uint FrameLengthInBytes
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
                }

                return Windows_Kinect_AudioBeamSubFrame_get_FrameLengthInBytes(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_AudioBeamSubFrame_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
                }

                return Windows_Kinect_AudioBeamSubFrame_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamSubFrame_CopyFrameDataToArray(RootSystem.IntPtr pNative, byte[] frameData, int frameDataSize);
        public void CopyFrameDataToArray(byte[] frameData)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("AudioBeamSubFrame");
            }

            Windows_Kinect_AudioBeamSubFrame_CopyFrameDataToArray(_pNative, frameData, frameData.Length);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamSubFrame_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.AudioBodyCorrelation
    //
    public sealed partial class AudioBodyCorrelation
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBodyCorrelation(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBodyCorrelation_AddRefObject(ref _pNative);
        }

        ~AudioBodyCorrelation()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBodyCorrelation_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBodyCorrelation_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioBodyCorrelation>(_pNative);
                Windows_Kinect_AudioBodyCorrelation_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern ulong Windows_Kinect_AudioBodyCorrelation_get_BodyTrackingId(RootSystem.IntPtr pNative);
        public  ulong BodyTrackingId
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBodyCorrelation");
                }

                return Windows_Kinect_AudioBodyCorrelation_get_BodyTrackingId(_pNative);
            }
        }

    }

    //
    // Windows.Kinect.AudioBeamFrame
    //
    public sealed partial class AudioBeamFrame : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBeamFrame(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBeamFrame_AddRefObject(ref _pNative);
        }

        ~AudioBeamFrame()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrame_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrame_AddRefObject(ref RootSystem.IntPtr pNative);

        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_AudioBeamFrame_get_AudioBeam(RootSystem.IntPtr pNative);
        public  Windows.Kinect.AudioBeam AudioBeam
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_AudioBeamFrame_get_AudioBeam(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioBeam>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioBeam(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioBeam>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_AudioBeamFrame_get_AudioSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.AudioSource AudioSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrame");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_AudioBeamFrame_get_AudioSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_AudioBeamFrame_get_Duration(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan Duration
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrame");
                }

                return Windows_Kinect_AudioBeamFrame_get_Duration(_pNative);
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_AudioBeamFrame_get_RelativeTimeStart(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTimeStart
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrame");
                }

                return Windows_Kinect_AudioBeamFrame_get_RelativeTimeStart(_pNative);
            }
        }


        // Public Methods
    }

    //
    // Windows.Kinect.AudioBeamFrameReference
    //
    public sealed partial class AudioBeamFrameReference
    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBeamFrameReference(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBeamFrameReference_AddRefObject(ref _pNative);
        }

        ~AudioBeamFrameReference()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReference_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReference_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioBeamFrameReference>(_pNative);
                Windows_Kinect_AudioBeamFrameReference_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.TimeSpan Windows_Kinect_AudioBeamFrameReference_get_RelativeTime(RootSystem.IntPtr pNative);
        public  RootSystem.TimeSpan RelativeTime
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrameReference");
                }

                return Windows_Kinect_AudioBeamFrameReference_get_RelativeTime(_pNative);
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioBeamFrameReference_AcquireBeamFrames_Length(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioBeamFrameReference_AcquireBeamFrames(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] RootSystem.IntPtr[] outCollection, int collectionSize);
        public RootSystem.Collections.Generic.IList<Windows.Kinect.AudioBeamFrame> AcquireBeamFrames()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("AudioBeamFrameReference");
            }

            int collectionSize = Windows_Kinect_AudioBeamFrameReference_AcquireBeamFrames_Length(_pNative);
            var outCollection = new RootSystem.IntPtr[collectionSize];
            var managedCollection = new Windows.Kinect.AudioBeamFrame[collectionSize];

            collectionSize = Windows_Kinect_AudioBeamFrameReference_AcquireBeamFrames(_pNative, outCollection, collectionSize);
            for(int i=0;i<collectionSize;i++)
            {
                if(outCollection[i] == RootSystem.IntPtr.Zero)
                {
                    continue;
                }

                outCollection[i] = Helper.NativeObjectCache.MapToIUnknown(outCollection[i]);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioBeamFrame>(outCollection[i]);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioBeamFrame(outCollection[i]);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioBeamFrame>(outCollection[i], obj);
                }

                managedCollection[i] = obj;
            }
            return managedCollection;
        }

    }

    //
    // Windows.Kinect.AudioBeamFrameReader
    //
    public sealed partial class AudioBeamFrameReader : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBeamFrameReader(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBeamFrameReader_AddRefObject(ref _pNative);
        }

        ~AudioBeamFrameReader()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReader_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReader_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioBeamFrameReader>(_pNative);
                Windows_Kinect_AudioBeamFrameReader_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_AudioBeamFrameReader_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_AudioBeamFrameReader_get_AudioSource(RootSystem.IntPtr pNative);
        public  Windows.Kinect.AudioSource AudioSource
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrameReader");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_AudioBeamFrameReader_get_AudioSource(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioSource>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioSource(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioSource>(objectPointer, obj);
                }

                return obj;
            }
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern bool Windows_Kinect_AudioBeamFrameReader_get_IsPaused(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReader_put_IsPaused(RootSystem.IntPtr pNative, bool isPaused);
        public  bool IsPaused
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrameReader");
                }

                return Windows_Kinect_AudioBeamFrameReader_get_IsPaused(_pNative);
            }
            set
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrameReader");
                }

                Windows_Kinect_AudioBeamFrameReader_put_IsPaused(_pNative, value);
            }
        }


        // Events
        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.AudioBeamFrameArrivedEventArgs>>> Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Kinect.AudioBeamFrameArrivedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate))]
        private static void Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Kinect.AudioBeamFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<AudioBeamFrameReader>(pNative);
                    var args = new Windows.Kinect.AudioBeamFrameArrivedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReader_add_FrameArrived(RootSystem.IntPtr pNative, _Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Kinect.AudioBeamFrameArrivedEventArgs> FrameArrived
        {
            add
            {
            if(!Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Kinect.AudioBeamFrameArrivedEventArgs>>());
            }
            var callbackList = Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate(Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_Handler);
                        _Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_AudioBeamFrameReader_add_FrameArrived(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Kinect.AudioBeamFrameArrivedEventArgs>>();
            }
            var callbackList = Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_AudioBeamFrameReader_add_FrameArrived(_pNative, Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_Handler, true);
                        _Windows_Kinect_AudioBeamFrameArrivedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }

        private static RootSystem.Runtime.InteropServices.GCHandle _Windows_Data_PropertyChangedEventArgs_Delegate_Handle;
        [RootSystem.Runtime.InteropServices.UnmanagedFunctionPointer(RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private delegate void _Windows_Data_PropertyChangedEventArgs_Delegate(RootSystem.IntPtr args, RootSystem.IntPtr pNative);
        private static Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>> Windows_Data_PropertyChangedEventArgs_Delegate_callbacks = new Dictionary<RootSystem.IntPtr, List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>>();
        [AOT.MonoPInvokeCallbackAttribute(typeof(_Windows_Data_PropertyChangedEventArgs_Delegate))]
        private static void Windows_Data_PropertyChangedEventArgs_Delegate_Handler(RootSystem.IntPtr result, RootSystem.IntPtr pNative)
        {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[pNative];
            lock(callbackList)
            {
                try
                {
                    var objThis = Helper.NativeObjectCache.GetObject<AudioBeamFrameReader>(pNative);
                    var args = new Windows.Data.PropertyChangedEventArgs(result);
                    foreach(var func in callbackList)
                    {
                        if(func != null)
                        {
                            func(objThis, args);
                        }
                    }
                }
                catch { }
            }
        }
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReader_add_PropertyChanged(RootSystem.IntPtr pNative, _Windows_Data_PropertyChangedEventArgs_Delegate eventCallback, bool unsubscribe);
        public event RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs> PropertyChanged
        {
            add
            {
            if(!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.Add(_pNative, new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>());
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Add(value);
                    if(callbackList.Count == 1)
                    {
                        var del = new _Windows_Data_PropertyChangedEventArgs_Delegate(Windows_Data_PropertyChangedEventArgs_Delegate_Handler);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle = RootSystem.Runtime.InteropServices.GCHandle.Alloc(del);
                        Windows_Kinect_AudioBeamFrameReader_add_PropertyChanged(_pNative, del, false);
                    }
                }
            }
            remove
            {
            if (!Windows_Data_PropertyChangedEventArgs_Delegate_callbacks.ContainsKey(_pNative))
            {
                Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative] = new List<RootSystem.EventHandler<Windows.Data.PropertyChangedEventArgs>>();
            }
            var callbackList = Windows_Data_PropertyChangedEventArgs_Delegate_callbacks[_pNative];
                lock (callbackList)
                {
                    callbackList.Remove(value);
                    if(callbackList.Count == 0)
                    {
                        Windows_Kinect_AudioBeamFrameReader_add_PropertyChanged(_pNative, Windows_Data_PropertyChangedEventArgs_Delegate_Handler, true);
                        _Windows_Data_PropertyChangedEventArgs_Delegate_Handle.Free();
                    }
                }
            }
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioBeamFrameReader_AcquireLatestBeamFrames_Length(RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern int Windows_Kinect_AudioBeamFrameReader_AcquireLatestBeamFrames(RootSystem.IntPtr pNative, [RootSystem.Runtime.InteropServices.Out] RootSystem.IntPtr[] outCollection, int collectionSize);
        public RootSystem.Collections.Generic.IList<Windows.Kinect.AudioBeamFrame> AcquireLatestBeamFrames()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                throw new RootSystem.ObjectDisposedException("AudioBeamFrameReader");
            }

            int collectionSize = Windows_Kinect_AudioBeamFrameReader_AcquireLatestBeamFrames_Length(_pNative);
            var outCollection = new RootSystem.IntPtr[collectionSize];
            var managedCollection = new Windows.Kinect.AudioBeamFrame[collectionSize];

            collectionSize = Windows_Kinect_AudioBeamFrameReader_AcquireLatestBeamFrames(_pNative, outCollection, collectionSize);
            for(int i=0;i<collectionSize;i++)
            {
                if(outCollection[i] == RootSystem.IntPtr.Zero)
                {
                    continue;
                }

                outCollection[i] = Helper.NativeObjectCache.MapToIUnknown(outCollection[i]);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioBeamFrame>(outCollection[i]);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioBeamFrame(outCollection[i]);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioBeamFrame>(outCollection[i], obj);
                }

                managedCollection[i] = obj;
            }
            return managedCollection;
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameReader_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    //
    // Windows.Kinect.AudioBeamFrameArrivedEventArgs
    //
    public sealed partial class AudioBeamFrameArrivedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBeamFrameArrivedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBeamFrameArrivedEventArgs_AddRefObject(ref _pNative);
        }

        ~AudioBeamFrameArrivedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameArrivedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameArrivedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioBeamFrameArrivedEventArgs>(_pNative);
                Windows_Kinect_AudioBeamFrameArrivedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Kinect_AudioBeamFrameArrivedEventArgs_get_FrameReference(RootSystem.IntPtr pNative);
        public  Windows.Kinect.AudioBeamFrameReference FrameReference
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("AudioBeamFrameArrivedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Kinect_AudioBeamFrameArrivedEventArgs_get_FrameReference(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                objectPointer = Helper.NativeObjectCache.MapToIUnknown(objectPointer);
                var obj = Helper.NativeObjectCache.GetObject<Windows.Kinect.AudioBeamFrameReference>(objectPointer);
                if (obj == null)
                {
                    obj = new Windows.Kinect.AudioBeamFrameReference(objectPointer);
                    Helper.NativeObjectCache.AddObject<Windows.Kinect.AudioBeamFrameReference>(objectPointer, obj);
                }

                return obj;
            }
        }

    }

    //
    // Windows.Kinect.CoordinateMappingChangedEventArgs
    //
    public sealed partial class CoordinateMappingChangedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal CoordinateMappingChangedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_CoordinateMappingChangedEventArgs_AddRefObject(ref _pNative);
        }

        ~CoordinateMappingChangedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMappingChangedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_CoordinateMappingChangedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<CoordinateMappingChangedEventArgs>(_pNative);
                Windows_Kinect_CoordinateMappingChangedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }

    }

    //
    // Windows.Kinect.AudioBeamFrameList
    //
    public sealed partial class AudioBeamFrameList : RootSystem.IDisposable

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal AudioBeamFrameList(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Kinect_AudioBeamFrameList_AddRefObject(ref _pNative);
        }

        ~AudioBeamFrameList()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameList_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameList_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<AudioBeamFrameList>(_pNative);
                Windows_Kinect_AudioBeamFrameList_ReleaseObject(ref _pNative);

            if (disposing)
            {
                Windows_Kinect_AudioBeamFrameList_Dispose(_pNative);
            }

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Methods
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Kinect_AudioBeamFrameList_Dispose(RootSystem.IntPtr pNative);
        public void Dispose()
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Dispose(true);
            RootSystem.GC.SuppressFinalize(this);
        }

    }

    #endregion // Classes
}

namespace Windows.Kinect
{

    #region Structs

    #endregion // Structs

    #region Classes

    #endregion // Classes
}

namespace Windows.Data
{

    #region Classes

    //
    // Windows.Data.PropertyChangedEventArgs
    //
    public sealed partial class PropertyChangedEventArgs : RootSystem.EventArgs

    {
        internal RootSystem.IntPtr _pNative;

        // Constructors and Finalizers
        internal PropertyChangedEventArgs(RootSystem.IntPtr pNative)
        {
            _pNative = pNative;
            Windows_Data_PropertyChangedEventArgs_AddRefObject(ref _pNative);
        }

        ~PropertyChangedEventArgs()
        {
            Dispose(false);
        }

        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Data_PropertyChangedEventArgs_ReleaseObject(ref RootSystem.IntPtr pNative);
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern void Windows_Data_PropertyChangedEventArgs_AddRefObject(ref RootSystem.IntPtr pNative);
        private void Dispose(bool disposing)
        {
            if (_pNative == RootSystem.IntPtr.Zero)
            {
                return;
            }

            Helper.NativeObjectCache.RemoveObject<PropertyChangedEventArgs>(_pNative);
                Windows_Data_PropertyChangedEventArgs_ReleaseObject(ref _pNative);

            _pNative = RootSystem.IntPtr.Zero;
        }


        // Public Properties
        [RootSystem.Runtime.InteropServices.DllImport("KinectForUnity", CallingConvention=RootSystem.Runtime.InteropServices.CallingConvention.Cdecl)]
        private static extern RootSystem.IntPtr Windows_Data_PropertyChangedEventArgs_get_PropertyName(RootSystem.IntPtr pNative);
        public  string PropertyName
        {
            get
            {
                if (_pNative == RootSystem.IntPtr.Zero)
                {
                    throw new RootSystem.ObjectDisposedException("PropertyChangedEventArgs");
                }

                RootSystem.IntPtr objectPointer = Windows_Data_PropertyChangedEventArgs_get_PropertyName(_pNative);
                if (objectPointer == RootSystem.IntPtr.Zero)
                {
                    return null;
                }

                return RootSystem.Runtime.InteropServices.Marshal.PtrToStringUni(objectPointer);
            }
        }

    }

    #endregion // Classes
}

