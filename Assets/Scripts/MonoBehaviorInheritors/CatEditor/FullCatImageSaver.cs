using System.Collections.Generic;
using System.Linq;
using MonoBehaviorInheritors.Main;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.CatEditor
{
    using CW.Backend;

    public class FullCatImageSaver : MonoBehaviour
    {
        [SerializeField] private Sprite _blank = null;
        [SerializeField] private RectTransform _catParts1 = null;
        [SerializeField] private RectTransform _catParts2 = null;
        private List<Image> _partsImages = new List<Image>();
        private List<Texture2D> _partsTextures = new List<Texture2D>();
        private Dictionary<string, RectTransform> _stripsAndSpotsRectTransforms;
        private readonly PlayerAvatar.Parts[] StripsAndSpotsPartNames =
        {
            PlayerAvatar.Parts.StripsS, PlayerAvatar.Parts.StripsM, PlayerAvatar.Parts.StripsL,
            PlayerAvatar.Parts.SpotsS, PlayerAvatar.Parts.SpotsM, PlayerAvatar.Parts.SpotsL, PlayerAvatar.Parts.SpotsLe
        };


        private void Start()
        {
            _stripsAndSpotsRectTransforms = CatPainter.Painter.StripsAndSpotsRectTransforms;
            //Profiler.maxNumberOfSamplesPerFrame = 8388608;
        }
        public void SaveCatImage()
        {
            CatStorage.Instance.Player.Avatar = BlendImages();
            SaveSibling();
        }
        private Texture2D BlendImages()
        {
            FillPartImagesAndTexturesLists();
            Color newColor = new Color();
            Color[] lowerPixels = _partsTextures[0].GetPixels();
            Color[] resultPixels = new Color[lowerPixels.Length];
            Color[] topPixels = new Color[lowerPixels.Length];
            for (int i = 0; i < _partsTextures.Count - 1; i++)
            {
                topPixels = _partsTextures[i + 1].GetPixels();
                for (int j = 0; j < resultPixels.Length; j++)
                {
                    newColor.r = (topPixels[j].r*topPixels[j].a + lowerPixels[j].r*lowerPixels[j].a*(1 - topPixels[j].a))/
                                 (topPixels[j].a + lowerPixels[j].a*(1 - topPixels[j].a));
                    newColor.g = (topPixels[j].g * topPixels[j].a + lowerPixels[j].g * lowerPixels[j].a * (1 - topPixels[j].a)) /
                                 (topPixels[j].a + lowerPixels[j].a * (1 - topPixels[j].a));
                    newColor.b = (topPixels[j].b * topPixels[j].a + lowerPixels[j].b * lowerPixels[j].a * (1 - topPixels[j].a)) /
                                 (topPixels[j].a + lowerPixels[j].a * (1 - topPixels[j].a));
                    newColor.a = topPixels[j].a + lowerPixels[j].a * (1 - topPixels[j].a);
                    resultPixels[j] = newColor;
                }
                lowerPixels = resultPixels;
            }
            Texture2D result = new Texture2D(1000, 600, TextureFormat.ARGB32, false);
            result.SetPixels(resultPixels);
            result.Apply();
            return result;
        }
        private void FillPartImagesAndTexturesLists()
        {
            foreach (Transform child in _catParts1)
            {
                _partsImages.Add(child.gameObject.GetComponent<Image>());
            }
            foreach (Transform child in _catParts2)
            {
                _partsImages.Add(child.gameObject.GetComponent<Image>());
            }
            foreach (var partsImage in _partsImages.Where(partsImage => partsImage.sprite != _blank))
            {
                _partsTextures.Add((Texture2D)partsImage.mainTexture);
            }
        }
        private static float BlendSubpixel(float top, float bottom, float alphaTop, float alphaBottom)
        {
            return (top * alphaTop + bottom * alphaBottom * (1 - alphaTop)) / (alphaTop + alphaBottom * (1 - alphaTop));
        }
        private static Color PerPixelBlendWithAlpha(Color top, Color bottom)
        {
            return new Color(BlendSubpixel(top.r, bottom.r, top.a, bottom.a), BlendSubpixel(top.g, bottom.g, top.a, bottom.a), BlendSubpixel(top.b, bottom.b, top.a, bottom.a), top.a + bottom.a * (1 - top.a));
        }
        private void SaveSibling()
        {
            foreach (var e in StripsAndSpotsPartNames)
            {
                CatStorage.Instance.Player.PlayerAvatar.Sibling[e] = _stripsAndSpotsRectTransforms[e.ToString()].GetSiblingIndex();
            }
        }

    }
}
