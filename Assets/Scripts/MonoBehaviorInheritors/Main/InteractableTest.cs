using Interfaces;
using UnityEngine;

namespace MonoBehaviorInheritors.Panorama
{
    public class InteractableTest : MonoBehaviour, IInteractable
    {
        public void OnLeftMouseButtonClick()
        {
            Debug.Log("Clicked on the item");
        }

        public void OnMouseEnter()
        {
            Debug.Log("Cursor on item");
        }

        public void OnMouseExit()
        {
            Debug.Log("Cursor exit item");
        }
    }
}