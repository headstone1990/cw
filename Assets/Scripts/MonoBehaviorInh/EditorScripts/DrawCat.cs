using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


#region Структуры
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

#endregion


public class DrawCat : MonoBehaviour
{
    #region Объявление и инициализация полей и свойств

    private Dictionary<string, Image> _catPartImages = new Dictionary<string, Image>();
    private Dictionary<string, TextAsset> _assetsDictionary = new Dictionary<string, TextAsset>();
    private Dictionary<string, RectTransform> _stripsAndSpotsSibling = new Dictionary<string, RectTransform>();
    private PlayerAvatar _playerAvatar;
    private readonly string[] _furColorPartNames = { "ColorBack", "ColorBackFoot", "ColorBreast", "ColorEars", "ColorHose", "ColorMain", "ColorSocks", "ColorTail", "ColorTailTip" };
    private readonly string[] _stripsAndSpotsPartNames = { "StripsS", "StripsM", "StripsL", "SpotsS", "SpotsM", "SpotsL", "SpotsLe" };
    private readonly string[] _arrayForDefault = {"ColorBack", "ColorBackFoot", "ColorBreast", "ColorEars", "ColorHose", "ColorMain", "ColorSocks", "ColorTail", "ColorTailTip", "StripsS", "StripsM", "StripsL", "SpotsS", "SpotsM", "SpotsL", "SpotsLe", "EyesColor", "Ears", "Nose"};


    #region Объвление вспомогательных массивов для использования с Dictionary

    public StripsAndSpotsSiblingStruct[] StripsAndSpotsArray;
    public CatPartImagesStruct[] CatPartImagesAray;
    public TextAsset[] Assets;

    #endregion
    public Sprite Blank;
    
    #endregion Объявление и инициализация полей и свойств


    private void Awake()
    {
        foreach (CatPartImagesStruct e in CatPartImagesAray)
        {
            _catPartImages.Add(e.Name, e.Image);
        }

        foreach (StripsAndSpotsSiblingStruct e in StripsAndSpotsArray)
        {
            _stripsAndSpotsSibling.Add(e.Name, e.RectTransform);
        }

        foreach (TextAsset e in Assets)
        {
            _assetsDictionary.Add(e.name, e);
        }
        _playerAvatar = GameObject.FindWithTag("CatStorage").GetComponent<CatStorage>().Player.PlayerAvatar;
        ShapeAndShadow();
        EyesType();
    }


    #region Методы

    public void ShapeAndShadow()
    {
        string shapeName = "Shape" + _playerAvatar["Shape"];
        string shadowName = "Shadow" + _playerAvatar["Shape"];
        ShowCat(shapeName, "Shape");
        ShowCat(shadowName, "Shadow");
        Ears();
        Nose();
        foreach (string e in _furColorPartNames)
        {
            FurColor(e);
        }
        foreach (string e in _stripsAndSpotsPartNames)
        {
            StripsAndSpots(e);
        }
    }
    public void EyesType()
    {
        string eyesTypeName = "EyesType" + _playerAvatar["EyesType"];
        ShowCat(eyesTypeName, "EyesType");
        EyesColor();
    }
    public void EyesColor()
    {
        if (_playerAvatar["EyesColor"] == null || _playerAvatar["EyesColor"] == "")
        {
            DoBlank("EyesColor");
        }
        else
        {
            string eyesColorName = "EyesColor" + EyesTypeCalculation() + _playerAvatar["EyesColor"];
            ShowCat(eyesColorName, "EyesColor");
        }
    }
    public void Ears()
    {
        if (_playerAvatar["Ears"] == null || _playerAvatar["Ears"] == "")
        {
            DoBlank("Ears");
        }
        else
        {
            string earsName = "Ears" + _playerAvatar["FurryType"] + _playerAvatar["Ears"];
            ShowCat(earsName, "Ears");
        }
    }
    public void Nose()
    {
        if (_playerAvatar["Nose"] == null || _playerAvatar["Nose"] == "")
        {
            DoBlank("Nose");

        }
        else
        {
            string noseName = "Nose" + NoseTypeCalculation() + _playerAvatar["Nose"];
            ShowCat(noseName, "Nose");
        }
    }
    public void FurColor(string partName)
    {
        if (_playerAvatar[partName] == null || _playerAvatar[partName] == "")
        {
            DoBlank(partName);
        }
        else
        {
            string furColorName = partName + _playerAvatar["FurryType"] + FurColorCalculation() + _playerAvatar[partName];
            ShowCat(furColorName, partName);
        }
    }
    public void StripsAndSpots(string partName)
    {
        if (_playerAvatar[partName] == null || _playerAvatar[partName] == "")
        {
            DoBlank(partName);
        }
        else
        {
            string stripsAndSpotsName = partName + _playerAvatar["FurryType"] + FurColorCalculation() +
                                        _playerAvatar[partName];
            ShowCat(stripsAndSpotsName, partName);
        }
    }
    private void ShowCat(string assetName, string partName)
    {

        TextAsset textAsset = _assetsDictionary[assetName];
#if UNITY_EDITOR || UNITY_STANDALONE|| UNITY_WEBGL
        Texture2D tex = new Texture2D(1000, 600, TextureFormat.DXT5, false);
        tex.LoadImage(textAsset.bytes);
        _catPartImages[partName].sprite = Sprite.Create(tex, new Rect(0, 0, 1000, 600), new Vector2(0, 0));
        Resources.UnloadUnusedAssets();
#endif



#if UNITY_ANDROID
        Texture2D tex2 = new Texture2D(1000, 600, TextureFormat.ARGB4444, false);
        tex2.LoadImage(textAsset.bytes);
        CatPartImages[partName].sprite = Sprite.Create(tex2, new Rect(0, 0, 1000, 600), new Vector2(0, 0));
        Resources.UnloadUnusedAssets();
#endif


    }
    #region Методы вычисляющие название файла в зависимости от параметров

