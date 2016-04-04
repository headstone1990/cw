using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.AfterCatEditor
{
    public class BackgroundChanger : MonoBehaviour
    {
        [SerializeField] private  Sprite[] _backgroundSprites = null; //Set in inspector
        [SerializeField] private  Image _backgroundImage = null; //Set in inspector
        private int _currentSpriteIndex;

        private void Awake()
        {
            _backgroundImage.sprite = _backgroundSprites[0];
            _currentSpriteIndex = 0;
        }

        [UsedImplicitly]
        public void ScrollRight()
        {
            if (_currentSpriteIndex == _backgroundSprites.Length - 1)
            {
                _currentSpriteIndex = -1;
            }
            _currentSpriteIndex++;
            _backgroundImage.sprite = _backgroundSprites[_currentSpriteIndex];
        }

        [UsedImplicitly]
        public void ScrollLeft()
        {
            if (_currentSpriteIndex == 0)
            {
                _currentSpriteIndex = _backgroundSprites.Length;
            }
            _currentSpriteIndex--;
            _backgroundImage.sprite = _backgroundSprites[_currentSpriteIndex];
        }
    }
}
