using UnityEngine;
using System.Collections;
using System;
using Windows.Kinect;

public class MultiSourseReaderAPI : MonoBehaviour
{

    private readonly int bytesPerPixel = 4;

    //Kinect Senesor
    private KinectSensor _kinectSenesor;
    private CoordinateMapper _coordinateMapper;
    private MultiSourceFrameReader _multiSourceReader;

    //Show
    private Texture2D _finalTexture;
    public Texture2D FinaTexture
    {
        get { return _finalTexture; }
    }

    private ushort[] depthFrameData = null;

    private byte[] colorFrameData = null;

    private byte[] bodyIndexFrameData = null;

    private byte[] displayPixels = null;

    private ColorSpacePoint[] colorPoints = null;

    private Body[] _Data = null;

    public Body[] GetData()
    {
        return _Data;
    }

    // Use this for initialization
    void Start()
    {

        _kinectSenesor = KinectSensor.GetDefault();

 //       if (_kinectSenesor.IsAvailable)
        {
            _multiSourceReader = _kinectSenesor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Depth | FrameSourceTypes.BodyIndex|FrameSourceTypes.Body);
            _coordinateMapper = _kinectSenesor.CoordinateMapper;

            FrameDescription depthFrameDisc = _kinectSenesor.DepthFrameSource.FrameDescription;
            int depthWidth = depthFrameDisc.Width;
            int depthHeight = depthFrameDisc.Height;

            this.depthFrameData = new ushort[depthWidth * depthHeight];
            this.bodyIndexFrameData = new byte[depthWidth * depthHeight];
            this.displayPixels = new byte[depthWidth * depthHeight * this.bytesPerPixel];
            this.colorPoints = new ColorSpacePoint[depthWidth * depthHeight];

            _finalTexture = new Texture2D(depthWidth, depthHeight, TextureFormat.RGBA32, false);

            FrameDescription colorFrameDesc = _kinectSenesor.ColorFrameSource.FrameDescription;
            int colorWidth = colorFrameDesc.Width;
            int colorHeight = colorFrameDesc.Height;

            this.colorFrameData = new byte[colorWidth * colorHeight * bytesPerPixel];


        }
        if (!_kinectSenesor.IsOpen)
        {
            _kinectSenesor.Open();
        }

    }
    int a = 0;
    // Update is called once per frame
    void Update()
    {

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

        #region begin cai ji
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

                                if (bodyFrame != null)
                                {

                                    if (_Data == null)
                                    {
                                        _Data = new Body[_kinectSenesor.BodyFrameSource.BodyCount];
                                    }

                                    Debug.Log("AAA");
                                    bodyFrame.GetAndRefreshBodyData(_Data);
                                    bodyFrameProcessed = true;
                                }
                            }
                            multiSourceFrameProcessed = true;
                        }
                    }
                }
            }

            // we got all frames
            if (multiSourceFrameProcessed && depthFrameProcessed && colorFrameProcessed && bodyIndexFrameProcessed && bodyFrameProcessed)
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

    void DisPlayerTexture()
    {
        _finalTexture.LoadRawTextureData(displayPixels);
        _finalTexture.Apply();
       // Debug.Log(_finalTexture.GetPixel();
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
