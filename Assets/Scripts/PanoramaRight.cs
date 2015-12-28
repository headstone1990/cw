using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PanoramaRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool pressed = false;
    public PanoramaControler pC;


    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }


    void Update () {

        {
      

            if (pressed)
            pC.Right();
        }
	
	}
}
