using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Image image;
    public TextAsset imageAsset;
    Sprite spite1;
    Sprite sprite2;

    void Awake()
    {
        Texture2D tex = new Texture2D(1000, 600);
        tex.LoadImage(imageAsset.bytes);
        image.sprite = Sprite.Create(tex, new Rect(0, 0, 1000, 600), new Vector2(0, 0));
    }

}
