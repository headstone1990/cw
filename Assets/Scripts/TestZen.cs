using UnityEngine;
using Zenject;

public class TestZen : ITickable
{
    public void Tick()
    {
        Debug.Log("test");
    }
}
