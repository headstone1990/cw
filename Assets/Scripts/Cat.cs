using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Cat
{
    private List<Traits> _traits = new List<Traits>();
    private IngameTime _birthday;

    public Cat()
    {
        Characteristics = new Characteristics();
    }


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
}