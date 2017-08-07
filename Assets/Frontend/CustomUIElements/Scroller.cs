using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using CW.Frontend.CustomUIElements.Enums;

namespace CW.Frontend.CustomUIElements
{
    public class Scroller : MonoBehaviour
    {
        public RectTransform Content;
        private bool _isMoving;
        private Queue<Movement> _movements;
        private float _lastFixedPosition;

        void Start()
        {
            _movements = new Queue<Movement>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetAxis("Mouse ScrollWheel") >= 0.1f)
            {
                _movements.Enqueue(Movement.Left);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetAxis("Mouse ScrollWheel") <= -0.1f)
            {
                _movements.Enqueue(Movement.Right);
            }
            if (_isMoving || !_movements.Any()) return;
            var movement = _movements.Dequeue();
            if (Content.anchoredPosition.x >= 0 && movement == Movement.Left
                || Content.anchoredPosition.x <= -3630 && movement == Movement.Right
            )
            {
                return;
            }
            _isMoving = true;
            StartCoroutine(LerpContent(movement));
        }

        private IEnumerator LerpContent(Movement movement)
        {
            float timeOfTravel = 0.2f;
            float currentTime = 0f;
            Vector2 startPosition = new Vector2(_lastFixedPosition, Content.anchoredPosition.y);
            var endPosition = movement == Movement.Right
                ? new Vector2(_lastFixedPosition - 605.0f, Content.anchoredPosition.y)
                : new Vector2(_lastFixedPosition + 605.0f, Content.anchoredPosition.y);
            while (currentTime <= timeOfTravel)
            {
                currentTime += Time.deltaTime;
                var normalizedValue = currentTime / timeOfTravel;

                Content.anchoredPosition = Vector3.Lerp(startPosition, endPosition, normalizedValue);
                yield return null;
            }
            Content.anchoredPosition = endPosition;
            _lastFixedPosition = endPosition.x;
            _isMoving = false;
        }
    }
}
