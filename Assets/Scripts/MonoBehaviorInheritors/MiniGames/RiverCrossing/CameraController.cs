using UnityEngine;

namespace MonoBehaviorInheritors.MiniGames.RiverCrossing
{
    public class CameraController : MonoBehaviour
    {
        private const float _cameraOffset = 3f;
        private Transform _camera;
        [SerializeField]
        private Transform _player;

        private void Awake()
        {
            _camera = GetComponent<Transform>();
        }

        private void Update()
        {
            _camera.position = new Vector3(0, _player.position.y + _cameraOffset, -10);
        }
    }
}