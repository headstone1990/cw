using UnityEngine;

namespace MonoBehaviorInheritors.MiniGames.RiverCrossing.Obstacles
{
    public abstract class Obstacle : MonoBehaviour
    {
        private EdgeCollider2D _overcomeSideTrigger;

        private void Awake()
        {
            _overcomeSideTrigger = transform.Find("OvercomeSideTrigger").GetComponent<EdgeCollider2D>();
        }

        public void DisableOvercomeSideTrigger()
        {
            _overcomeSideTrigger.enabled = false;
        }
    }
}
