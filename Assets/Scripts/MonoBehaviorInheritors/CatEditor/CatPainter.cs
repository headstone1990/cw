using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.CatEditor
{
    public class CatPainter : MonoBehaviour
    {
        public static CatPainter Painter { get; private set; }
        #region Объявление и инициализация полей и свойств

        // Здесь ссылки на компоненты Image различных частей кота(контур, расцветка различных частей и.т.д.
        private Dictionary<string, Image> _catPartImages = new Dictionary<string, Image>();
        // Здесь ссылки на сами ассеты изображений различных частей кота.
        private Dictionary<string, TextAsset> _assets = new Dictionary<string, TextAsset>();
        // Здесь ссылки на компонеты RectTransform полосок и пятен на коте. Они необходимы для изменения порядка их наложения.
        private Dictionary<string, RectTransform> _stripsAndSpotsRectTransforms = new Dictionary<string, RectTransform>();
        // Здесь ссылка на экземпляр класса PlayerAvatar, который хранит в себе информацию о внешнем виде кота(например форма морды - широкая, основной окрас - белый, и.т.д.)
        public PlayerAvatar PlayerAvatar { get; private set; }

        public Dictionary<string, RectTransform> StripsAndSpotsRectTransforms
        {
            get { return _stripsAndSpotsRectTransforms; }
        }

        #region Объявление вспомогательных переменных и массивов

        [SerializeField]
        private Image[] _catPartImagesAray = null; //Set in inspector
        [SerializeField]
        private TextAsset[] _assetsArray = null; //Set in inspector
        [SerializeField]
        private RectTransform[] _stripsAndSpotsRectTransformsArray = null; //Set in inspector
        [SerializeField]
        private Sprite _blankSprite = null; //Set in inspector

        #endregion
        #region Вспомогательные массивы стрингов

        private readonly PlayerAvatar.Parts[] FurColorPartNames =
        {
            PlayerAvatar.Parts.ColorBack, PlayerAvatar.Parts.ColorBackFoot, PlayerAvatar.Parts.ColorBreast, PlayerAvatar.Parts.ColorEars,
            PlayerAvatar.Parts.ColorHose, PlayerAvatar.Parts.ColorMain, PlayerAvatar.Parts.ColorSocks, PlayerAvatar.Parts.ColorTail,
            PlayerAvatar.Parts.ColorTailTip
        };

        private readonly PlayerAvatar.Parts[] StripsAndSpotsPartNames =
        {
           PlayerAvatar.Parts.StripsS, PlayerAvatar.Parts.StripsM, PlayerAvatar.Parts.StripsL,
           PlayerAvatar.Parts.SpotsS, PlayerAvatar.Parts.SpotsM, PlayerAvatar.Parts.SpotsL, PlayerAvatar.Parts.SpotsLe
        };
        // Этот массив содержит названия частей кота, значения которых равны null, при первой загрузке редактора, либо после сброса кнопкой default.;

        private readonly PlayerAvatar.Parts[] ArrayForDefaultFurColorsAndStripsAndSpots = {PlayerAvatar.Parts.ColorBack, PlayerAvatar.Parts.ColorBackFoot, PlayerAvatar.Parts.ColorBreast, PlayerAvatar.Parts.ColorEars,
            PlayerAvatar.Parts.ColorHose, PlayerAvatar.Parts.ColorMain, PlayerAvatar.Parts.ColorSocks, PlayerAvatar.Parts.ColorTail,
            PlayerAvatar.Parts.ColorTailTip, PlayerAvatar.Parts.StripsS, PlayerAvatar.Parts.StripsM, PlayerAvatar.Parts.StripsL,
            PlayerAvatar.Parts.SpotsS, PlayerAvatar.Parts.SpotsM, PlayerAvatar.Parts.SpotsL, PlayerAvatar.Parts.SpotsLe,
            PlayerAvatar.Parts.EyesColor};
        private readonly PlayerAvatar.Parts[] ArrayForDefaultEarsAndNose =  { PlayerAvatar.Parts.Ears, PlayerAvatar.Parts.Nose };


        #endregion

        #endregion Объявление и инициализация полей и свойств

        private void Awake()
        {
            Painter = this;
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
            PlayerAvatar = CatStorage.Instance.Player.PlayerAvatar;
            DrawShapeAndShadow();
            DrawEyesType();
        }

        #region Методы

        public void DrawShapeAndShadow()
        {
            string shapeName = PlayerAvatar[PlayerAvatar.Parts.Shape].ToString();
            string shadowName = PlayerAvatar[PlayerAvatar.Parts.Shadow].ToString();
            CreateAndAssignSprite(shapeName, "Shape");
            CreateAndAssignSprite(shadowName, "Shadow");
            DrawEars();
            DrawNose();
            foreach (PlayerAvatar.Parts e in FurColorPartNames)
            {
                DrawFurColors(e);
            }
            foreach (PlayerAvatar.Parts e in StripsAndSpotsPartNames)
            {
                DrawStripsAndSpots(e);
            }
        }
        public void DrawEyesType()
        {
            string eyesTypeName = "EyesType" + PlayerAvatar[PlayerAvatar.Parts.EyesType];
            CreateAndAssignSprite(eyesTypeName, "EyesType");
            DrawEyesColor();
        }
        public void DrawEyesColor()
        {
            if ((PlayerAvatar.EyesColors)PlayerAvatar[PlayerAvatar.Parts.EyesColor] == PlayerAvatar.EyesColors.None)
            {
                SetBlankSprite("EyesColor");
            }
            else
            {
                string eyesColorName = "EyesColor" + EyesTypeForEyesColorCalculation() + PlayerAvatar[PlayerAvatar.Parts.EyesColor];
                CreateAndAssignSprite(eyesColorName, "EyesColor");
            }
        }
        public void DrawEars()
        {
            if ((PlayerAvatar.EarsAndNoses)PlayerAvatar[PlayerAvatar.Parts.Ears] == PlayerAvatar.EarsAndNoses.None)
            {
                SetBlankSprite("Ears");
            }
            else
            {
                string earsName = "Ears" + PlayerAvatar[PlayerAvatar.Parts.FurryType] + PlayerAvatar[PlayerAvatar.Parts.Ears];
                CreateAndAssignSprite(earsName, "Ears");
            }
        }
        public void DrawNose()
        {
            if ((PlayerAvatar.EarsAndNoses)PlayerAvatar[PlayerAvatar.Parts.Nose] == PlayerAvatar.EarsAndNoses.None)
            {
                SetBlankSprite("Nose");
            }
            else
            {
                string noseName = "Nose" + FaceTypeForNoseCalculation() + PlayerAvatar[PlayerAvatar.Parts.Nose];
                CreateAndAssignSprite(noseName, "Nose");
            }
        }
        public void DrawFurColors(PlayerAvatar.Parts partName)
        {
            if ((PlayerAvatar.FurColorsAndStripsAndSpots)PlayerAvatar[partName] == PlayerAvatar.FurColorsAndStripsAndSpots.None)
            {
                SetBlankSprite(partName);
            }
            else
            {
                string furColorName = partName.ToString() + PlayerAvatar[PlayerAvatar.Parts.FurryType] + FaceTypeForFurColorAndStripsAndSpotsCalculation() + PlayerAvatar[partName];
                CreateAndAssignSprite(furColorName, partName.ToString());
            }
        }
        public void DrawStripsAndSpots(PlayerAvatar.Parts partName)
        {
            if ((PlayerAvatar.FurColorsAndStripsAndSpots)PlayerAvatar[partName] == PlayerAvatar.FurColorsAndStripsAndSpots.None)
            {
                SetBlankSprite(partName);
            }
            else
            {
                string stripsAndSpotsName = partName.ToString() + PlayerAvatar[PlayerAvatar.Parts.FurryType] + FaceTypeForFurColorAndStripsAndSpotsCalculation() + PlayerAvatar[partName];
                CreateAndAssignSprite(stripsAndSpotsName, partName.ToString());
            }
        }
        private void CreateAndAssignSprite(string assetName, string partName)
        {

            TextAsset textAsset = _assets[assetName];
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBGL
            Texture2D tex = new Texture2D(1000, 600, TextureFormat.ARGB32, false);
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
            if ((int)(PlayerAvatar.EyesTypes)PlayerAvatar[PlayerAvatar.Parts.EyesType] < 5)
            {
                return "Angry";
            }
            if ((int)(PlayerAvatar.EyesTypes)PlayerAvatar[PlayerAvatar.Parts.EyesType] > 4 &&
                (int)(PlayerAvatar.EyesTypes)PlayerAvatar[PlayerAvatar.Parts.EyesType] < 9)
            {
                return "Cute";
            }
            if ((int)(PlayerAvatar.EyesTypes)PlayerAvatar[PlayerAvatar.Parts.EyesType] > 8 &&
                (int)(PlayerAvatar.EyesTypes)PlayerAvatar[PlayerAvatar.Parts.EyesType] < 13)
            {
                return "Normal";
            }
            if ((int)(PlayerAvatar.EyesTypes)PlayerAvatar[PlayerAvatar.Parts.EyesType] > 12)
            {
                return "Shy";
            }
            return null;
        }
        private string FaceTypeForNoseCalculation()
        {
            if ((PlayerAvatar.FaceTypes)PlayerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Normal ||
                (PlayerAvatar.FaceTypes) PlayerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Wide)
            {
                return "NormalOrWide";
            }
            return PlayerAvatar[PlayerAvatar.Parts.FaceType].ToString();
        }
        private string FaceTypeForFurColorAndStripsAndSpotsCalculation()
        {
            if ((PlayerAvatar.FaceTypes)PlayerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Normal ||
                (PlayerAvatar.FaceTypes)PlayerAvatar[PlayerAvatar.Parts.FaceType] == PlayerAvatar.FaceTypes.Flat)
            {
                return "NormalOrFlat";
            }
            return PlayerAvatar[PlayerAvatar.Parts.FaceType].ToString();
        }

        #endregion
        public void SetSibling(string partName)
        {
            _stripsAndSpotsRectTransforms[partName].SetAsLastSibling();
        }
        private void SetBlankSprite(string part)
        {
            if (_catPartImages[part].sprite != _blankSprite)
            {
                _catPartImages[part].sprite = _blankSprite;
            }
        }
        private void SetBlankSprite(PlayerAvatar.Parts part)
        {
            if (_catPartImages[part.ToString()].sprite != _blankSprite)
            {
                _catPartImages[part.ToString()].sprite = _blankSprite;
            }
        }
        [UsedImplicitly]
        public void SetDefaultPartState()
        {

            foreach (PlayerAvatar.Parts e in ArrayForDefaultFurColorsAndStripsAndSpots)
            {
                PlayerAvatar[e] = PlayerAvatar.FurColorsAndStripsAndSpots.None;
            }
            foreach (PlayerAvatar.Parts e in ArrayForDefaultEarsAndNose)
            {
                PlayerAvatar[e] = PlayerAvatar.EarsAndNoses.None;
            }
            PlayerAvatar[PlayerAvatar.Parts.FurryType] = PlayerAvatar.FurryTypes.NormalFur;
            PlayerAvatar[PlayerAvatar.Parts.FaceType] = PlayerAvatar.FaceTypes.Normal;
            PlayerAvatar[PlayerAvatar.Parts.EyesType] = PlayerAvatar.EyesTypes.Normal3;
            DrawShapeAndShadow();
            DrawEyesType();
        }
        #endregion
    }
}