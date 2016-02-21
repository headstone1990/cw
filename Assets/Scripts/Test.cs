﻿using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Image Image;

    public TextAsset ImageAsset1;
    public TextAsset ImageAsset2;
    Sprite _spite1;

    private void Awake()
    {
        Texture2D tex = new Texture2D(1000, 600, TextureFormat.ARGB32, false);
        tex.LoadImage(ImageAsset1.bytes, false);
        Color[] pix = tex.GetPixels(0, 0, 1000, 600);
        Texture2D tex2 = new Texture2D(1000, 600, TextureFormat.ARGB32, false);
        tex2.LoadImage(ImageAsset2.bytes, false);
        Color[] pix2 = tex2.GetPixels(0, 0, 1000, 600);
        Color[] pixResult = new Color[pix.Length];


        for (int i = 0; i < pix.Length; i++)
        {
            pixResult[i] = AlphaBlend(pix2[i], pix[i]);
        }

        Texture2D result = new Texture2D(1000, 600, TextureFormat.ARGB32, false);
        result.SetPixels(pixResult);
        result.Apply();


        //var c = ImageAsset1.bytes.Concat(ImageAsset2.bytes).ToArray();
        //tex.LoadRawTextureData(c);
        _spite1 = Sprite.Create(result, new Rect(0, 0, 1000, 600), new Vector2(0, 0));
        Image.sprite = _spite1;

        

    }

    float BlendSubpixel(float top, float bottom, float alphaTop, float alphaBottom)
    {
        return (top*alphaTop + bottom*alphaBottom*(1 - alphaTop))/(alphaTop + alphaBottom*(1 - alphaTop));
    }

    Color AlphaBlend(Color top, Color bottom)
    {
        return new Color(BlendSubpixel(top.r, bottom.r ,top.a, bottom.a), BlendSubpixel(top.g, bottom.g, top.a, bottom.a), BlendSubpixel(top.b, bottom.b, top.a, bottom.a), top.a + bottom.a * (1 - top.a));
    }

}
