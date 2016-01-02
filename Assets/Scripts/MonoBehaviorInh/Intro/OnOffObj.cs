using UnityEngine;
using System.Collections;

public class OnOffObj : MonoBehaviour
{
    public GameObject[] enable;
    public GameObject[] disable;
    void OnEnable()
    {
        foreach(GameObject g in disable)
        {
            g.SetActive(false);
        }
        foreach(GameObject g in enable)
        {
            g.SetActive(true);
        }
    }
}