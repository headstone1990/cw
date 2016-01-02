using System.Collections.Generic;

public class StripsAndSpotsSibling
{
    private Dictionary<string, int> _dictionary = new Dictionary<string, int>()
    {
        {"StripsS", 0},
        {"StripsM", 0},
        {"StripsL", 0},
        {"SpotsS", 0},
        {"SpotsM", 0},
        {"SpotsL", 0},
        {"SpotsLe", 0}
    };


    public int this[string key]
    {
        get { return _dictionary[key]; }
        set { _dictionary[key] = value; }
    }

}
