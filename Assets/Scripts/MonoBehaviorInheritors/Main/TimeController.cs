using UnityEngine;
using System.Collections;
using DefaultNamespace;

public class TimeController : MonoBehaviour
{
    private IngameTime _ingameTime = new IngameTime();

    private void Start()
    {
        _ingameTime.AddTime(2000);
        Debug.Log(_ingameTime.ShowTime());
    }
}
