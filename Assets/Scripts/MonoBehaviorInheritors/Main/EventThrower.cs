using System.Collections;
using Interfaces;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;


namespace MonoBehaviorInheritors.Main
{
    public class EventThrower : MonoBehaviour
    {
        public Camera Camera { private get; set; }

#pragma warning disable 649
        [SerializeField] private RectTransform _rawImage;
#pragma warning restore 649

        private Ray _ray;
        private Vector2 _coordinatesInRawImage;
        private IInteractable _currentSelectedObject;
        private bool _mouseOnViewport;

        [UsedImplicitly]
        public void ThrowOnMouseDown(BaseEventData baseEventData)
        {
            var pointerEventData = (PointerEventData) baseEventData;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_rawImage, pointerEventData.position, null,
                out _coordinatesInRawImage);
            var x = _coordinatesInRawImage.x/_rawImage.sizeDelta.x*Camera.pixelWidth;
            var y = _coordinatesInRawImage.y/_rawImage.sizeDelta.y*Camera.pixelHeight;
            _ray = Camera.ScreenPointToRay(new Vector3(x, y, 0));
            var hit = Physics2D.Raycast(_ray.origin, _ray.direction, 1000f);

            if (hit.collider != null && pointerEventData.button == PointerEventData.InputButton.Left &&
                hit.collider.GetComponent<IInteractable>() != null)
            {
                hit.collider.GetComponent<IInteractable>().OnLeftMouseButtonClick();
            }
        }

        [UsedImplicitly]
        public void ThrowOnMouseEnter()
        {
            _mouseOnViewport = true;
            StartCoroutine(OnMouseEnterViewport());
        }

        [UsedImplicitly]
        public void ThrowOnMouseExit()
        {
            _mouseOnViewport = false;
        }


        private IEnumerator OnMouseEnterViewport()
        {
            while (_mouseOnViewport)
            {
                RectTransformUtility.ScreenPointToLocalPointInRectangle(_rawImage, Input.mousePosition, null,
                    out _coordinatesInRawImage);
                var x = _coordinatesInRawImage.x/_rawImage.sizeDelta.x*Camera.pixelWidth;
                var y = _coordinatesInRawImage.y/_rawImage.sizeDelta.y*Camera.pixelHeight;
                _ray = Camera.ScreenPointToRay(new Vector3(x, y, 0));
                var hit = Physics2D.Raycast(_ray.origin, _ray.direction, 1000f);
                if (hit.collider != null)
                {
                    if (_currentSelectedObject == null)
                    {
                        if (hit.collider.GetComponent<IInteractable>() != null)
                        {
                            _currentSelectedObject = hit.collider.GetComponent<IInteractable>();
                            _currentSelectedObject.OnMouseEnter();
                        }
                    }
                }
                else
                {
                    if (_currentSelectedObject != null)
                    {
                        _currentSelectedObject.OnMouseExit();
                        _currentSelectedObject = null;
                    }
                }
                yield return null;
            }
        }


        private void Update()
        {
            Debug.DrawRay(_ray.origin, _ray.direction*100, Color.red);
        }
    }
}
