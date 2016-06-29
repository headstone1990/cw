using UnityEngine;
using System.Collections;

public class BorderMover : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _leftBorder;
    [SerializeField] private Transform _rightBorder;

    void Start()
    {
        _leftBorder.position = new Vector3(_camera.ScreenToWorldPoint(new Vector2(0, 0)).x, _leftBorder.position.y);
        _rightBorder.position = new Vector3(_camera.ScreenToWorldPoint(new Vector2(_camera.pixelWidth, 0)).x, _rightBorder.position.y);
    }
}
