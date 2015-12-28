using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
[Serializable]
public struct CatPartImagesStruct
{
    public string Name;
    public Image Image;
}
[Serializable]
public struct StripsAndSpotsSiblingStruct
{
    public string Name;
    public RectTransform RectTransform;
}

public class DrawCat : MonoBehaviour
{

    private Dictionary<string, Image> _catPartImages = new Dictionary<string, Image>();
    private Dictionary<string, TextAsset> _assetsDictionary = new Dictionary<string, TextAsset>();
    private readonly Dictionary<string, RectTransform> _stripsAndSpotsSibling = new Dictionary<string, RectTransform>();

    public CatPartImagesStruct[] CatPartImagesAray;
    public StripsAndSpotsSiblingStruct[] StripsAndSpotsArray;
    public Dictionary<string, Image> CatPartImages
    {
        get
        {
            return _catPartImages;
        }

        set
        {
            _catPartImages = value;
        }
    }

    public Dictionary<string, TextAsset> AssetsDictionary
    {
        get
        {
            return _assetsDictionary;
        }

        set
        {
            _assetsDictionary = value;
        }
    }

    private PlayerAvatar PlayerAvatar { get; set; }

    public TextAsset[] Assets;

    public Sprite Blank;

    private readonly string[] _furColorPartNames = {"ColorBack", "ColorBackFoot", "ColorBreast", "ColorEars", "ColorHose", "ColorMain", "ColorSocks", "ColorTail", "ColorTailTip"};
    private readonly string[] _stripsAndSpotsPartNames = {"StripsS", "StripsM", "StripsL", "SpotsS", "SpotsM", "SpotsL", "SpotsLe"};

    private readonly string[] _arrayForDefault =
    {
        "ColorBack", "ColorBackFoot", "ColorBreast", "ColorEars", "ColorHose",
        "ColorMain", "ColorSocks", "ColorTail", "ColorTailTip", "StripsS", "StripsM", "StripsL", "SpotsS", "SpotsM",
        "SpotsL", "SpotsLe", "EyesColor", "Ears", "Nose"
    };



    private void Awake()
    {
        foreach (CatPartImagesStruct e in CatPartImagesAray)
        {
            CatPartImages.Add(e.Name, e.Image);
        }

        foreach (StripsAndSpotsSiblingStruct e in StripsAndSpotsArray)
        {
            _stripsAndSpotsSibling.Add(e.Name, e.RectTransform);
        }

        foreach (TextAsset e in Assets)
        {
            AssetsDictionary.Add(e.name, e);
        }




        PlayerAvatar = GameObject.FindWithTag("CatStorage").GetComponent<CatStorage>().Player.PlayerAvatar;
        ShapeAndShadow();
        EyesType();




    }



    public void ShapeAndShadow()
    {
        string shapeName = "Shape" + PlayerAvatar["Shape"];
        string shadowName = "Shadow" + PlayerAvatar["Shape"];
        ShowCat(shapeName, "Shape");
        ShowCat(shadowName, "Shadow");
        Ears();
        Nose();
        foreach (string e in _furColorPartNames) {FurColor(e);}
        foreach (string e in _stripsAndSpotsPartNames) {StripsAndSpots(e);}
    }

    public void EyesType()
    {
        string eyesTypeName = "EyesType" + PlayerAvatar["EyesType"];
        ShowCat(eyesTypeName, "EyesType");
        EyesColor();
    }

    public void EyesColor()
    {
        if (PlayerAvatar["EyesColor"] == null || PlayerAvatar["EyesColor"] == "")
        {
            DoBlank("EyesColor");    
        }
        else
        {
            string eyesColorName = "EyesColor" + EyesTypeCalculation() + PlayerAvatar["EyesColor"];
            ShowCat(eyesColorName, "EyesColor");
        }
    }

    public void Ears()
    {
        if (PlayerAvatar["Ears"] == null || PlayerAvatar["Ears"] == "")
        {
            DoBlank("Ears");
        }
        else
        {
            string earsName = "Ears" + PlayerAvatar["FurryType"] + PlayerAvatar["Ears"];
            ShowCat(earsName, "Ears");
        }
    }

    public void Nose()
    {
        if (PlayerAvatar["Nose"] == null || PlayerAvatar["Nose"] == "")
        {
            DoBlank("Nose");

        }
        else
        {
            string noseName = "Nose" + NoseTypeCalculation() + PlayerAvatar["Nose"];
            ShowCat(noseName, "Nose");
        }
    }

