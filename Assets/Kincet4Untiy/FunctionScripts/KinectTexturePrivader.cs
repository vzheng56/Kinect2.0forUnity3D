using UnityEngine;
using System.Collections;
using System;
using Windows.Kinect;

namespace Kinect4Unity
{
    public class KinectTexturePrivader : MonoBehaviour
    {

        private readonly int bytesPerPixel = 4;

        //Kinect Senesor
        private KinectSensor _kinectSenesor;
        private CoordinateMapper _coordinateMapper;
        private MultiSourceFrameReader _multiSourceReader;


        #region Texture To Show
        //Show
        private Texture2D _backGroundRemoveTexture;
        public Texture2D BackGroundRemoveTexture
        {
            get { return _backGroundRemoveTexture; }
        }

        private Texture2D _kinectColorTexture;
        public Texture2D KinectColorTexture
        {
            get { return _kinectColorTexture; }
        }

        private Texture2D _kinectInfterateTexture;
        public Texture2D KinectInfreratedTexture
        {
            get { return _kinectInfterateTexture; }
        }

        #endregion

        private ushort[] depthFrameData = null;

        private byte[] colorFrameData = null;

        private byte[] bodyIndexFrameData = null;

        private byte[] displayPixels = null;

        private ColorSpacePoint[] colorPoints = null;


        static KinectTexturePrivader myInstance;
        static int instances = 0;
        public static KinectTexturePrivader Instance
        {
            get
            {
                if (myInstance == null)
                {
                    Debug.Log(myInstance);
                    myInstance = FindObjectOfType(typeof(KinectTexturePrivader)) as KinectTexturePrivader;
                }
                return myInstance;
            }
        }
        //Called at the biginning of the game
        void Start()
        {

            //Calibrates the myInstance static variable
            instances++;

            if (instances > 1)
                Debug.LogWarning("Warning: There are more than one KinectTexturePrivader at the level");
            else
            {
                myInstance = this;
            }

            _kinectSenesor = KinectSensor.GetDefault();

            _multiSourceReader = _kinectSenesor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Depth | FrameSourceTypes.BodyIndex | FrameSourceTypes.Body);
            _coordinateMapper = _kinectSenesor.CoordinateMapper;

            FrameDescription depthFrameDisc = _kinectSenesor.DepthFrameSource.FrameDescription;
            int depthWidth = depthFrameDisc.Width;
            int depthHeight = depthFrameDisc.Height;

            this.depthFrameData = new ushort[depthWidth * depthHeight];
            this.bodyIndexFrameData = new byte[depthWidth * depthHeight];
            this.displayPixels = new byte[depthWidth * depthHeight * this.bytesPerPixel];
            this.colorPoints = new ColorSpacePoint[depthWidth * depthHeight];

            _backGroundRemoveTexture = new Texture2D(depthWidth, depthHeight, TextureFormat.RGBA32, false);

            FrameDescription colorFrameDesc = _kinectSenesor.ColorFrameSource.FrameDescription;
            int colorWidth = colorFrameDesc.Width;
            int colorHeight = colorFrameDesc.Height;

            this.colorFrameData = new byte[colorWidth * colorHeight * bytesPerPixel];

            if (!_kinectSenesor.IsOpen)
            {
                _kinectSenesor.Open();
            }

        }

