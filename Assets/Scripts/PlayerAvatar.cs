using System;
using UnityEngine;
using System.Collections.Generic;

public class PlayerAvatar
{
    public enum Parts
    {
        Shape = 0,
        Shadow = 1,
        FurryType = 2,
        FaceType = 3,
        EyesType = 4,
        EyesColor = 5,
        Ears = 6,
        Nose = 7,
        ColorMain = 8,
        ColorBack = 9,
        ColorBackFoot = 10,
        ColorBreast = 11,
        ColorEars = 12,
        ColorHose = 13,
        ColorSocks = 14,
        ColorTail = 15,
        ColorTailTip = 16,
        StripsS = 17,
        StripsM = 18,
        StripsL = 19,
        SpotsS = 20,
        SpotsM = 21,
        SpotsL = 22,
        SpotsLe = 23
    }
    public enum Shapes
    {
        Shape1 = 1,
        Shape2 = 2,
        Shape3 = 3,
        Shape4 = 4,
        Shape5 = 5,
        Shape6 = 6,
        Shape7 = 7,
        Shape8 = 8,
        Shape9 = 9,
        Shape10 = 10,
        Shape11 = 11,
        Shape12 = 12
    }
    public enum Shadows
    {
        Shadow1 = 1,
        Shadow2 = 2,
        Shadow3 = 3,
        Shadow4 = 4,
        Shadow5 = 5,
        Shadow6 = 6,
        Shadow7 = 7,
        Shadow8 = 8,
        Shadow9 = 9,
        Shadow10 = 10,
        Shadow11 = 11,
        Shadow12 = 12
    }
    public enum FurryTypes
    {
        ShortFur = 1,
        NormalFur = 2,
        LongFur = 3
    }
    public enum FaceTypes
    {
        Normal = 1,
        Flat = 2,
        Narrow = 3,
        Wide = 4
    }
    public enum EyesTypes
    {
        Angry1 = 1,
        Angry2 = 2,
        Angry3 = 3,
        Angry4 = 4,
        Cute1 = 5,
        Cute2 = 6,
        Cute3 = 7,
        Cute4 = 8,
        Normal1 = 9,
        Normal2 = 10,
        Normal3 = 11,
        Normal4 = 12,
        Shy1 = 13,
        Shy2 = 14,
        Shy3 = 15,
        Shy4 = 16,
    }
    public enum EyesColors
    {
        None = 0,
        Amber = 1,
        Blue = 2,
        Brown = 3,
        DarkBlue = 4,
        DarkBrown = 5,
        Gray = 6,
        Green = 7,
        GreenYellow = 8,
        LightBlue = 9,
        Swamp = 10,
        Yellow = 11
    }
    public enum EarsAndNoses
    {
        None = 0,
        Black = 1,
        Bright = 2,
        Brown = 3,
        Gray = 4,
        Peach = 5,
        Pink = 6,
        Sand = 7,
        Spotty = 8
    }
    public enum FurColorsAndStripsAndSpots
    {
        None = 0,
        Black = 1,
        BlueGray = 2,
        Bright = 3,
        Brown = 4,
        DarkBrown = 5,
        DarkGray = 6,
        Ginger = 7,
        Gray = 8,
        LightBrown = 9,
        LightGray = 10,
        PaleGinger = 11,
        Sand = 12,
        Silver = 13,
        White = 14,
        Yellow = 15
    }


