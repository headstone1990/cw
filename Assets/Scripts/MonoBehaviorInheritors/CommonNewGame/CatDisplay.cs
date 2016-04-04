using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CatDisplay : MonoBehaviour
{
    string path;
    RawImage shape;
    RawImage eyesType;
    RawImage shadow;
    RawImage ears;
    RawImage nose;
    RawImage eyesColor;
    RawImage colorMain;
    RawImage colorBack;
    RawImage colorBackFoot;
    RawImage colorBreast;
    RawImage colorEars;
    RawImage colorHose;
    RawImage colorSocks;
    RawImage colorTail;
    RawImage colorTailTip;
    RawImage stripsS;
    RawImage stripsM;
    RawImage stripsL;
    RawImage spotsS;
    RawImage spotsM;
    RawImage spotsL;
    RawImage spotsLE;
    Texture2D shapeTex;
    Texture2D shadowTex;
    Texture2D eyesTypeTex;
    Texture2D earsTex;
    Texture2D noseTex;
    Texture2D eyesColorTex;
    Texture2D colorMainTex;
    Texture2D colorBackTex;
    Texture2D colorBackFootTex;
    Texture2D colorBreastTex;
    Texture2D colorEarsTex;
    Texture2D colorHoseTex;
    Texture2D colorSocksTex;
    Texture2D colorTailTex;
    Texture2D colorTailTipTex;
    Texture2D stripsSTex;
    Texture2D stripsMTex;
    Texture2D stripsLTex;
    Texture2D spotsSTex;
    Texture2D spotsMTex;
    Texture2D spotsLTex;
    Texture2D spotsLETex;
    public GameObject shapeObj;
    public GameObject eyesTypeObj;
    public GameObject shadowObj;
    public GameObject earsObj;
    public GameObject noseObj;
    public GameObject eyesColorObj;
    public GameObject colorMainObj;
    public GameObject colorBackObj;
    public GameObject colorBackFootObj;
    public GameObject colorBreastObj;
    public GameObject colorEarsObj;
    public GameObject colorHoseObj;
    public GameObject colorSocksObj;
    public GameObject colorTailObj;
    public GameObject colorTailTipObj;
    public GameObject stripsSObj;
    public GameObject stripsMObj;
    public GameObject stripsLObj;
    public GameObject spotsSObj;
    public GameObject spotsMObj;
    public GameObject spotsLObj;
    public GameObject spotsLEObj;







    void Awake()
    {
        shape = shapeObj.GetComponent<RawImage>();
        eyesType = eyesTypeObj.GetComponent<RawImage>();
        shadow = shadowObj.GetComponent<RawImage>();
        ears = earsObj.GetComponent<RawImage>();
        nose = noseObj.GetComponent<RawImage>();
        eyesColor = eyesColorObj.GetComponent<RawImage>();
        colorMain = colorMainObj.GetComponent<RawImage>();
        colorBack = colorBackObj.GetComponent<RawImage>();
        colorBackFoot = colorBackFootObj.GetComponent<RawImage>();
        colorBreast = colorBreastObj.GetComponent<RawImage>();
        colorEars = colorEarsObj.GetComponent<RawImage>();
        colorHose = colorHoseObj.GetComponent<RawImage>();
        colorSocks = colorSocksObj.GetComponent<RawImage>();
        colorTail = colorTailObj.GetComponent<RawImage>();
        colorTailTip = colorTailTipObj.GetComponent<RawImage>();
        stripsS = stripsSObj.GetComponent<RawImage>();
        stripsM = stripsMObj.GetComponent<RawImage>();
        stripsL = stripsLObj.GetComponent<RawImage>();
        spotsS = spotsSObj.GetComponent<RawImage>();
        spotsM = spotsMObj.GetComponent<RawImage>();
        spotsL = spotsLObj.GetComponent<RawImage>();
        spotsLE = spotsLEObj.GetComponent<RawImage>();
        shapeTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        eyesTypeTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        shadowTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        earsTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        noseTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        eyesColorTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorMainTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorBackTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorBackFootTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorBreastTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorEarsTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorHoseTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorSocksTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorTailTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        colorTailTipTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        stripsSTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        stripsMTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        stripsLTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        spotsSTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        spotsMTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        spotsLTex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        spotsLETex = new Texture2D(1000, 600, TextureFormat.DXT5, false);


    }
    public void Start()
    {
       
        path = Application.streamingAssetsPath;
        SiblingIndexLoad();
        ShapeChange();
        EyesTypeChange();
        EarsChange();
        NoseChange();
        EyesColorChange();
        ColorMainChange();
        ColorBackChange();
        ColorBackFootChange();
        ColorBreastChange();
        ColorEarsChange();
        ColorHoseChange();
        ColorSocksChange();
        ColorTailChange();
        ColorTailTipChange();
        StripsSChange();
        StripsMChange();
        StripsLChange();
        SpotsSChange();
        SpotsMChange();
        SpotsLChange();
        SpotsLEChange();
    }




    public void ShapeChange()
    {

        ShapeCalculation();
        StartCoroutine(ShapeDisplay());
        StartCoroutine(ShadowDisplay());


    }
    public void EyesTypeChange()
    {
        StartCoroutine(EyesTypeDisplay());
        if (GlobalVariables.eyesColor != null)
        { StartCoroutine(EyesColorDisplay()); }
    }
    public void EarsChange()
    {

        if (GlobalVariables.ears != null)
        {
            earsObj.SetActive(true);
            StartCoroutine(EarsDisplay());
        }
        else
        {
            earsObj.SetActive(false);
        }

    }
    public void NoseChange()
    {
        if (GlobalVariables.nose != null)
        {
            StartCoroutine(NoseDisplay());
            noseObj.SetActive(true);
        }
        else
        {
            noseObj.SetActive(false);
        }

    }
    public void EyesColorChange()
    {
        if (GlobalVariables.eyesColor != null)
        {
            StartCoroutine(EyesColorDisplay());
            eyesColorObj.SetActive(true);
        }
        else
        {
            eyesColorObj.SetActive(false);
        }

    }
    public void ColorMainChange()
    {
        if (GlobalVariables.colorMain != null)
        {
            StartCoroutine(ColorMainDisplay());
            colorMainObj.SetActive(true);
        }
        else
        {
            colorMainObj.SetActive(false);
        }

    }
    public void ColorBackChange()
    {
        if (GlobalVariables.colorBack != null)
        {
            StartCoroutine(ColorBackDisplay());
            colorBackObj.SetActive(true);
        }
        else
        {
            colorBackObj.SetActive(false);
        }

    }
    public void ColorBackFootChange()
    {
        if (GlobalVariables.colorBackFoot != null)
        {
            StartCoroutine(ColorBackFootDisplay());
            colorBackFootObj.SetActive(true);
        }
        else
        {
            colorBackFootObj.SetActive(false);
        }

    }
    public void ColorBreastChange()
    {
        if (GlobalVariables.colorBreast != null)
        {
            StartCoroutine(ColorBreastDisplay());
            colorBreastObj.SetActive(true);
        }
        else
        {
            colorBreastObj.SetActive(false);
        }

    }
    public void ColorEarsChange()
    {
        if (GlobalVariables.colorEars != null)
        {
            StartCoroutine(ColorEarsDisplay());
            colorEarsObj.SetActive(true);
        }
        else
        {
            colorEarsObj.SetActive(false);
        }

    }
    public void ColorHoseChange()
    {
        if (GlobalVariables.colorHose != null)
        {
            StartCoroutine(ColorHoseDisplay());
            colorHoseObj.SetActive(true);
        }
        else
        {
            colorHoseObj.SetActive(false);
        }

    }
    public void ColorSocksChange()
    {
        if (GlobalVariables.colorSocks != null)
        {
            StartCoroutine(ColorSocksDisplay());
            colorSocksObj.SetActive(true);
        }
        else
        {
            colorSocksObj.SetActive(false);
        }

    }
    public void ColorTailChange()
    {
        if (GlobalVariables.colorTail != null)
        {
            StartCoroutine(ColorTailDisplay());
            colorTailObj.SetActive(true);
        }
        else
        {
            colorTailObj.SetActive(false);
        }

    }
    public void ColorTailTipChange()
    {
        if (GlobalVariables.colorTailTip != null)
        {
            StartCoroutine(ColorTailTipDisplay());
            colorTailTipObj.SetActive(true);
        }
        else
        {
            colorTailTipObj.SetActive(false);
        }

    }
    public void StripsSChange()
    {
        if (GlobalVariables.stripsS != null)
        {
            StartCoroutine(StripsSDisplay());
            stripsSObj.SetActive(true);
        }
        else
        {
            stripsSObj.SetActive(false);
        }

    }
    public void StripsMChange()
    {
        if (GlobalVariables.stripsM != null)
        {
            StartCoroutine(StripsMDisplay());
            stripsMObj.SetActive(true);
        }
        else
        {
            stripsMObj.SetActive(false);
        }

    }
    public void StripsLChange()
    {
        if (GlobalVariables.stripsL != null)
        {
            StartCoroutine(StripsLDisplay());
            stripsLObj.SetActive(true);
        }
        else
        {
            stripsLObj.SetActive(false);
        }
    }
    public void SpotsSChange()
    {
        if (GlobalVariables.spotsS != null)
        {
            StartCoroutine(SpotsSDisplay());
            spotsSObj.SetActive(true);
        }
        else
        {
            spotsSObj.SetActive(false);
        }

    }
    public void SpotsMChange()
    {
        if (GlobalVariables.spotsM != null)
        {
            StartCoroutine(SpotsMDisplay());
            spotsMObj.SetActive(true);
        }
        else
        {
            spotsMObj.SetActive(false);
        }

    }
    public void SpotsLChange()
    {
        if (GlobalVariables.spotsL != null)
        {
            StartCoroutine(SpotsLDisplay());
            spotsLObj.SetActive(true);
        }
        else
        {
            spotsLObj.SetActive(false);
        }

    }
    public void SpotsLEChange()
    {
        if (GlobalVariables.spotsLE != null)
        {
            StartCoroutine(SpotsLEDisplay());
            spotsLEObj.SetActive(true);
        }
        else
        {
            spotsLEObj.SetActive(false);
        }

    }
    public void SiblingIndexLoad()
    {
        stripsSObj.transform.SetSiblingIndex(GlobalVariables.stripsSIndex);
        stripsMObj.transform.SetSiblingIndex(GlobalVariables.stripsMIndex);
        stripsLObj.transform.SetSiblingIndex(GlobalVariables.stripsLIndex);
        spotsSObj.transform.SetSiblingIndex(GlobalVariables.spotsSIndex);
        spotsMObj.transform.SetSiblingIndex(GlobalVariables.spotsMIndex);
        spotsLObj.transform.SetSiblingIndex(GlobalVariables.spotsLIndex);
        spotsLEObj.transform.SetSiblingIndex(GlobalVariables.spotsLEIndex);


    }



    //Вычисление значения shape
    public void ShapeCalculation()
    {
        if (GlobalVariables.faceType == "normal" && GlobalVariables.furryType == 1)
        {
            GlobalVariables.shape = 1;
        }
        else if (GlobalVariables.faceType == "normal" && GlobalVariables.furryType == 2)
        {
            GlobalVariables.shape = 2;
        }
        else if (GlobalVariables.faceType == "normal" && GlobalVariables.furryType == 3)
        {
            GlobalVariables.shape = 3;
        }
        else if (GlobalVariables.faceType == "flat" && GlobalVariables.furryType == 1)
        {
            GlobalVariables.shape = 4;
        }
        else if (GlobalVariables.faceType == "flat" && GlobalVariables.furryType == 2)
        {
            GlobalVariables.shape = 5;
        }
        else if (GlobalVariables.faceType == "flat" && GlobalVariables.furryType == 3)
        {
            GlobalVariables.shape = 6;
        }
        else if (GlobalVariables.faceType == "narrow" && GlobalVariables.furryType == 1)
        {
            GlobalVariables.shape = 7;
        }
        else if (GlobalVariables.faceType == "narrow" && GlobalVariables.furryType == 2)
        {
            GlobalVariables.shape = 8;
        }
        else if (GlobalVariables.faceType == "narrow" && GlobalVariables.furryType == 3)
        {
            GlobalVariables.shape = 9;
        }
        else if (GlobalVariables.faceType == "wide" && GlobalVariables.furryType == 1)
        {
            GlobalVariables.shape = 10;
        }
        else if (GlobalVariables.faceType == "wide" && GlobalVariables.furryType == 2)
        {
            GlobalVariables.shape = 11;
        }
        else if (GlobalVariables.faceType == "wide" && GlobalVariables.furryType == 3)
        {
            GlobalVariables.shape = 12;
        }

    }


    //Отображение Shape
    public IEnumerator ShapeDisplay()
    {

        if (GlobalVariables.shape == 1)
        {
            string url = "file:///" + path + "/Textures/editor/shape/1.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;

        }
        else if (GlobalVariables.shape == 2)
        {
            string url = "file:///" + path + "/Textures/editor/shape/2.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 3)
        {
            string url = "file:///" + path + "/Textures/editor/shape/3.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 4)
        {
            string url = "file:///" + path + "/Textures/editor/shape/4.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 5)
        {
            string url = "file:///" + path + "/Textures/editor/shape/5.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 6)
        {
            string url = "file:///" + path + "/Textures/editor/shape/6.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 7)
        {
            string url = "file:///" + path + "/Textures/editor/shape/7.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 8)
        {
            string url = "file:///" + path + "/Textures/editor/shape/8.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 9)
        {
            string url = "file:///" + path + "/Textures/editor/shape/9.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 10)
        {
            string url = "file:///" + path + "/Textures/editor/shape/10.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 11)
        {
            string url = "file:///" + path + "/Textures/editor/shape/11.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
        else if (GlobalVariables.shape == 12)
        {
            string url = "file:///" + path + "/Textures/editor/shape/12.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shapeTex);
            shape.texture = shapeTex;
        }
    }


    //Отображение EyesType
    public IEnumerator EyesTypeDisplay()
    {
        if (GlobalVariables.eyesType == "angry_1")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/angry_1.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "angry_2")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/angry_2.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "angry_3")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/angry_3.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "angry_4")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/angry_4.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "cute_1")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/cute_1.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "cute_2")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/cute_2.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "cute_3")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/cute_3.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "cute_4")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/cute_4.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "normal_1")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/normal_1.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "normal_2")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/normal_2.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "normal_3")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/normal_3.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "normal_4")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/normal_4.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "shy_1")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/shy_1.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "shy_2")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/shy_2.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "shy_3")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/shy_3.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
        else if (GlobalVariables.eyesType == "shy_4")
        {
            string url = "file:///" + path + "/Textures/editor/eyes/type/shy_4.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesTypeTex);
            eyesType.texture = eyesTypeTex;
        }
    }


    //Отображение Shadow
    public IEnumerator ShadowDisplay()
    {
        if (GlobalVariables.shape == 1)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/1.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 2)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/2.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 3)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/3.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 4)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/4.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 5)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/5.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 6)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/6.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 7)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/7.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 8)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/8.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 9)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/9.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 10)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/10.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 11)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/11.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
        else if (GlobalVariables.shape == 12)
        {
            string url = "file:///" + path + "/Textures/editor/shadow/12.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(shadowTex);
            shadow.texture = shadowTex;
        }
    }


    //Просчет пути в зависимости от формы
    public string EarsPath()
    {
        if (GlobalVariables.shape == 1 || GlobalVariables.shape == 4 || GlobalVariables.shape == 7 || GlobalVariables.shape == 10)
        {
            string Path = "/Textures/editor/ears/1_4_7_10/";
            return Path;
        }
        else if (GlobalVariables.shape == 2 || GlobalVariables.shape == 5 || GlobalVariables.shape == 8 || GlobalVariables.shape == 11)
        {
            string Path = "/Textures/editor/ears/2_5_8_11/";
            return Path;
        }
        else if (GlobalVariables.shape == 3 || GlobalVariables.shape == 6 || GlobalVariables.shape == 9 || GlobalVariables.shape == 12)
        {
            string earsPath = "/Textures/editor/ears/3_6_9_12/";
            return earsPath;
        }
        else
        {
            return (null);
        }

    }
    //Отображение Ears
    public IEnumerator EarsDisplay()
    {
        string earsPath;
        earsPath = EarsPath();
        if (GlobalVariables.ears == "black")
        {
            string url = "file:///" + path + earsPath + "black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == "gray")
        {
            string url = "file:///" + path + earsPath + "gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == "pink")
        {
            string url = "file:///" + path + earsPath + "pink.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == "bright")
        {
            string url = "file:///" + path + earsPath + "bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == "peach")
        {
            string url = "file:///" + path + earsPath + "peach.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == "sand")
        {
            string url = "file:///" + path + earsPath + "sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == "brown")
        {
            string url = "file:///" + path + earsPath + "brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == "spotty")
        {
            string url = "file:///" + path + earsPath + "spotty.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }

        else if (GlobalVariables.ears == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(earsTex);
            ears.texture = earsTex;
        }




    }

    //Просчет пути в зависимости от формы
    string NosePath()
    {
        if (GlobalVariables.shape == 1 || GlobalVariables.shape == 2 || GlobalVariables.shape == 3 || GlobalVariables.shape == 10 || GlobalVariables.shape == 11 || GlobalVariables.shape == 12)
        {
            string path = "/Textures/editor/nose/normal/";
            return path;
        }

        else if (GlobalVariables.shape == 4 || GlobalVariables.shape == 5 || GlobalVariables.shape == 6)
        {
            string path = "/Textures/editor/nose/flat/";
            return path;
        }

        else if (GlobalVariables.shape == 7 || GlobalVariables.shape == 8 || GlobalVariables.shape == 9)
        {
            string path = "/Textures/editor/nose/narrow/";
            return path;
        }
        else
        {
            string path = null;
            return path;
        }
    }
    //Отображение Nose
    public IEnumerator NoseDisplay()
    {
        string nosePath;
        nosePath = NosePath();
        if (GlobalVariables.nose == "black")
        {
            string url = "file:///" + path + nosePath + "black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == "gray")
        {
            string url = "file:///" + path + nosePath + "gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == "pink")
        {
            string url = "file:///" + path + nosePath + "pink.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == "bright")
        {
            string url = "file:///" + path + nosePath + "bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == "peach")
        {
            string url = "file:///" + path + nosePath + "peach.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == "sand")
        {
            string url = "file:///" + path + nosePath + "sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == "brown")
        {
            string url = "file:///" + path + nosePath + "brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == "spotty")
        {
            string url = "file:///" + path + nosePath + "spotty.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

        else if (GlobalVariables.nose == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(noseTex);
            nose.texture = noseTex;
        }

    }

    //Просчет пути в зависимости от типа глаз
    string EyesColorPath()
    {
        if (GlobalVariables.eyesType == "angry_1" || GlobalVariables.eyesType == "angry_2" || GlobalVariables.eyesType == "angry_3" || GlobalVariables.eyesType == "angry_4")
        {
            string path = "/Textures/editor/eyes/color/angry/";
            return path;
        }

        else if (GlobalVariables.eyesType == "cute_1" || GlobalVariables.eyesType == "cute_2" || GlobalVariables.eyesType == "cute_3" || GlobalVariables.eyesType == "cute_4")
        {
            string path = "/Textures/editor/eyes/color/cute/";
            return path;
        }

        else if (GlobalVariables.eyesType == "normal_1" || GlobalVariables.eyesType == "normal_2" || GlobalVariables.eyesType == "normal_3" || GlobalVariables.eyesType == "normal_4")
        {
            string path = "/Textures/editor/eyes/color/normal/";
            return path;
        }

        else if (GlobalVariables.eyesType == "shy_1" || GlobalVariables.eyesType == "shy_2" || GlobalVariables.eyesType == "shy_3" || GlobalVariables.eyesType == "shy_4")
        {
            string path = "/Textures/editor/eyes/color/shy/";
            return path;
        }
        else
        {
            string path = null;
            return path;
        }
    }
    //Отображение EyesColor
    public IEnumerator EyesColorDisplay()
    {
        string eyesColorPath;
        eyesColorPath = EyesColorPath();
        if (GlobalVariables.eyesColor == "light_blue")
        {
            string url = "file:///" + path + eyesColorPath + "light_blue.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "blue")
        {
            string url = "file:///" + path + eyesColorPath + "blue.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "dark_blue")
        {
            string url = "file:///" + path + eyesColorPath + "dark_blue.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "gray")
        {
            string url = "file:///" + path + eyesColorPath + "gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "brown")
        {
            string url = "file:///" + path + eyesColorPath + "brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "dark_brown")
        {
            string url = "file:///" + path + eyesColorPath + "dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "amber")
        {
            string url = "file:///" + path + eyesColorPath + "amber.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "yellow")
        {
            string url = "file:///" + path + eyesColorPath + "yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "green_yellow")
        {
            string url = "file:///" + path + eyesColorPath + "green_yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "green")
        {
            string url = "file:///" + path + eyesColorPath + "green.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == "swamp")
        {
            string url = "file:///" + path + eyesColorPath + "swamp.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }

        else if (GlobalVariables.eyesColor == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(eyesColorTex);
            eyesColor.texture = eyesColorTex;
        }




    }

    //Просчет пути в зависимости от формы
    string ColorPath()
    {
        if (GlobalVariables.shape == 1 || GlobalVariables.shape == 4)
        {
            string path = "/Textures/editor/color/1_normal/";
            return path;
        }

        else if (GlobalVariables.shape == 2 || GlobalVariables.shape == 5)
        {
            string path = "/Textures/editor/color/2_normal/";
            return path;
        }

        else if (GlobalVariables.shape == 3 || GlobalVariables.shape == 6)
        {
            string path = "/Textures/editor/color/3_normal/";
            return path;
        }

        else if (GlobalVariables.shape == 7)
        {
            string path = "/Textures/editor/color/1_narrow/";
            return path;
        }

        else if (GlobalVariables.shape == 8)
        {
            string path = "/Textures/editor/color/2_narrow/";
            return path;
        }

        else if (GlobalVariables.shape == 9)
        {
            string path = "/Textures/editor/color/3_narrow/";
            return path;
        }

        else if (GlobalVariables.shape == 10)
        {
            string path = "/Textures/editor/color/1_wide/";
            return path;
        }

        else if (GlobalVariables.shape == 11)
        {
            string path = "/Textures/editor/color/2_wide/";
            return path;
        }

        else if (GlobalVariables.shape == 12)
        {
            string path = "/Textures/editor/color/3_wide/";
            return path;
        }

        else
        {
            string path = null;
            return path;
        }
    }
    //Отображение ColorMain
    public IEnumerator ColorMainDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorMain == "white")
        {
            string url = "file:///" + path + colorPath + "main/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "silver")
        {
            string url = "file:///" + path + colorPath + "main/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "light_gray")
        {
            string url = "file:///" + path + colorPath + "main/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "main/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "gray")
        {
            string url = "file:///" + path + colorPath + "main/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "main/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "black")
        {
            string url = "file:///" + path + colorPath + "main/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "sand")
        {
            string url = "file:///" + path + colorPath + "main/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "yellow")
        {
            string url = "file:///" + path + colorPath + "main/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "main/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "ginger")
        {
            string url = "file:///" + path + colorPath + "main/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "bright")
        {
            string url = "file:///" + path + colorPath + "main/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "light_brown")
        {
            string url = "file:///" + path + colorPath + "main/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "brown")
        {
            string url = "file:///" + path + colorPath + "main/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "main/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }

        else if (GlobalVariables.colorMain == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorMainTex);
            colorMain.texture = colorMainTex;
        }
    }
    //Отображение ColorBack
    public IEnumerator ColorBackDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorBack == "white")
        {
            string url = "file:///" + path + colorPath + "back/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "silver")
        {
            string url = "file:///" + path + colorPath + "back/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "light_gray")
        {
            string url = "file:///" + path + colorPath + "back/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "back/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "gray")
        {
            string url = "file:///" + path + colorPath + "back/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "back/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "black")
        {
            string url = "file:///" + path + colorPath + "back/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "sand")
        {
            string url = "file:///" + path + colorPath + "back/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "yellow")
        {
            string url = "file:///" + path + colorPath + "back/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "back/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "ginger")
        {
            string url = "file:///" + path + colorPath + "back/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "bright")
        {
            string url = "file:///" + path + colorPath + "back/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "light_brown")
        {
            string url = "file:///" + path + colorPath + "back/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "brown")
        {
            string url = "file:///" + path + colorPath + "back/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "back/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }

        else if (GlobalVariables.colorBack == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackTex);
            colorBack.texture = colorBackTex;
        }
    }
    //Отображение ColorBackFoot
    public IEnumerator ColorBackFootDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorBackFoot == "white")
        {
            string url = "file:///" + path + colorPath + "back_foot/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "silver")
        {
            string url = "file:///" + path + colorPath + "back_foot/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "light_gray")
        {
            string url = "file:///" + path + colorPath + "back_foot/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "back_foot/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "gray")
        {
            string url = "file:///" + path + colorPath + "back_foot/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "back_foot/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "black")
        {
            string url = "file:///" + path + colorPath + "back_foot/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "sand")
        {
            string url = "file:///" + path + colorPath + "back_foot/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "yellow")
        {
            string url = "file:///" + path + colorPath + "back_foot/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "back_foot/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "ginger")
        {
            string url = "file:///" + path + colorPath + "back_foot/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "bright")
        {
            string url = "file:///" + path + colorPath + "back_foot/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "light_brown")
        {
            string url = "file:///" + path + colorPath + "back_foot/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "brown")
        {
            string url = "file:///" + path + colorPath + "back_foot/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "back_foot/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }

        else if (GlobalVariables.colorBackFoot == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBackFootTex);
            colorBackFoot.texture = colorBackFootTex;
        }
    }
    //Отображение ColorBreast
    public IEnumerator ColorBreastDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorBreast == "white")
        {
            string url = "file:///" + path + colorPath + "breast/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "silver")
        {
            string url = "file:///" + path + colorPath + "breast/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "light_gray")
        {
            string url = "file:///" + path + colorPath + "breast/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "breast/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "gray")
        {
            string url = "file:///" + path + colorPath + "breast/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "breast/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "black")
        {
            string url = "file:///" + path + colorPath + "breast/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "sand")
        {
            string url = "file:///" + path + colorPath + "breast/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "yellow")
        {
            string url = "file:///" + path + colorPath + "breast/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "breast/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "ginger")
        {
            string url = "file:///" + path + colorPath + "breast/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "bright")
        {
            string url = "file:///" + path + colorPath + "breast/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "light_brown")
        {
            string url = "file:///" + path + colorPath + "breast/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "brown")
        {
            string url = "file:///" + path + colorPath + "breast/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "breast/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }

        else if (GlobalVariables.colorBreast == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorBreastTex);
            colorBreast.texture = colorBreastTex;
        }
    }
    //Отображение ColorEars
    public IEnumerator ColorEarsDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorEars == "white")
        {
            string url = "file:///" + path + colorPath + "ears/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "silver")
        {
            string url = "file:///" + path + colorPath + "ears/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "light_gray")
        {
            string url = "file:///" + path + colorPath + "ears/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "ears/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "gray")
        {
            string url = "file:///" + path + colorPath + "ears/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "ears/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "black")
        {
            string url = "file:///" + path + colorPath + "ears/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "sand")
        {
            string url = "file:///" + path + colorPath + "ears/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "yellow")
        {
            string url = "file:///" + path + colorPath + "ears/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "ears/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "ginger")
        {
            string url = "file:///" + path + colorPath + "ears/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "bright")
        {
            string url = "file:///" + path + colorPath + "ears/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "light_brown")
        {
            string url = "file:///" + path + colorPath + "ears/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "brown")
        {
            string url = "file:///" + path + colorPath + "ears/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "ears/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }

        else if (GlobalVariables.colorEars == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorEarsTex);
            colorEars.texture = colorEarsTex;
        }
    }
    //Отображение ColorHose
    public IEnumerator ColorHoseDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorHose == "white")
        {
            string url = "file:///" + path + colorPath + "hose/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "silver")
        {
            string url = "file:///" + path + colorPath + "hose/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "light_gray")
        {
            string url = "file:///" + path + colorPath + "hose/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "hose/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "gray")
        {
            string url = "file:///" + path + colorPath + "hose/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "hose/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "black")
        {
            string url = "file:///" + path + colorPath + "hose/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "sand")
        {
            string url = "file:///" + path + colorPath + "hose/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "yellow")
        {
            string url = "file:///" + path + colorPath + "hose/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "hose/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "ginger")
        {
            string url = "file:///" + path + colorPath + "hose/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "bright")
        {
            string url = "file:///" + path + colorPath + "hose/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "light_brown")
        {
            string url = "file:///" + path + colorPath + "hose/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "brown")
        {
            string url = "file:///" + path + colorPath + "hose/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "hose/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }

        else if (GlobalVariables.colorHose == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorHoseTex);
            colorHose.texture = colorHoseTex;
        }
    }
    //Отображение ColorSocks
    public IEnumerator ColorSocksDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorSocks == "white")
        {
            string url = "file:///" + path + colorPath + "socks/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "silver")
        {
            string url = "file:///" + path + colorPath + "socks/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "light_gray")
        {
            string url = "file:///" + path + colorPath + "socks/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "socks/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "gray")
        {
            string url = "file:///" + path + colorPath + "socks/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "socks/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "black")
        {
            string url = "file:///" + path + colorPath + "socks/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "sand")
        {
            string url = "file:///" + path + colorPath + "socks/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "yellow")
        {
            string url = "file:///" + path + colorPath + "socks/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "socks/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "ginger")
        {
            string url = "file:///" + path + colorPath + "socks/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "bright")
        {
            string url = "file:///" + path + colorPath + "socks/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "light_brown")
        {
            string url = "file:///" + path + colorPath + "socks/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "brown")
        {
            string url = "file:///" + path + colorPath + "socks/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "socks/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }

        else if (GlobalVariables.colorSocks == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorSocksTex);
            colorSocks.texture = colorSocksTex;
        }
    }
    //Отображение ColorTail
    public IEnumerator ColorTailDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorTail == "white")
        {
            string url = "file:///" + path + colorPath + "tail/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "silver")
        {
            string url = "file:///" + path + colorPath + "tail/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "light_gray")
        {
            string url = "file:///" + path + colorPath + "tail/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "tail/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "gray")
        {
            string url = "file:///" + path + colorPath + "tail/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "tail/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "black")
        {
            string url = "file:///" + path + colorPath + "tail/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "sand")
        {
            string url = "file:///" + path + colorPath + "tail/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "yellow")
        {
            string url = "file:///" + path + colorPath + "tail/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "tail/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "ginger")
        {
            string url = "file:///" + path + colorPath + "tail/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "bright")
        {
            string url = "file:///" + path + colorPath + "tail/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "light_brown")
        {
            string url = "file:///" + path + colorPath + "tail/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "brown")
        {
            string url = "file:///" + path + colorPath + "tail/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "tail/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }

        else if (GlobalVariables.colorTail == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTex);
            colorTail.texture = colorTailTex;
        }
    }
    //Отображение ColorTailTip
    public IEnumerator ColorTailTipDisplay()
    {
        string colorPath;
        colorPath = ColorPath();
        if (GlobalVariables.colorTailTip == "white")
        {
            string url = "file:///" + path + colorPath + "tail_tip/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "silver")
        {
            string url = "file:///" + path + colorPath + "tail_tip/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "light_gray")
        {
            string url = "file:///" + path + colorPath + "tail_tip/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "blue_gray")
        {
            string url = "file:///" + path + colorPath + "tail_tip/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "gray")
        {
            string url = "file:///" + path + colorPath + "tail_tip/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "dark_gray")
        {
            string url = "file:///" + path + colorPath + "tail_tip/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "black")
        {
            string url = "file:///" + path + colorPath + "tail_tip/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "sand")
        {
            string url = "file:///" + path + colorPath + "tail_tip/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "yellow")
        {
            string url = "file:///" + path + colorPath + "tail_tip/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "pale_ginger")
        {
            string url = "file:///" + path + colorPath + "tail_tip/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "ginger")
        {
            string url = "file:///" + path + colorPath + "tail_tip/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "bright")
        {
            string url = "file:///" + path + colorPath + "tail_tip/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "light_brown")
        {
            string url = "file:///" + path + colorPath + "tail_tip/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "brown")
        {
            string url = "file:///" + path + colorPath + "tail_tip/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == "dark_brown")
        {
            string url = "file:///" + path + colorPath + "tail_tip/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }

        else if (GlobalVariables.colorTailTip == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(colorTailTipTex);
            colorTailTip.texture = colorTailTipTex;
        }
    }


    //Просчет пути в зависимости от формы
    string StripsAndSpotsPath()
    {
        if (GlobalVariables.shape == 1 || GlobalVariables.shape == 4)
        {
            string path = "/Textures/editor/strips_and_spots/1_normal/";
            return path;
        }

        else if (GlobalVariables.shape == 2 || GlobalVariables.shape == 5)
        {
            string path = "/Textures/editor/strips_and_spots/2_normal/";
            return path;
        }

        else if (GlobalVariables.shape == 3 || GlobalVariables.shape == 6)
        {
            string path = "/Textures/editor/strips_and_spots/3_normal/";
            return path;
        }

        else if (GlobalVariables.shape == 7)
        {
            string path = "/Textures/editor/strips_and_spots/1_narrow/";
            return path;
        }

        else if (GlobalVariables.shape == 8)
        {
            string path = "/Textures/editor/strips_and_spots/2_narrow/";
            return path;
        }

        else if (GlobalVariables.shape == 9)
        {
            string path = "/Textures/editor/strips_and_spots/3_narrow/";
            return path;
        }

        else if (GlobalVariables.shape == 10)
        {
            string path = "/Textures/editor/strips_and_spots/1_wide/";
            return path;
        }

        else if (GlobalVariables.shape == 11)
        {
            string path = "/Textures/editor/strips_and_spots/2_wide/";
            return path;
        }

        else if (GlobalVariables.shape == 12)
        {
            string path = "/Textures/editor/strips_and_spots/3_wide/";
            return path;
        }

        else
        {
            string path = null;
            return path;
        }

    }
    //Отображение StripsS
    public IEnumerator StripsSDisplay()
    {
        string stripsAndSpotsPath;
        stripsAndSpotsPath = StripsAndSpotsPath();
        if (GlobalVariables.stripsS == "white")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "silver")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "light_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "blue_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "dark_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "black")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "sand")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "yellow")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "pale_ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "bright")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "light_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == "dark_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_s/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }

        else if (GlobalVariables.stripsS == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsSTex);
            stripsS.texture = stripsSTex;
        }
    }
    //Отображение StripsM
    public IEnumerator StripsMDisplay()
    {
        string stripsAndSpotsPath;
        stripsAndSpotsPath = StripsAndSpotsPath();
        if (GlobalVariables.stripsM == "white")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "silver")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "light_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "blue_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "dark_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "black")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "sand")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "yellow")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "pale_ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "bright")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "light_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == "dark_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_m/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }

        else if (GlobalVariables.stripsM == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsMTex);
            stripsM.texture = stripsMTex;
        }
    }
    //Отображение StripsL
    public IEnumerator StripsLDisplay()
    {
        string stripsAndSpotsPath;
        stripsAndSpotsPath = StripsAndSpotsPath();
        if (GlobalVariables.stripsL == "white")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "silver")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "light_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "blue_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "dark_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "black")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "sand")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "yellow")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "pale_ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "bright")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "light_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == "dark_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "strips_l/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }

        else if (GlobalVariables.stripsL == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(stripsLTex);
            stripsL.texture = stripsLTex;
        }
    }
    //Отображение SpotsS
    public IEnumerator SpotsSDisplay()
    {
        string stripsAndSpotsPath;
        stripsAndSpotsPath = StripsAndSpotsPath();
        if (GlobalVariables.spotsS == "white")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "silver")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "light_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "blue_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "dark_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "black")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "sand")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "yellow")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "pale_ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "bright")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "light_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == "dark_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_s/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }

        else if (GlobalVariables.spotsS == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsSTex);
            spotsS.texture = spotsSTex;
        }
    }
    //Отображение SpotsM
    public IEnumerator SpotsMDisplay()
    {
        string stripsAndSpotsPath;
        stripsAndSpotsPath = StripsAndSpotsPath();
        if (GlobalVariables.spotsM == "white")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "silver")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "light_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "blue_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "dark_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "black")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "sand")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex; ;
        }

        else if (GlobalVariables.spotsM == "yellow")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "pale_ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "bright")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "light_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == "dark_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_m/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }

        else if (GlobalVariables.spotsM == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsMTex);
            spotsM.texture = spotsMTex;
        }
    }
    //Отображение SpotsL
    public IEnumerator SpotsLDisplay()
    {
        string stripsAndSpotsPath;
        stripsAndSpotsPath = StripsAndSpotsPath();
        if (GlobalVariables.spotsL == "white")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "silver")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "light_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "blue_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "dark_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "black")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "sand")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "yellow")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "pale_ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "bright")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "light_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == "dark_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_l/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }

        else if (GlobalVariables.spotsL == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLTex);
            spotsL.texture = spotsLTex;
        }
    }
    //Отображение SpotsLE
    public IEnumerator SpotsLEDisplay()
    {
        string stripsAndSpotsPath;
        stripsAndSpotsPath = StripsAndSpotsPath();
        if (GlobalVariables.spotsLE == "white")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/white.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "silver")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/silver.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "light_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/light_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "blue_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/blue_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "dark_gray")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/dark_gray.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "black")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/black.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "sand")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/sand.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "yellow")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/yellow.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "pale_ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/pale_ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "ginger")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/ginger.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "bright")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/bright.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "light_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/light_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == "dark_brown")
        {
            string url = "file:///" + path + stripsAndSpotsPath + "spots_le/dark_brown.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }

        else if (GlobalVariables.spotsLE == null)
        {
            string url = "file:///" + path + "/Textures/blank.png";
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(spotsLETex);
            spotsLE.texture = spotsLETex;
        }
    }


}

