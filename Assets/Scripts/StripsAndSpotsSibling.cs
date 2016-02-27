using System.Collections.Generic;

public class StripsAndSpotsSibling
{
    private readonly Dictionary<PlayerAvatar.Parts, int> _dictionary = new Dictionary<PlayerAvatar.Parts, int>()
    {
        {PlayerAvatar.Parts.StripsS, 0},
        {PlayerAvatar.Parts.StripsM, 0},
        {PlayerAvatar.Parts.StripsL, 0},
        {PlayerAvatar.Parts.SpotsS, 0},
        {PlayerAvatar.Parts.SpotsM, 0},
        {PlayerAvatar.Parts.SpotsL, 0},
        {PlayerAvatar.Parts.SpotsLe, 0},
    };


    public int this[PlayerAvatar.Parts key]
    {
        get { return _dictionary[key]; }
        set { _dictionary[key] = value; }
    }

}
