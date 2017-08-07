using System.Collections.Generic;
using CW.Frontend.CustomUIElements.Enums;
using UnityEngine;

namespace CW.Frontend.CustomUIElements
{
    public class KeyboardAndMouseDetector : MonoBehaviour
    {
        private Scroller _scroller;

        private void Awake()
        {
            _scroller = FindObjectOfType<Scroller>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetAxis("Mouse ScrollWheel") >= 0.1f)
            {
                _scroller.Movements.Enqueue(Movement.Left);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetAxis("Mouse ScrollWheel") <= -0.1f)
            {
                _scroller.Movements.Enqueue(Movement.Right);
            }
        }
    }
}