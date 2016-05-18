using System.Collections.Generic;
using UnityEngine;

public class Cat
{
    private List<Traits> _traits = new List<Traits>();

    public Cat()
    {
        Characteristics = new Characteristics();
    }


    public string Name { get; set; }
    public bool IsMale { get; set; }
    public int Age { get; set; }
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
}