using Interfaces;
using UnityEngine;

namespace MonoBehaviorInheritors.Panorama
{
    public class FeatherTest : MonoBehaviour, IInterectable
    {
        public void LeftMouseButtonClick()
        {
            Debug.Log("Clicked on the feather");
        }
    }
}