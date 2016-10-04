﻿#region

using CW.Backend;

using MonoBehaviorInheritors.Main;

#endregion

public class AiCat : Cat
{
    private IngameTimeInterval _timeLeftOfCurrentTimeScroll;


    public AiCat(IngameTime birthday) : base(birthday)
    {

        //TimeController.Instance.OnTimeScrollStarted += StartTimeScroll;
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
                    RefreshPreviosActions();
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
        return new CatsAction();
    }

    private void RefreshPreviosActions()
    {
        if (PreviousActions.Count <= 4) return;
        PreviousActions.RemoveFirst();
        PreviousActions.AddLast(CurrentAction);
    }
}

public class CatsAction
{
    public IngameTimeInterval TimeLeft { get; set; }
}