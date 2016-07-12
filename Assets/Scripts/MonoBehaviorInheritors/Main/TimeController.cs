using System;
using UnityEngine;
using System.Collections;
using DefaultNamespace;
namespace MonoBehaviorInheritors.Main
{


	public class TimeController : MonoBehaviour
	{
	    public delegate void TimeAddedEventHandler(IngameTimeInterval time);


	    public event TimeAddedEventHandler OnTimeScrollStarted;
	    public static TimeController Instance { get; private set; }

	    public IngameTime CurrentTime
	    {
	        get { return _currentTime; }
	    }

	    private IngameTime _currentTime = new IngameTime(1004, 1, 0, 0);

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
	        _currentTime = CurrentTime + time;
	        if (OnTimeScrollStarted != null) OnTimeScrollStarted.Invoke(time);
	    }
	}
}
