using System;
using UnityEngine;
using System.Collections.Generic;

public class Cat
{
    private Characteristics _characteristics = new Characteristics();
    private List<Traits> _traits = new List<Traits>();


    public string Name { get; set; }
    public bool Gender { get; set; }
    public int Age { get; set; }
    public string Tribe { get; set; }
    public int MoonInTribe { get; set; }
    public string Rang { get; set; }


    // WarriorSkill[] warriorSkills;
    // Item[] items;
    public Texture2D Avatar { get; set; }
    public Characteristics Characteristics
    {
        get { return _characteristics; }

        set { _characteristics = value; }
    }
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
