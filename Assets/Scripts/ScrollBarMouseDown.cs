using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollBarMouseDown : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public RectTransform rect;

    public void OnPointerDown(PointerEventData eventData)
    {
        GlobalVariables.mouseOnScrollBar = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        GlobalVariables.mouseOnScrollBar = false;
    }
}
