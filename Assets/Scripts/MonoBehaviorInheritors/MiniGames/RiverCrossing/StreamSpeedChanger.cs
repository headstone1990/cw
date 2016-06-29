using UnityEngine;

namespace MonoBehaviorInheritors.MiniGames.RiverCrossing
{
    public class StreamSpeedChanger : MonoBehaviour
    {
        [SerializeField]
        [Range(-1.0f, 1.0f)]
        private float _streamSpeed;

        public void Awake()
        {
            GameController.StreamSpeed = _streamSpeed;
        }
    }
}