    private string EyesTypeCalculation()
    {
        if (_playerAvatar["EyesType"] == "Angry1" || _playerAvatar["EyesType"] == "Angry2" ||
            _playerAvatar["EyesType"] == "Angry3" || _playerAvatar["EyesType"] == "Angry4")
        {
            return "Angry";
        }
        else if (_playerAvatar["EyesType"] == "Cute1" || _playerAvatar["EyesType"] == "Cute2" ||
                 _playerAvatar["EyesType"] == "Cute3" || _playerAvatar["EyesType"] == "Cute4")
        {
            return "Cute";
        }
        else if (_playerAvatar["EyesType"] == "Normal1" || _playerAvatar["EyesType"] == "Normal2" ||
                 _playerAvatar["EyesType"] == "Normal3" || _playerAvatar["EyesType"] == "Normal4")
        {
            return "Normal";
        }
        else if (_playerAvatar["EyesType"] == "Shy1" || _playerAvatar["EyesType"] == "Shy2" ||
                 _playerAvatar["EyesType"] == "Shy3" || _playerAvatar["EyesType"] == "Shy4")
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
        if (_playerAvatar["FaceType"] == "Normal" || _playerAvatar["FaceType"] == "Wide")
        {
            return "NormalOrWide";
        }
        else if (_playerAvatar["FaceType"] == "Narrow")
        {
            return "Narrow";
        }
        else if (_playerAvatar["FaceType"] == "Flat")
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
        if (_playerAvatar["FaceType"] == "Narrow" || _playerAvatar["FaceType"] == "Wide")
        {
            return _playerAvatar["FaceType"];
        }
        else
        {
            return "NormalOrFlat";
        }
    }

    #endregion
    public void SetSibling(string partName)
    {
        _stripsAndSpotsSibling[partName].SetAsLastSibling();
    }
    private void DoBlank(string part)
    {
        if (_catPartImages[part].sprite != Blank)
        {
            _catPartImages[part].sprite = Blank;
        }
    }
    public void Default()
    {
        foreach (string e in _arrayForDefault)
        {
            _playerAvatar[e] = null;
        }
        _playerAvatar["FurryType"] = "2";
        _playerAvatar["FaceType"] = "Normal";
        _playerAvatar["EyesType"] = "Normal3";
        ShapeAndShadow();
        EyesType();
    }
    public void SaveSibling()
    {
        foreach (string e in _stripsAndSpotsPartNames)
        {
            _playerAvatar.Sibling[e] = _stripsAndSpotsSibling[e].GetSiblingIndex();
        }
    }
    #endregion
}

