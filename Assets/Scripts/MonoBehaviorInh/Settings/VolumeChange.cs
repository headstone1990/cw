using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour {

    GameObject[] musics;
    GameObject[] fxs;
    Slider slider;


    public void MusicVolumeChange()
    {
        slider = GetComponent<Slider>();
        musics = GameObject.FindGameObjectsWithTag("Music");
        foreach (GameObject music in musics)
        {
            AudioSource audio;
            audio = music.GetComponent<AudioSource>();
            audio.volume = slider.value;
        }
        GlobalVariables.musicVolume = slider.value;

    }

    public void FxVolumeChange()
    {
        slider = GetComponent<Slider>();
        fxs = GameObject.FindGameObjectsWithTag("Fx");
        foreach (GameObject fx in fxs)
        {
            AudioSource audio;
            audio = fx.GetComponent<AudioSource>();
            audio.volume = slider.value;
        }
        GlobalVariables.fxVolume = slider.value;

    }
}