    public void FurColor(string partName)
    {
        if (PlayerAvatar[partName] == null || PlayerAvatar[partName] == "")
        {
            DoBlank(partName);
        }
        else
        {
            string furColorName = partName + PlayerAvatar["FurryType"] + FurColorCalculation() + PlayerAvatar[partName];
            ShowCat(furColorName, partName);
        }
    }

    public void StripsAndSpots(string partName)
    {
        if (PlayerAvatar[partName] == null || PlayerAvatar[partName] == "")
        {
            DoBlank(partName);
        }
        else
        {
            string stripsAndSpotsName = partName + PlayerAvatar["FurryType"] + FurColorCalculation() + PlayerAvatar[partName];
            ShowCat(stripsAndSpotsName, partName);
        }
    }

    private void ShowCat(string assetName, string partName)
    {
        
        TextAsset textAsset = AssetsDictionary[assetName];
#if UNITY_EDITOR
        Texture2D tex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        tex.LoadImage(textAsset.bytes);
        CatPartImages[partName].sprite = Sprite.Create(tex, new Rect(0, 0, 1000, 600), new Vector2(0, 0));
        Resources.UnloadUnusedAssets();
#endif

#if UNITY_STANDALONE
        Texture2D tex1 = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        tex1.LoadImage(textAsset.bytes);
        CatPartImages[partName].sprite = Sprite.Create(tex1, new Rect(0, 0, 1000, 600), new Vector2(0, 0));
        Resources.UnloadUnusedAssets();
#endif


#if UNITY_ANDROID
        Texture2D tex2 = new Texture2D(1000, 600, TextureFormat.ARGB4444, false);
        tex2.LoadImage(textAsset.bytes);
        CatPartImages[partName].sprite = Sprite.Create(tex2, new Rect(0, 0, 1000, 600), new Vector2(0, 0));
        Resources.UnloadUnusedAssets();
#endif

    }

    private string EyesTypeCalculation()
    {
        if (PlayerAvatar["EyesType"] == "Angry1" || PlayerAvatar["EyesType"] == "Angry2" || PlayerAvatar["EyesType"] == "Angry3" || PlayerAvatar["EyesType"] == "Angry4")
        {
            return "Angry";
        }
        else if (PlayerAvatar["EyesType"] == "Cute1" || PlayerAvatar["EyesType"] == "Cute2" || PlayerAvatar["EyesType"] == "Cute3" || PlayerAvatar["EyesType"] == "Cute4")
        {
            return "Cute";
        }
        else if (PlayerAvatar["EyesType"] == "Normal1" || PlayerAvatar["EyesType"] == "Normal2" || PlayerAvatar["EyesType"] == "Normal3" || PlayerAvatar["EyesType"] == "Normal4")
        {
            return "Normal";
        }
        else if (PlayerAvatar["EyesType"] == "Shy1" || PlayerAvatar["EyesType"] == "Shy2" || PlayerAvatar["EyesType"] == "Shy3" || PlayerAvatar["EyesType"] == "Shy4")
        {
            return "Shy";
        }
        else
        {
            return null;
        }


    }

    private string NoseTypeCalculation()
    {
        if (PlayerAvatar["FaceType"] == "Normal" || PlayerAvatar["FaceType"] == "Wide")
        {
            return "NormalOrWide";
        }
        else if (PlayerAvatar["FaceType"] == "Narrow")
        {
            return "Narrow";
        }
        else if (PlayerAvatar["FaceType"] == "Flat")
        {
            return "Flat";
        }
        else
        {
            return null;
        }
    }

    private string FurColorCalculation()
    {
        if (PlayerAvatar["FaceType"] == "Narrow" || PlayerAvatar["FaceType"] == "Wide")
        {
            return PlayerAvatar["FaceType"];
        }
        else
        {
            return "NormalOrFlat";
        }
    }

    public void SetSibling(string partName)
    {
        _stripsAndSpotsSibling[partName].SetAsLastSibling();
    }

    private void DoBlank(string part)
    {
        if (CatPartImages[part].sprite != Blank)
        {
            CatPartImages[part].sprite = Blank;
        }
    }

    public void Default()
    {
        foreach (string e in _arrayForDefault)
        {
            PlayerAvatar[e] = null;
        }
        PlayerAvatar["FurryType"] = "2";
        PlayerAvatar["FaceType"] = "Normal";
        PlayerAvatar["EyesType"] = "Normal3";
        ShapeAndShadow();
        EyesType();
    }

    public void SaveSibling()
    {
        foreach (string e in _stripsAndSpotsPartNames)
        {
            PlayerAvatar.Sibling[e] = _stripsAndSpotsSibling[e].GetSiblingIndex();
        }
    }

}

