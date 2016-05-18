using Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MonoBehaviorInheritors.Panorama
{
    public class EventThrower : MonoBehaviour
    {
        [SerializeField]
        private Camera _camera;
        private RectTransform _rawImage;
        private Ray _ray;
        private Vector2 _coordinatesInRawImage;

        public Camera Camera
        {
            get
            {
                return _camera;
            }

            set
            {
                _camera = value;
            }
        }

        private void Awake()
        {
            _rawImage = GetComponent<RectTransform>();
        }

        public void ThrowOnMouseDown(BaseEventData baseEventData)
        {
            PointerEventData pointerEventData = (PointerEventData) baseEventData;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_rawImage, pointerEventData.position, null, out _coordinatesInRawImage);
            float x = _coordinatesInRawImage.x / _rawImage.sizeDelta.x * Camera.pixelWidth;
            float y = _coordinatesInRawImage.y / _rawImage.sizeDelta.y * Camera.pixelHeight;
            _ray = Camera.ScreenPointToRay(new Vector3(x, y, 0));
            RaycastHit2D hit = Physics2D.Raycast(_ray.origin, _ray.direction, 1000f);

            if (hit.collider != null && pointerEventData.button == PointerEventData.InputButton.Left)
            {
                hit.collider.GetComponent<IInterectable>().LeftMouseButtonClick();
            }
        }

        private void Update()
        {
            Debug.DrawRay(_ray.origin, _ray.direction * 1000, Color.red);
        }
    }
}
