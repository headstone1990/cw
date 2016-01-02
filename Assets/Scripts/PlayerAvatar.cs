using UnityEngine;
using System.Collections.Generic;

public class PlayerAvatar
{
    private Dictionary<string, string> _dictionary = new Dictionary<string, string>
    {
        {"Shape", null },
        {"FurryType", null },
        {"FaceType", null},
        {"EyesType", null },
        {"EyesColor", null },
        {"Ears", null},
        {"Nose", null},
        {"ColorMain", null},
        {"ColorBack", null},
        {"ColorBackFoot", null },
        {"ColorBreast", null},
        {"ColorEars", null},
        {"ColorHose", null},
        {"ColorSocks", null},
        {"ColorTail", null},
        {"ColorTailTip", null},
        {"StripsS", null},
        {"StripsM", null},
        {"StripsL", null},
        {"SpotsS", null},
        {"SpotsM", null},
        {"SpotsL", null},
        {"SpotsLe", null}
    };

    public string this[string key]
    {
        get { return _dictionary[key]; }

        set
        {
            if (key == "FurryType" || key == "FaceType")
            {
                _dictionary[key] = value;
                ShapeCalculation();
            }
            else if (key == "shape")
            {
                Debug.Log("Попытка вручную перезаписать shape");
            }
            else
            {
                _dictionary[key] = value;
            }
        }
    }
    private StripsAndSpotsSibling _sibling = new StripsAndSpotsSibling();

    public StripsAndSpotsSibling Sibling
    {
        get
        {
            return _sibling;
        }

        set
        {
            _sibling = value;
        }
    }

    private void ShapeCalculation()
    {

        
        if (_dictionary["FurryType"] == "1")
        {
            if (_dictionary["FaceType"] == "Normal")
            {
                _dictionary["Shape"] = "1";
            }
            else if (_dictionary["FaceType"] == "Flat")
            {
                _dictionary["Shape"] = "4";
            }
            else if (_dictionary["FaceType"] == "Narrow")
            {
                _dictionary["Shape"] = "7";
            }
            else if (_dictionary["FaceType"] == "Wide")
            {
                _dictionary["Shape"] = "10";
            }
        }
        else if (_dictionary["FurryType"] == "2")
        {
            if (_dictionary["FaceType"] == "Normal")
            {
                _dictionary["Shape"] = "2";
            }
            else if (_dictionary["FaceType"] == "Flat")
            {
                _dictionary["Shape"] = "5";
            }
            else if (_dictionary["FaceType"] == "Narrow")
            {
                _dictionary["Shape"] = "8";
            }
            else if (_dictionary["FaceType"] == "Wide")
            {
                _dictionary["Shape"] = "11";
            }
        }
        else if (_dictionary["FurryType"] == "3")
        {
            if (_dictionary["FaceType"] == "Normal")
            {
                _dictionary["Shape"] = "3";
            }
            else if (_dictionary["FaceType"] == "Flat")
            {
                _dictionary["Shape"] = "6";
            }
            else if (_dictionary["FaceType"] == "Narrow")
            {
                _dictionary["Shape"] = "9";
            }
            else if (_dictionary["FaceType"] == "Wide")
            {
                _dictionary["Shape"] = "12";
            }
        }
    }
}
