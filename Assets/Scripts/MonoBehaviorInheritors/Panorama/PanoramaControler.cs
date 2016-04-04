using UnityEngine;

namespace MonoBehaviorInheritors.Panorama
{
    public class PanoramaControler : MonoBehaviour
    {
        [SerializeField]
        private GameObject _prefab;
        [SerializeField]
        private GameObject _currentImage;
        [SerializeField]
        private RectTransform _mask;
        [SerializeField]
        private float _speed;
        private GameObject _leftImage;
        private GameObject _rightImage;
        float _defaultSpeed;

        public float Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }
        void Awake()
        {
            _defaultSpeed = _speed;
        }
        void Update()
        {
            SpeedUp();

            if (Input.GetKey("a") || Input.GetKey("left"))
            {
                Left();

            }
            else if (Input.GetKey("d") || Input.GetKey("right"))
            {
                Right();

            }
        }
        public void SpeedUp ()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                _defaultSpeed = _speed;
                _speed = _speed * 3;
            }

            else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
            {
                _speed = _defaultSpeed;
            }

            //else
            //{
            //    speed = defaultSpeed;
            // }



        }
        void LateUpdate()
        {
            if(_currentImage.GetComponent<RectTransform>().anchoredPosition.x > -100f && _leftImage == null)
            {
                _leftImage = Instantiate(_prefab);
                _leftImage.GetComponent<RectTransform>().SetParent(_mask, false);
                _leftImage.GetComponent<RectTransform>().anchoredPosition = _currentImage.GetComponent<RectTransform>().anchoredPosition - new Vector2(5376f, 0f);
            }
            if (_currentImage.GetComponent<RectTransform>().anchoredPosition.x < -3932f && _rightImage == null)
            {
                _rightImage = Instantiate(_prefab);
                _rightImage.GetComponent<RectTransform>().SetParent(_mask, false);
                _rightImage.GetComponent<RectTransform>().anchoredPosition = _currentImage.GetComponent<RectTransform>().anchoredPosition - new Vector2(-5376f, 0f);
            }

            if (_currentImage.GetComponent<RectTransform>().anchoredPosition.x > 1444)
            {
                _rightImage = _currentImage;
                _currentImage = _leftImage;
                _leftImage = null;
            }

            if (_currentImage.GetComponent<RectTransform>().anchoredPosition.x < -5475)
            {
                _leftImage = _currentImage;
                _currentImage = _rightImage;
                _rightImage = null;
            }

            if (_rightImage != null && _rightImage.GetComponent<RectTransform>().anchoredPosition.x >= 5376)
            {
                Destroy(_rightImage);
            }

            if (_leftImage != null && _leftImage.GetComponent<RectTransform>().anchoredPosition.x <= -5376)
            {
                Destroy(_leftImage);
            }

        }
        public void Left()
        {
            _currentImage.GetComponent<RectTransform>().anchoredPosition += new Vector2(1f, 0f) * Time.deltaTime * _speed;
            if(_leftImage != null)
            {
                _leftImage.GetComponent<RectTransform>().anchoredPosition += new Vector2(1f, 0f) * Time.deltaTime * _speed;
            }
            if(_rightImage != null)
            {
                _rightImage.GetComponent<RectTransform>().anchoredPosition += new Vector2(1f, 0f) * Time.deltaTime * _speed;
            }
        }
        public void Right()
        {
            _currentImage.GetComponent<RectTransform>().anchoredPosition -= new Vector2(1f, 0f) * Time.deltaTime * _speed;
            if (_leftImage != null)
            {
                _leftImage.GetComponent<RectTransform>().anchoredPosition -= new Vector2(1f, 0f) * Time.deltaTime * _speed;
            }
            if (_rightImage != null)
            {
                _rightImage.GetComponent<RectTransform>().anchoredPosition -= new Vector2(1f, 0f) * Time.deltaTime * _speed;
            }

        }
    }
}