        void Update()
        {
            //局部变量
            int depthWidth = 0;
            int depthHeight = 0;

            int colorWidth = 0;
            int colorHeight = 0;

            int bodyIndexWidth = 0;
            int bodyIndexHeight = 0;

            bool multiSourceFrameProcessed = false;
            bool colorFrameProcessed = false;
            bool depthFrameProcessed = false;
            bool bodyIndexFrameProcessed = false;
            bool bodyFrameProcessed = false;

            #region _multiSourceReader Begin Work
            if (_multiSourceReader != null)
            {

                MultiSourceFrame multiSourceFrame = _multiSourceReader.AcquireLatestFrame();

                if (multiSourceFrame != null)
                {
                    using (DepthFrame depthFrame = multiSourceFrame.DepthFrameReference.AcquireFrame())
                    {
                        using (ColorFrame colorFrame = multiSourceFrame.ColorFrameReference.AcquireFrame())
                        {
                            using (BodyIndexFrame bodyIndexFrame = multiSourceFrame.BodyIndexFrameReference.AcquireFrame())
                            {
                                using (BodyFrame bodyFrame = multiSourceFrame.BodyFrameReference.AcquireFrame())
                                {
                                    if (depthFrame != null)
                                    {
                                        FrameDescription depthFrameDescription = depthFrame.FrameDescription;
                                        depthWidth = depthFrameDescription.Width;
                                        depthHeight = depthFrameDescription.Height;

                                        if ((depthWidth * depthHeight) == this.depthFrameData.Length)
                                        {
                                            depthFrame.CopyFrameDataToArray(this.depthFrameData);

                                            depthFrameProcessed = true;
                                        }
                                    }

                                    if (colorFrame != null)
                                    {
                                        FrameDescription colorFrameDescription = colorFrame.FrameDescription;
                                        colorWidth = colorFrameDescription.Width;
                                        colorHeight = colorFrameDescription.Height;

                                        if ((colorWidth * colorHeight * this.bytesPerPixel) == this.colorFrameData.Length)
                                        {
                                            if (colorFrame.RawColorImageFormat == ColorImageFormat.Rgba)
                                            {
                                                colorFrame.CopyRawFrameDataToArray(this.colorFrameData);
                                            }
                                            else
                                            {
                                                colorFrame.CopyConvertedFrameDataToArray(this.colorFrameData, ColorImageFormat.Rgba);
                                            }

                                            colorFrameProcessed = true;
                                        }
                                    }

                                    if (bodyIndexFrame != null)
                                    {
                                        FrameDescription bodyIndexFrameDescription = bodyIndexFrame.FrameDescription;
                                        bodyIndexWidth = bodyIndexFrameDescription.Width;
                                        bodyIndexHeight = bodyIndexFrameDescription.Height;

                                        if ((bodyIndexWidth * bodyIndexHeight) == this.bodyIndexFrameData.Length)
                                        {
                                            bodyIndexFrame.CopyFrameDataToArray(this.bodyIndexFrameData);

                                            bodyIndexFrameProcessed = true;
                                        }
                                    }
                                }
                                multiSourceFrameProcessed = true;
                            }
                        }
                    }
                }

                // we got all frames
                if (multiSourceFrameProcessed && depthFrameProcessed && colorFrameProcessed && bodyIndexFrameProcessed)
                {
                    _coordinateMapper.MapDepthFrameToColorSpace(this.depthFrameData, this.colorPoints);

                    Array.Clear(this.displayPixels, 0, this.displayPixels.Length);

                    // loop over each row and column of the depth
                    for (int y = 0; y < depthHeight; ++y)
                    {
                        for (int x = 0; x < depthWidth; ++x)
                        {
                            // calculate index into depth array
                            int depthIndex = (y * depthWidth) + x;

                            byte player = this.bodyIndexFrameData[depthIndex];

                            // if we're tracking a player for the current pixel, sets its color and alpha to full
                            if (player != 0xff)
                            {
                                // retrieve the depth to color mapping for the current depth pixel
                                ColorSpacePoint colorPoint = this.colorPoints[depthIndex];

                                // make sure the depth pixel maps to a valid point in color space
                                int colorX = (int)Math.Floor(colorPoint.X + 0.5);
                                int colorY = (int)Math.Floor(colorPoint.Y + 0.5);
                                if ((colorX >= 0) && (colorX < colorWidth) && (colorY >= 0) && (colorY < colorHeight))
                                {
                                    // calculate index into color array
                                    int colorIndex = ((colorY * colorWidth) + colorX) * this.bytesPerPixel;

                                    // set source for copy to the color pixel
                                    int displayIndex = depthIndex * this.bytesPerPixel;

                                    // write out blue byte
                                    this.displayPixels[displayIndex++] = this.colorFrameData[colorIndex++];

                                    // write out green byte
                                    this.displayPixels[displayIndex++] = this.colorFrameData[colorIndex++];

                                    // write out red byte
                                    this.displayPixels[displayIndex++] = this.colorFrameData[colorIndex];

                                    // write out alpha byte
                                    this.displayPixels[displayIndex] = 0xff;

                                }
                            }
                        }
                    }
                }
            }
            #endregion

            DisPlayerTexture();
        }

        //make texture
        void DisPlayerTexture()
        {
            _backGroundRemoveTexture.LoadRawTextureData(displayPixels);
            _backGroundRemoveTexture.Apply();
            Debug.Log("ASAS");
        }

        void OnApplicationQuit()
        {
            if (_multiSourceReader != null)
            {
                _multiSourceReader.Dispose();
                _multiSourceReader = null;
            }

            if (_kinectSenesor != null && _kinectSenesor.IsOpen)
            {
                _kinectSenesor.Close();
                _kinectSenesor = null;
            }
        }
    }
}