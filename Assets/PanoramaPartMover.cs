using UnityEngine;
using System.Collections;

public class PanoramaPartMover : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    public Transform _camera;
    public Transform _staticSprite;
    public Transform _dynamicSprite;
    public float Distance;

    private Vector3 _startPos;

	// Use this for initialization
	void Start ()
	{
	    _startPos = _staticSprite.position;
	}

	// Update is called once per frame
	void Update ()
	{
        /*
        float dirX = _camera.position.x - _staticSprite.position.x;

        _dynamicSprite.position = new Vector3(Mathf.Sign(dirX) * Distance, _dynamicSprite.position.y, _dynamicSprite.position.z);

        if (Mathf.Abs(dirX) > Distance)
            _staticSprite.position = new Vector3(Mathf.Sign(dirX) * Distance * 2, _staticSprite.position.y, _staticSprite.position.z);

        float camDistance = Distance*2;
        float camPosX = (dirX / camDistance - (int)(dirX / camDistance)) * camDistance;
	    _camera.position = new Vector3(camPosX, _camera.position.y,_camera.position.z);

        _camera.Translate(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, 0);
        */
        float dirX = _camera.position.x - _startPos.x;

        int camCell = (int)(dirX / Distance);
	    float innerPos = dirX / Distance - camCell * Distance;

	    if (camCell % 2 == 0)
	    {
	        if (innerPos < 0.5f)
	        {
	            _staticSprite.position = new Vector3(camCell*Distance ,_startPos.y, _startPos.z);
                _dynamicSprite.position = new Vector3((camCell-1)*Distance ,_startPos.y, _startPos.z);
	        }
	        else
	        {
                _staticSprite.position = new Vector3(camCell * Distance, _startPos.y, _startPos.z);
                _dynamicSprite.position = new Vector3((camCell + 1) * Distance, _startPos.y, _startPos.z);
            }
	    }
	    else
	    {

	    }
	}
}
