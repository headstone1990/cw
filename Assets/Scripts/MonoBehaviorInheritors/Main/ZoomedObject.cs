using Interfaces;
using UnityEngine;
using System.Collections;

namespace MonoBehaviorInheritors.Main
{
    public class ZoomedObject : MonoBehaviour, IInteractable
    {
        [SerializeField] private Vector3 _targetCameraPosition;
        [SerializeField] private float _targetCameraSize;
        [SerializeField] private float _totalLerpingTime;

        private Transform _cameraTransform;
        private Camera _camera;


        private void Start()
        {
            _cameraTransform = LocationsController.Camera.transform;
            _camera = LocationsController.Camera.GetComponent<Camera>();
        }

        
        public void OnLeftMouseButtonClick()
        {
            Debug.Log("Clicked on the item");
            StartCoroutine(OnCameraZoom());
        }

        public void OnMouseEnter()
        {
            Debug.Log("Cursor on item");
        }

        public void OnMouseExit()
        {
            Debug.Log("Cursor exit item");
        }

        private IEnumerator OnCameraZoom()
        {
            float timeStartedLerping = Time.time;
            _cameraTransform.GetComponent<PanoramaScrollController>().enabled = false;
            _cameraTransform.SetParent(transform, true);
            Vector3 startPoint = _cameraTransform.localPosition;
            float startCameraSize = _camera.orthographicSize;
            float persentageComplete = 0f;
            while (persentageComplete < 1.0f)
            {
                float timeSinceStarted = Time.time - timeStartedLerping;
                persentageComplete = timeSinceStarted / _totalLerpingTime;
                _cameraTransform.localPosition = Vector3.Lerp(startPoint, _targetCameraPosition, persentageComplete);
                _camera.orthographicSize = Mathf.Lerp(startCameraSize, _targetCameraSize,
                persentageComplete);

                yield return null;
            }
        }
    }
}