using UnityEngine;

namespace MonoBehaviorInheritors.MiniGames.RiverCrossing.Obstacles
{
    public class ClimbedOnlyObstacleScript : Obstacle
    {
        [SerializeField] private AnimationCurve _approachCurve;
        [SerializeField] private AnimationCurve _overcomeCurve;

        public AnimationCurve ApproachCurve
        {
            get
            {
                return _approachCurve;
            }

           private set
            {
                _approachCurve = value;
            }
        }
        public AnimationCurve OvercomeCurve
        {
            get
            {
                return _overcomeCurve;
            }

           private set
            {
                _overcomeCurve = value;
            }
        }



        public float PlayerPositionAfterMovingViaObstacle
        {
            get
            {
                return transform.Find("PlayerPoint").position.y;
            }
        }
    }
}