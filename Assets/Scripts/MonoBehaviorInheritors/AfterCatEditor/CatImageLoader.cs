using MonoBehaviorInheritors.Main;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.AfterCatEditor
{
    public class CatImageLoader : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Image>().sprite = Sprite.Create(CatStorage.Instance.Player.Avatar, new Rect(0, 0, 1000, 600), new Vector2(0.5f, 0.5f));
        }
    }
}
