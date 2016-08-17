namespace CW.Frontend.Main
{
    using UnityEngine;

    public class PngLoader : MonoBehaviour
    {
        [SerializeField]
        private TextAsset _image = null; // Set in inspector

        private void Awake()
        {
            LoadPng(_image);
        }

        private void LoadPng(TextAsset image)
        {
            GetPNGTextureSize(image.bytes);            
        }

        private TextureSize GetPNGTextureSize(byte[] bytes)
        {
            float width = -1.0f;
            float height = -1.0f;
            byte[] pngSignature = { 137, 80, 78, 71, 13, 10, 26, 10 };
            const int MinDownloadedBytes = 30;
            byte[] buf = bytes;
            if (buf.Length > MinDownloadedBytes)
            {
                for (int i = 0; i < pngSignature.Length; i++)
                {
                    if (buf[i] != pngSignature[i])
                    {
                        Debug.LogWarning("Error! Texture as NOT png format!");                        
                    }
                }

                width = buf[16] << 24 | buf[17] << 16 | buf[18] << 8 | buf[19];
                height = buf[20] << 24 | buf[21] << 16 | buf[22] << 8 | buf[23];
            }

            return new TextureSize(width, height);
        }

        public struct TextureSize
        {
            public float Width;
            public float Height;

            public TextureSize(float width, float height)
            {
                Width = width;
                Height = height;
            }
        }
    }
}