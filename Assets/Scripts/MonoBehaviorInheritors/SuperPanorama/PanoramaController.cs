using UnityEngine;

namespace MonoBehaviorInheritors.SuperPanorama
{
    public class PanoramaController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Transform _camera;
        [SerializeField] private Transform _staticSprite;
        [SerializeField] private Transform _dynamicSprite;

        private bool _isChildOfDynamicSprite = false;

        private const float LeftPosition = -3840f;
        private const float RightPosition = 3840f;


        void Update()
        {
            _camera.Translate(Input.GetAxis("Horizontal")*_speed*Time.deltaTime, 0, 0);
            if (!_isChildOfDynamicSprite)
            {
                if (_camera.localPosition.x < 0)
                {
                    _dynamicSprite.position = new Vector3(LeftPosition, _dynamicSprite.position.y);
                }
                else if (_camera.localPosition.x > 0)
                {
                    _dynamicSprite.position = new Vector3(RightPosition, _dynamicSprite.position.y);
                }
                if (_camera.localPosition.x < LeftPosition / 2 || _camera.position.x > RightPosition/2)
                {
                    _camera.SetParent(_dynamicSprite, true);
                    _isChildOfDynamicSprite = true;
                }
                else
                {
                    return;
                }
            }
            if (_isChildOfDynamicSprite)
            {
                if (_camera.localPosition.x > 0)
                {
                    _dynamicSprite.position = new Vector3(LeftPosition, _dynamicSprite.position.y);
                }
                else if (_camera.localPosition.x < 0)
                {
                    _dynamicSprite.position = new Vector3(RightPosition, _dynamicSprite.position.y);
                }
                if (_camera.localPosition.x < LeftPosition/2 || _camera.localPosition.x > RightPosition/2)
                {
                    _camera.SetParent(_staticSprite, true);
                    _isChildOfDynamicSprite = false;
                }
            }
        }
    }
}
