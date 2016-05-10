using UnityEngine;

namespace MonoBehaviorInheritors.Main
{
    public class PanoramaScrollController : MonoBehaviour
    {
        [SerializeField] private float _speedMultiplier = 3f;
        [SerializeField] private float _speed;
        [SerializeField] private Transform _staticSprite;
        [SerializeField] private Transform _dynamicSprite;
        private Transform _camera;
        private bool _isChildOfDynamicSprite = false;

        private float _leftPosition; // = -3840f;
        private float _rightPosition; // = 3840f;

        public Transform StaticSprite
        {
            get
            {
                return _staticSprite;
            }

            set
            {
                _staticSprite = value;
            }
        }
        public Transform DynamicSprite
        {
            get
            {
                return _dynamicSprite;
            }

            set
            {
                _dynamicSprite = value;
            }
        }

        private void Awake()
        {
            _camera = transform;
            _leftPosition = -_staticSprite.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
            _rightPosition = _staticSprite.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        }
        private void Update()
        {
            if (Input.GetButtonDown("Speed Up"))
            {
                _speed = _speed*_speedMultiplier;
            }
            if (Input.GetButtonUp("Speed Up"))
            {
                _speed = _speed / _speedMultiplier;
            }
            _camera.Translate(Input.GetAxis("Horizontal")*_speed*Time.deltaTime, 0, 0);
            if (!_isChildOfDynamicSprite)
            {
                if (_camera.localPosition.x < 0)
                {
                    _dynamicSprite.position = new Vector3(_leftPosition, _dynamicSprite.position.y);
                }
                else if (_camera.localPosition.x > 0)
                {
                    _dynamicSprite.position = new Vector3(_rightPosition, _dynamicSprite.position.y);
                }
                if (_camera.localPosition.x < _leftPosition / 2 || _camera.position.x > _rightPosition/2)
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
                    _dynamicSprite.position = new Vector3(_leftPosition, _dynamicSprite.position.y);
                }
                else if (_camera.localPosition.x < 0)
                {
                    _dynamicSprite.position = new Vector3(_rightPosition, _dynamicSprite.position.y);
                }
                if (_camera.localPosition.x < _leftPosition/2 || _camera.localPosition.x > _rightPosition/2)
                {
                    _camera.SetParent(_staticSprite, true);
                    _isChildOfDynamicSprite = false;
                }
            }
        }
    }
}
