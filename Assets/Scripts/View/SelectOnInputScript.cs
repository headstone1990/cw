namespace CW.View
{
    using System;

    using UnityEngine;
    using UnityEngine.EventSystems;

    public class SelectOnInputScript : MonoBehaviour
    {
        [SerializeField]
        private GameObject defaultSelectedGameObject;

        private void LateUpdate()
        {
            if (EventSystem.current.currentSelectedGameObject != null) return;

            if (Math.Abs(Input.GetAxisRaw("Vertical")) > 0.01f || Math.Abs(Input.GetAxisRaw("Horizontal")) > 0.01f)
            {
                EventSystem.current.SetSelectedGameObject(defaultSelectedGameObject);
            }
        }
    }
}