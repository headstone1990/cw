using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using MonoBehaviorInheritors.Main;

public class Cat
{
    private List<Traits> _traits = new List<Traits>();
    private IngameTime _birthday;
    private IngameTimeInterval _timeLeftOfCurrentTimeScroll;

    protected Cat()
    {
        Characteristics = new Characteristics();
        TimeController.Instance.OnTimeScrollStarted += StartTimeScroll;
    }

    public CatsAction CurrentAction { get; set; }
    public string Name { get; set; }
    public bool IsMale { get; set; }

    public IngameTimeInterval Age
    {
        get { return TimeController.Instance.CurrentTime - _birthday; }
    }

    public string Clan { get; set; }
    public int MoonInClan { get; set; }
    public string Rang { get; set; }




    // WarriorSkill[] warriorSkills;
    // Item[] items;
    public Texture2D Avatar { get; set; }
    public Characteristics Characteristics { get; set; }

    public List<Traits> Traits
    {
        get
        {
            return _traits;
        }

        set
        {
            _traits = value;
        }
    }

    public IngameTime DebugBirthdaySetter
    {
        set { _birthday = value; }
    }

    public void StartTimeScroll(IngameTimeInterval duration)
    {
        _timeLeftOfCurrentTimeScroll = duration;
        DoAction();
    }

    private void DoAction()
    {
        while (_timeLeftOfCurrentTimeScroll > 0)
        {
            if (CurrentAction != null)
            {
                if (CurrentAction.TimeLeft <= _timeLeftOfCurrentTimeScroll)
                {
                    _timeLeftOfCurrentTimeScroll -= CurrentAction.TimeLeft;
                    CurrentAction.TimeLeft = 0;
                    CurrentAction = null;
                }
                else
                {
                    CurrentAction.TimeLeft -= _timeLeftOfCurrentTimeScroll;
                    _timeLeftOfCurrentTimeScroll = 0;
                }
            }
            else
            {
                CurrentAction = GenerateNewAction();
            }
        }
    }

    private CatsAction GenerateNewAction()
    {
        throw new System.NotImplementedException();
    }
}

public class CatsAction
{
    public IngameTimeInterval TimeLeft { get; set; }
}
