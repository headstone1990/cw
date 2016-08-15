#region

using System.Collections.Generic;
using MonoBehaviorInheritors.Main;
using UnityEngine;

#endregion

public abstract class Cat
{
    private IngameTime _birthday;
    protected LinkedList<CatsAction> _previosActions = new LinkedList<CatsAction>();
    private List<Traits> _traits = new List<Traits>();


    protected Cat()
    {
        Characteristics = new Characteristics();
    }

    public Texture2D Avatar { get; set; }
    public CatsAction CurrentAction { get; set; }
    public Characteristics Characteristics { get; set; }
    public string Clan { get; set; }
    public bool IsMale { get; set; }
    public int MoonInClan { get; set; }
    public string Name { get; set; }
    public string Rang { get; set; }

    public List<Traits> Traits
    {
        get { return _traits; }

        set { _traits = value; }
    }

    public IngameTimeInterval Age
    {
        get { return TimeController.Instance.CurrentTime - _birthday; }
    }


    public IngameTime DebugBirthdaySetter
    {
        set
        {
            _birthday = value;
        }
    }
}