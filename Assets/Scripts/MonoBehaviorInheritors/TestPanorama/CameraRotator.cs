using UnityEngine;
using System.Collections;

public class CameraRotator : MonoBehaviour
{
    private Transform _camera;
    [SerializeField]
    private float _rotationSpeed = 10.0f;

	void Awake ()
	{
	    _camera = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonDown("Speed Up"))
	    {
	        _rotationSpeed = _rotationSpeed * 2;
	    }
	    if (Input.GetButtonUp("Speed Up"))
	    {
            _rotationSpeed = _rotationSpeed / 2;
        }
        float rotation = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
	    _camera.Rotate(Vector3.up, rotation);
    }
}
