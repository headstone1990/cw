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
        private float _lastFixedPosition;
        public Queue<Movement> Movements { get; private set; }
        
        void Start()
        {
            Movements = new Queue<Movement>();
        }

        private void Update()
        {
            MoveContent();
        }

        private void MoveContent()
        {
            if (_isMoving || !Movements.Any()) return;
            var movement = Movements.Dequeue();
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
