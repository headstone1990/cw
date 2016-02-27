using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInh.EditorScripts
{

   // #region Структуры
    //[Serializable]
    //public struct CatPartImagesStruct
    //{
    //    public string Name;
    //    public Image Image;
    //}

    //[Serializable]
    //public struct StripsAndSpotsSiblingStruct
    //{
    //    public string Name;
    //    public RectTransform RectTransform;
    //}

    //#endregion


    public class CatPainter : MonoBehaviour
    {
        #region Объявление и инициализация полей и свойств

        // Здесь ссылки на компоненты Image различных частей кота(контур, расцветка различных частей и.т.д.
        private readonly Dictionary<string, Image> _catPartImages = new Dictionary<string, Image>();
        // Здесь ссылки на сами ассеты изображений различных частей кота.
        private readonly Dictionary<string, TextAsset> _assets = new Dictionary<string, TextAsset>();
        // Здесь ссылки на компонеты RectTransform полосок и пятен на коте. Они необходимы для изменения порядка их наложения.
        private readonly Dictionary<string, RectTransform> _stripsAndSpotsRectTransforms = new Dictionary<string, RectTransform>();
        // Здесь ссылка на экземпляр класса PlayerAvatar, который хранит в себе информацию о внешнем виде кота(например форма морды - широкая, основной окрас - белый, и.т.д.)
        private PlayerAvatar _playerAvatar;
        public PlayerAvatar PlayerAvatar
        {
            get { return _playerAvatar; }
            set { _playerAvatar = value; }
        }


        #region Объявление вспомогательных переменных и массивов

        [SerializeField]
        private Image[] _catPartImagesAray;
        [SerializeField]
        private TextAsset[] _assetsArray;
        [SerializeField]
        private RectTransform[] _stripsAndSpotsRectTransformsArray;
        [SerializeField]
        private Sprite _blankSprite;

        #endregion
        #region Вспомогательные массивы стрингов

        private readonly PlayerAvatar.Parts[] _furColorPartNames = 
        {
            PlayerAvatar.Parts.ColorBack, PlayerAvatar.Parts.ColorBackFoot, PlayerAvatar.Parts.ColorBreast, PlayerAvatar.Parts.ColorEars,
            PlayerAvatar.Parts.ColorHose, PlayerAvatar.Parts.ColorMain, PlayerAvatar.Parts.ColorSocks, PlayerAvatar.Parts.ColorTail,
            PlayerAvatar.Parts.ColorTailTip
        };

        private readonly PlayerAvatar.Parts[] _stripsAndSpotsPartNames =
        {
           PlayerAvatar.Parts.StripsS, PlayerAvatar.Parts.StripsM, PlayerAvatar.Parts.StripsL,
           PlayerAvatar.Parts.SpotsS, PlayerAvatar.Parts.SpotsM, PlayerAvatar.Parts.SpotsL, PlayerAvatar.Parts.SpotsLe
        };
        // Этот массив содержит названия частей кота, значения которых равны null, при первой загрузке редактора, либо после сброса кнопкой default.;

        private readonly PlayerAvatar.Parts[] _arrayForDefaultFurColorsAndStripsAndSpots = {PlayerAvatar.Parts.ColorBack, PlayerAvatar.Parts.ColorBackFoot, PlayerAvatar.Parts.ColorBreast, PlayerAvatar.Parts.ColorEars,
            PlayerAvatar.Parts.ColorHose, PlayerAvatar.Parts.ColorMain, PlayerAvatar.Parts.ColorSocks, PlayerAvatar.Parts.ColorTail,
            PlayerAvatar.Parts.ColorTailTip, PlayerAvatar.Parts.StripsS, PlayerAvatar.Parts.StripsM, PlayerAvatar.Parts.StripsL,
            PlayerAvatar.Parts.SpotsS, PlayerAvatar.Parts.SpotsM, PlayerAvatar.Parts.SpotsL, PlayerAvatar.Parts.SpotsLe,
            PlayerAvatar.Parts.EyesColor};
        private readonly PlayerAvatar.Parts[] _arrayForDefaultEarsAndNose =  { PlayerAvatar.Parts.Ears, PlayerAvatar.Parts.Nose };


        #endregion

        #endregion Объявление и инициализация полей и свойств

        //
        private void Awake()
        {
            foreach (Image e in _catPartImagesAray)
            {
                _catPartImages.Add(e.gameObject.name, e);
            }

            foreach (RectTransform e in _stripsAndSpotsRectTransformsArray)
            {
                _stripsAndSpotsRectTransforms.Add(e.gameObject.name, e);
            }

            foreach (TextAsset e in _assetsArray)
            {
                _assets.Add(e.name, e);
            }
            _playerAvatar = GameObject.FindWithTag("CatStorage").GetComponent<CatStorage>().Player.PlayerAvatar;
            DrawShapeAndShadow();
            DrawEyesType();
        }

        #region Методы

        public void DrawShapeAndShadow()
        {
            string shapeName = _playerAvatar[PlayerAvatar.Parts.Shape].ToString();
            string shadowName = _playerAvatar[PlayerAvatar.Parts.Shadow].ToString();
            CreateAndAssignSprite(shapeName, "Shape");
            CreateAndAssignSprite(shadowName, "Shadow");
            DrawEars();
            DrawNose();
            foreach (PlayerAvatar.Parts e in _furColorPartNames)
            {
                DrawFurColors(e);
            }
            foreach (PlayerAvatar.Parts e in _stripsAndSpotsPartNames)
            {
                DrawStripsAndSpots(e);
            }
        }
        public void DrawEyesType()
        {
            string eyesTypeName = "EyesType" + _playerAvatar[PlayerAvatar.Parts.EyesType];
            CreateAndAssignSprite(eyesTypeName, "EyesType");
            DrawEyesColor();
        }
        public void DrawEyesColor()
        {
            if ((PlayerAvatar.EyesColors)_playerAvatar[PlayerAvatar.Parts.EyesColor] == PlayerAvatar.EyesColors.None)
            {
                DoBlank("EyesColor");
            }
            else
            {
                string eyesColorName = "EyesColor" + EyesTypeForEyesColorCalculation() + _playerAvatar[PlayerAvatar.Parts.EyesColor];
                CreateAndAssignSprite(eyesColorName, "EyesColor");
            }
        }
        public void DrawEars()
        {
            if ((PlayerAvatar.EarsAndNoses)_playerAvatar[PlayerAvatar.Parts.Ears] == PlayerAvatar.EarsAndNoses.None)
            {
                DoBlank("Ears");
            }
            else
            {
                string earsName = "Ears" + _playerAvatar[PlayerAvatar.Parts.FurryType] + _playerAvatar[PlayerAvatar.Parts.Ears];
                CreateAndAssignSprite(earsName, "Ears");
            }
        }
        public void DrawNose()
        {
            if ((PlayerAvatar.EarsAndNoses)_playerAvatar[PlayerAvatar.Parts.Nose] == PlayerAvatar.EarsAndNoses.None)
            {
                DoBlank("Nose");
            }
            else
            {
                string noseName = "Nose" + FaceTypeForNoseCalculation() + _playerAvatar[PlayerAvatar.Parts.Nose];
                CreateAndAssignSprite(noseName, "Nose");
            }
        }
        public void DrawFurColors(PlayerAvatar.Parts partName)
        {
            if ((PlayerAvatar.FurColorsAndStripsAndSpots)_playerAvatar[partName] == PlayerAvatar.FurColorsAndStripsAndSpots.None)
            {
                DoBlank(partName);
            }
            else
            {
                string furColorName = partName.ToString() + _playerAvatar[PlayerAvatar.Parts.FurryType] + FaceTypeForFurColorAndStripsAndSpotsCalculation() + _playerAvatar[partName];
                CreateAndAssignSprite(furColorName, partName.ToString());
            }
        }
        public void DrawStripsAndSpots(PlayerAvatar.Parts partName)
        {
            if ((PlayerAvatar.FurColorsAndStripsAndSpots)_playerAvatar[partName] == PlayerAvatar.FurColorsAndStripsAndSpots.None)
            {
                DoBlank(partName);
            }
            else
            {
                string stripsAndSpotsName = partName.ToString() + _playerAvatar[PlayerAvatar.Parts.FurryType] + FaceTypeForFurColorAndStripsAndSpotsCalculation() + _playerAvatar[partName];
                CreateAndAssignSprite(stripsAndSpotsName, partName.ToString());
            }
        }
        private void CreateAndAssignSprite(string assetName, string partName)
        {

            TextAsset textAsset = _assets[assetName];
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBGL
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

        private string EyesTypeForEyesColorCalculation()
        {
            if ((int)(PlayerAvatar.EyesTypes)_playerAvatar[PlayerAvatar.Parts.EyesType] < 5)
            {
                return "Angry";
            }
            if ((int)(PlayerAvatar.EyesTypes)_playerAvatar[PlayerAvatar.Parts.EyesType] > 4 ||
                (int)(PlayerAvatar.EyesTypes)_playerAvatar[PlayerAvatar.Parts.EyesType] < 9)
            {
                return "Cute";
            }
            if ((int)(PlayerAvatar.EyesTypes)_playerAvatar[PlayerAvatar.Parts.EyesType] > 8 ||
                (int)(PlayerAvatar.EyesTypes)_playerAvatar[PlayerAvatar.Parts.EyesType] < 13)
            {
                return "Normal";
            }
            if ((int)(PlayerAvatar.EyesTypes)_playerAvatar[PlayerAvatar.Parts.EyesType] > 12)
            {
                return "Shy";
            }
            return null;
        }
        private string FaceTypeForNoseCalculation()
        {
            if ((PlayerAvatar.FaceTypes)_playerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Normal ||
                (PlayerAvatar.FaceTypes) _playerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Wide)
            {
                return "NormalOrWide";
            }
            return _playerAvatar[PlayerAvatar.Parts.FaceType].ToString();
        }
        private string FaceTypeForFurColorAndStripsAndSpotsCalculation()
        {
            if ((PlayerAvatar.FaceTypes)_playerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Normal || 
                (PlayerAvatar.FaceTypes)_playerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Flat)
            {
                return "NormalOrFlat";
            }
            return _playerAvatar[PlayerAvatar.Parts.FaceType].ToString();
        }

        #endregion
        public void SetSibling(string partName)
        {
            _stripsAndSpotsRectTransforms[partName].SetAsLastSibling();
        }
        private void DoBlank(string part)
        {
            if (_catPartImages[part].sprite != _blankSprite)
            {
                _catPartImages[part].sprite = _blankSprite;
            }
        }
        private void DoBlank(PlayerAvatar.Parts part)
        {
            if (_catPartImages[part.ToString()].sprite != _blankSprite)
            {
                _catPartImages[part.ToString()].sprite = _blankSprite;
            }
        }
        public void Default()
        {

            foreach (PlayerAvatar.Parts e in _arrayForDefaultFurColorsAndStripsAndSpots)
            {
                _playerAvatar[e] = PlayerAvatar.FurColorsAndStripsAndSpots.None;
            }
            foreach (PlayerAvatar.Parts e in _arrayForDefaultEarsAndNose)
            {
                _playerAvatar[e] = PlayerAvatar.EarsAndNoses.None;
            }
            _playerAvatar[PlayerAvatar.Parts.FurryType] = PlayerAvatar.FurryTypes.NormalFur;
            _playerAvatar[PlayerAvatar.Parts.FaceType] = PlayerAvatar.FaceTypes.Normal;
            _playerAvatar[PlayerAvatar.Parts.EyesType] = PlayerAvatar.EyesTypes.Normal3;
            DrawShapeAndShadow();
            DrawEyesType();
        }
        public void SaveSibling()
        {
            foreach (PlayerAvatar.Parts e in _stripsAndSpotsPartNames)
            {
                _playerAvatar.Sibling[e] = _stripsAndSpotsRectTransforms[e.ToString()].GetSiblingIndex();
            }
        }
        #endregion
    }
}