using UnityEngine;

namespace MonoBehaviorInheritors.MiniGames.RiverCrossing
{
    public class GameController : MonoBehaviour
    {
        public static bool IsLoose { get; set; }
        [SerializeField]
        private Camera _camera;
        [SerializeField]
        private Transform _leftBorder;
        [SerializeField]
        private Transform _rightBorder;

        [SerializeField] private GameObject _player;

        private static float _borderXcoordinate;



        public static float StreamSpeed { get; set; }

        public static float BorderXcoordinate
        {
            get
            {
                return _borderXcoordinate;
            }

            set
            {
                _borderXcoordinate = value;
            }
        }

        private void Awake()
        {
            IsLoose = false;
            float strongStreamBorderOffset = _leftBorder.GetComponent<BoxCollider2D>().bounds.extents.x + _player.GetComponent<SpriteRenderer>().bounds.size.x;
            if (StreamSpeed >= 0)
            {
                _rightBorder.tag = "LooseBorder";
                _leftBorder.tag = "StrongStreamBorder";
                PlayerController.StrongStreamBorder = _leftBorder;
                _rightBorder.position = new Vector3(_camera.ScreenToWorldPoint(new Vector2(_camera.pixelWidth, 0)).x + strongStreamBorderOffset, _rightBorder.position.y);

            }
            else
            {
                _rightBorder.tag = "StrongStreamBorder";
                _leftBorder.tag = "LooseBorder";
                PlayerController.StrongStreamBorder = _rightBorder;
                _leftBorder.position = new Vector3(_camera.ScreenToWorldPoint(new Vector2(0, 0)).x - strongStreamBorderOffset, _leftBorder.position.y);
            }
            _borderXcoordinate = _camera.ScreenToWorldPoint(new Vector2(_camera.pixelWidth, 0)).x;
        }


        private void Update()
        {
            if (IsLoose)
            {
                Debug.Break();
                Debug.Log("You fail");
            }
        }
    }
}
