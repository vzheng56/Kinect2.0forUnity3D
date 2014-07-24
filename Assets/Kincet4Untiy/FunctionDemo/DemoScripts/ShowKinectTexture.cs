using UnityEngine;
using System.Collections;

//引用命名空间
using Kinect4Unity;

public class ShowKinectTexture : MonoBehaviour
{

    public enum KinectTextureType
    {
        TEXTURETYPE_COLOR = 0,
        TEXTURETYPE_DEPTH,
        TEXTURETYPPE_INFTATED,
        TEXTURETYPE_BACKREMOVE
    }

    public KinectTextureType TextureType = KinectTextureType.TEXTURETYPE_COLOR;

    private Material _PlanMatarial;
    private Texture2D _TextureGet;
    // Use this for initialization
    void Start()
    {
        _PlanMatarial = gameObject.renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        switch (TextureType)
        {
            case KinectTextureType.TEXTURETYPE_COLOR:
                _TextureGet = KinectTexturePrivader.Instance.KinectColorTexture;
                _PlanMatarial.shader = Shader.Find("Diffuse");
                _PlanMatarial.SetTexture("_MainTex", _TextureGet);
                break;
            case KinectTextureType.TEXTURETYPE_DEPTH:
                Debug.LogError("This API is Not Complete ~");
                break;
            case KinectTextureType.TEXTURETYPPE_INFTATED:
                _TextureGet = KinectTexturePrivader.Instance.KinectInfraredtedTexture;
                _PlanMatarial.shader = Shader.Find("Diffuse");
                _PlanMatarial.SetTexture("_MainTex", _TextureGet);
                break;
            case KinectTextureType.TEXTURETYPE_BACKREMOVE:
                _TextureGet = KinectTexturePrivader.Instance.BackGroundRemoveTexture;
                _PlanMatarial.shader = Shader.Find("Transparent/Diffuse");
                _PlanMatarial.SetTexture("_MainTex", _TextureGet);
                break;
        }
    }
}