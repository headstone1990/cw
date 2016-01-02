using UnityEngine;
using UnityEngine.UI;

public class PanoramaScrollSpeed : MonoBehaviour
{

    public PanoramaControler pC;
    // GameObject go;
    Slider slider;

    void Awake()
    {
        //go = GameObject.Find("PanoramaScript");
        //pC = go.GetComponent("PanoramaController") as PanoramaControler;
        slider = GetComponent("Slider") as Slider;
    }



    public void Speed()
    {
        pC.speed = slider.value;
    }

}
