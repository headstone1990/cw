using UnityEngine;

namespace MonoBehaviorInheritors.MiniGames.RiverCrossing.Obstacles
{
    public class OvercomeSideTriggerTuner : MonoBehaviour
    {
        private void Start()
        {
            EdgeCollider2D trigger = GetComponent<EdgeCollider2D>();
            float yCoordinate = transform.GetComponentInParent<SpriteRenderer>().sprite.bounds.extents.y;
            float xCoordinate = GameController.BorderXcoordinate;
            Vector2[] tempArray = new Vector2[2];
            tempArray[0] = new Vector2(xCoordinate - transform.parent.position.x, yCoordinate);
            tempArray[1] = new Vector2(-xCoordinate - transform.parent.position.x, yCoordinate);
            trigger.points = tempArray;
        }
    }
}