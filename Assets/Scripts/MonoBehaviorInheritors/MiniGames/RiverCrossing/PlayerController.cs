using System;
using System.Collections;
using MonoBehaviorInheritors.MiniGames.RiverCrossing.Obstacles;
using UnityEngine;

namespace MonoBehaviorInheritors.MiniGames.RiverCrossing
{
    public class PlayerController : MonoBehaviour
    {
        private enum State
        {
            Default,
            BouncingOfBorder,
            MoveViaObstacle
        }

        private static Transform _strongStreamBorder;

        private Rigidbody2D _player;
        private float _horizontalSpeed;
        private float _borderColliderWidth;
        private State _currentState;

        [SerializeField]
        private float _horizontalSpeedMultiplier = 2;
        [SerializeField]
        private float _verticalSpeed = 0.5f;


        public static Transform StrongStreamBorder
        {
            private get { return _strongStreamBorder; }
            set { _strongStreamBorder = value; }
        }


        private void Awake()
        {
            _player = GetComponent<Rigidbody2D>();
            _currentState = State.Default;
        }

        private void Start()
        {
            _borderColliderWidth = _strongStreamBorder.GetComponent<BoxCollider2D>().bounds.extents.x +
                      _player.GetComponent<SpriteRenderer>().bounds.extents.x;
        }

        private void FixedUpdate()
        {
            switch (_currentState)
            {
                case State.Default:
                    _horizontalSpeed = Input.GetAxis("Horizontal");
                    _player.AddForce(new Vector2(_horizontalSpeed * _horizontalSpeedMultiplier, 0));
                    _player.AddForce(new Vector2(GameController.StreamSpeed * _horizontalSpeedMultiplier, 0));
                    _player.velocity = new Vector2(_player.velocity.x, _verticalSpeed);
                    break;
                case State.BouncingOfBorder:
                    _horizontalSpeed = Input.GetAxis("Horizontal");
                    _player.AddForce(new Vector2(_horizontalSpeed * _horizontalSpeedMultiplier, 0));
                    _player.AddForce(new Vector2(GameController.StreamSpeed * _horizontalSpeedMultiplier, 0));



                    if (GameController.StreamSpeed > 0)
                    {
                        _player.AddForce(
                            new Vector2(
                                CalculateStreamForce() * _horizontalSpeedMultiplier, 0));
                    }
                    else
                    {
                        _player.AddForce(
                            new Vector2(
                                -CalculateStreamForce() * _horizontalSpeedMultiplier, 0));
                    }

                    _player.velocity = new Vector2(_player.velocity.x, _verticalSpeed);
                    break;
                case State.MoveViaObstacle:
                    break;
            }
            //Debug.Log(_player.velocity.y);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            switch (collision.tag)
            {
                case "LooseBorder":
                    GameController.IsLoose = true;
                    break;
                case "StrongStreamBorder":
                    _currentState = State.BouncingOfBorder;
                    break;
                case "Obstacle":

                    StartCoroutine(KeyListener(collision.GetComponent<Obstacle>()));
                    break;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("StrongStreamBorder"))
            {
                _currentState = State.Default;
            }
        }


        private float InvertCoords(float coords)
        {
            if (coords >= 1)
            {
                return 0f;
            }
            if (coords <= 0)
            {
                return 1f;
            }

            return 1 - coords;
        }

        private float CalculateStreamForce()
        {
            float tempStreamForce = GameController.StreamSpeed > 0
                ? InvertCoords((Mathf.Abs(_strongStreamBorder.transform.position.x) - Mathf.Abs(_player.position.x)) /
                               _borderColliderWidth) - GameController.StreamSpeed
                : InvertCoords((Mathf.Abs(_strongStreamBorder.transform.position.x) - Mathf.Abs(_player.position.x)) /
                               _borderColliderWidth) + GameController.StreamSpeed;
            if (tempStreamForce < 0)
            {
                return 0;
            }
            return tempStreamForce;
        }

        private IEnumerator KeyListener(Obstacle obstacle)
        {


            if (obstacle is ClimbedOnlyObstacleScript)
            {
                while (true)
                {
                    // Debug.Log("test");

                    if (Input.GetButtonDown("Up"))
                    {
                        _currentState = State.MoveViaObstacle;
                        GetComponent<Collider2D>().enabled = false;
                        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                        GetComponent<SpriteRenderer>().sortingOrder =
                            obstacle.GetComponent<SpriteRenderer>().sortingOrder +
                            1;
                        yield return
                            StartCoroutine(
                                MovePlayerOverObstacle(
                                    (ClimbedOnlyObstacleScript) obstacle));
                    }

                    yield return null;
                }
            }
        }

        private IEnumerator MovePlayerOverObstacle(ClimbedOnlyObstacleScript climbedOnlyObstacleScript)
        {
            Vector2 targetPosition = new Vector2(transform.position.x, climbedOnlyObstacleScript.PlayerPositionAfterMovingViaObstacle);
            //_player.velocity = new Vector2(0f, 0f);
            Vector2 startPosition = transform.position;
            float timer = 0.0f;
            float time = 5.0f;

            while (timer <= time)
            {
                transform.position = Vector2.Lerp(startPosition, targetPosition,
                    climbedOnlyObstacleScript.OvercomeCurve.Evaluate(timer / time));
                timer += Time.deltaTime;
                yield return null;
            }
            
            StopCoroutine(KeyListener(null));
            GetComponent<Collider2D>().enabled = true;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            _currentState = State.Default;
        }
    }
}
