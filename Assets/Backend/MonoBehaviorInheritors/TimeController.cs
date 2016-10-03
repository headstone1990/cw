using UnityEngine;

namespace CW.Backend.MonoBehaviorInheritors
{
    public class TimeController : MonoBehaviour
    {
        static TimeController()
        {
            CurrentTime = new IngameTime(1004, 1, 0, 0);
        }
        public delegate void TimeAddedEventHandler(IngameTimeInterval time);

        public static TimeController Instance { get; private set; }


        public static IngameTime CurrentTime { get; private set; }

        public event TimeAddedEventHandler OnTimeScrollStarted;


        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            //string s = String.Format("Сейчас {0} день {1} луны, {2}:{3}  {4}  {5}", test.Day, test.Moon, test.Hour, test.Minute, test.Season, test.MoonOfYear);
            //string s = String.Format("Прошло {0} лун {1} дней, {2}:{3}", test.Moon, test.Day, test.Hour, test.Minute);
            //Debug.Log(s);
        }


        public void AddTime(IngameTimeInterval time)
        {
            CurrentTime = CurrentTime + time;
            if (OnTimeScrollStarted != null) OnTimeScrollStarted.Invoke(time);
        }
    }
}