    private Dictionary<Parts, Enum> _dictionary = new Dictionary<Parts, Enum>
    {
        {Parts.Shape, null },
        {Parts.Shadow, null },
        {Parts.FurryType, FurryTypes.NormalFur },
        {Parts.FaceType, FaceTypes.Normal},
        {Parts.EyesType, null },
        {Parts.EyesColor, EyesColors.None },
        {Parts.Ears, EarsAndNoses.None},
        {Parts.Nose, EarsAndNoses.None},
        {Parts.ColorMain, FurColorsAndStripsAndSpots.None},
        {Parts.ColorBack, FurColorsAndStripsAndSpots.None},
        {Parts.ColorBackFoot, FurColorsAndStripsAndSpots.None },
        {Parts.ColorBreast, FurColorsAndStripsAndSpots.None},
        {Parts.ColorEars, FurColorsAndStripsAndSpots.None},
        {Parts.ColorHose, FurColorsAndStripsAndSpots.None},
        {Parts.ColorSocks, FurColorsAndStripsAndSpots.None},
        {Parts.ColorTail, FurColorsAndStripsAndSpots.None},
        {Parts.ColorTailTip, FurColorsAndStripsAndSpots.None},
        {Parts.StripsS, FurColorsAndStripsAndSpots.None},
        {Parts.StripsM, FurColorsAndStripsAndSpots.None},
        {Parts.StripsL, FurColorsAndStripsAndSpots.None},
        {Parts.SpotsS, FurColorsAndStripsAndSpots.None},
        {Parts.SpotsM, FurColorsAndStripsAndSpots.None},
        {Parts.SpotsL, FurColorsAndStripsAndSpots.None},
        {Parts.SpotsLe, FurColorsAndStripsAndSpots.None}
    };
    //private Dictionary<string, string> _dictionary = new Dictionary<string, string>
    //{
    //    {"Shape", null },
    //    {"FurryType", null },
    //    {"FaceType", null},
    //    {"EyesType", null },
    //    {"EyesColor", null },
    //    {"Ears", null},
    //    {"Nose", null},
    //    {"ColorMain", null},
    //    {"ColorBack", null},
    //    {"ColorBackFoot", null },
    //    {"ColorBreast", null},
    //    {"ColorEars", null},
    //    {"ColorHose", null},
    //    {"ColorSocks", null},
    //    {"ColorTail", null},
    //    {"ColorTailTip", null},
    //    {"StripsS", null},
    //    {"StripsM", null},
    //    {"StripsL", null},
    //    {"SpotsS", null},
    //    {"SpotsM", null},
    //    {"SpotsL", null},
    //    {"SpotsLe", null}
    //};

    public Enum this[Parts key]
    {
        get { return _dictionary[key]; }
        set
        {
            if (key == Parts.FurryType || key == Parts.FaceType)
            {
                _dictionary[key] = value;
                ShapeCalculation();
            }
            else if (key == Parts.Shape)
            {
                Debug.Log("Попытка вручную перезаписать shape");
            }
            else if (key == Parts.Shadow)
            {
                Debug.Log("Попытка вручную перезаписать shadow");
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
        if ((FurryTypes) _dictionary[Parts.FurryType] == FurryTypes.ShortFur)
        {
            if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Normal)
            {
                _dictionary[Parts.Shape] = Shapes.Shape1;
                _dictionary[Parts.Shadow] = Shadows.Shadow1;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Flat)
            {
                _dictionary[Parts.Shape] = Shapes.Shape4;
                _dictionary[Parts.Shadow] = Shadows.Shadow4;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Narrow)
            {
                _dictionary[Parts.Shape] = Shapes.Shape7;
                _dictionary[Parts.Shadow] = Shadows.Shadow7;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Wide)
            {
                _dictionary[Parts.Shape] = Shapes.Shape10;
                _dictionary[Parts.Shadow] = Shadows.Shadow10;
            }
        }
        else if ((FurryTypes) _dictionary[Parts.FurryType] == FurryTypes.NormalFur)
        {
            if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Normal)
            {
                _dictionary[Parts.Shape] = Shapes.Shape2;
                _dictionary[Parts.Shadow] = Shadows.Shadow2;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Flat)
            {
                _dictionary[Parts.Shape] = Shapes.Shape5;
                _dictionary[Parts.Shadow] = Shadows.Shadow5;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Narrow)
            {
                _dictionary[Parts.Shape] = Shapes.Shape8;
                _dictionary[Parts.Shadow] = Shadows.Shadow8;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Wide)
            {
                _dictionary[Parts.Shape] = Shapes.Shape11;
                _dictionary[Parts.Shadow] = Shadows.Shadow11;
            }
        }
        else if ((FurryTypes) _dictionary[Parts.FurryType] == FurryTypes.LongFur)
        {
            if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Normal)
            {
                _dictionary[Parts.Shape] = Shapes.Shape3;
                _dictionary[Parts.Shadow] = Shadows.Shadow3;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Flat)
            {
                _dictionary[Parts.Shape] = Shapes.Shape6;
                _dictionary[Parts.Shadow] = Shadows.Shadow6;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Narrow)
            {
                _dictionary[Parts.Shape] = Shapes.Shape9;
                _dictionary[Parts.Shadow] = Shadows.Shadow9;
            }
            else if ((FaceTypes) _dictionary[Parts.FaceType] == FaceTypes.Wide)
            {
                _dictionary[Parts.Shape] = Shapes.Shape12;
                _dictionary[Parts.Shadow] = Shadows.Shadow12;
            }
        }
    }
}
