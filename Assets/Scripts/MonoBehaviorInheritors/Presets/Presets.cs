using System;

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Presets : MonoBehaviour {
    public Sprite white;
    public Sprite brown;
    public Sprite ginger;
    public Sprite gray;
    public Sprite black;

    private Image _catImage;
    public Text description;
    public Text trait0;
    public Text trait1;
    public Text trait2;
    public Text trait3;
    public Text trait4;
    public string selectedPreset = "White";
    void Awake()
    {
        Display();
    }
    void Display()
    {
        if (selectedPreset == "White")
        {
            _catImage.sprite = white;
            description.text = "Кот с такими чертами характера может стать жестоким, но справедливым предводителем.\nОднако отношения со Звёздным племенем и целителем будет сложно назвать хорошими.";
            trait0.text = "Жестокий";
            trait1.text = "Азартный";
            trait2.text = "Амбициозный";
            trait3.text = "Умный";
            trait4.text = "Грубый";
        }
        else if (selectedPreset == "Brown")
        {
            _catImage.sprite = brown;
            description.text = "Кот с таким характером способен стать верным другом предводителю и помощником для всего племени.\nХоть воин он прекрасный, хорошим собеседником его не назвать.";
            trait0.text = "Добрый";
            trait1.text = "Угрюмый";
            trait2.text = "Не ждущий власти";
            trait3.text = "Щедрый";
            trait4.text = "Трудолюбивый";
        }
        else if (selectedPreset == "Ginger")
        {
            this._catImage.sprite = ginger;
            description.text = "Весельчак, способный растопить чьё угодно сердце.\nПример для подражания у котят, отличный собеседник и верный воин, достойный стать глашатаем.";
            trait0.text = "Добросердечный";
            trait1.text = "Общительный";
            trait2.text = "Активный";
            trait3.text = "Весельчак";
            trait4.text = "Нежный";
        }
        else if (selectedPreset == "Gray")
        {
            this._catImage.sprite = gray;
            description.text = "Задумчивый и загадочный.\nЭтот кот часто видит вещие сны и хорошо разбирается в травах. Способен стать отличным другом предводителю и талантливым целителем.";
            trait0.text = "Одиночка";
            trait1.text = "Медлительный";
            trait2.text = "Аккуратный";
            trait3.text = "Верящий";
            trait4.text = "Не ждущий власти";
        }
        else if (selectedPreset == "Black")
        {
            this._catImage.sprite = black;
            description.text = "Неизвестно, Звёздное племя отвернулось от этого кота, или же он сам отверг Звёздное племя.\nАвантюрист и одиночка с щедрой душой способен стать отличным бродягой.";
            trait0.text = "Скептик";
            trait1.text = "Грубый";
            trait2.text = "Одиночка";
            trait3.text = "Амбициозный";
            trait4.text = "Щедрый";
        }
    }
    public void Right()
    {
        if (selectedPreset == "White")
        {
            selectedPreset = "Brown";
        }
        else if (selectedPreset == "Brown")
        {
            selectedPreset = "Ginger";
        }
        else if (selectedPreset == "Ginger")
        {
            selectedPreset = "Gray";
        }
        else if (selectedPreset == "Gray")
        {
            selectedPreset = "Black";
        }
        else if (selectedPreset == "Black")
        {
            selectedPreset = "White";
        }
        Display();
    }
    public void Left()
    {
        if (selectedPreset == "White")
        {
            selectedPreset = "Black";
        }
        else if (selectedPreset == "Black")
        {
            selectedPreset = "Gray";
        }
        else if (selectedPreset == "Gray")
        {
            selectedPreset = "Ginger";
        }
        else if (selectedPreset == "Ginger")
        {
            selectedPreset = "Brown";
        }
        else if (selectedPreset == "Brown")
        {
            selectedPreset = "White";
        }
        Display();
    }

    private void PresetsParametersApply()
    {
        throw new NotImplementedException();

        //        if (selectedPreset == "White")
//        {
//            GlobalVariables.trait[0] = "NotGoodhearted";
//            GlobalVariables.trait[1] = "Venturesome";
//            GlobalVariables.trait[2] = "Ambitious";
//            GlobalVariables.trait[3] = "Clever";
//            GlobalVariables.trait[4] = "NotGentle";
//            GlobalVariables.shape = 7;
//            GlobalVariables.faceType = "narrow";
//            GlobalVariables.furryType = 1;
//            GlobalVariables.eyesType = "angry_4";
//            GlobalVariables.eyesColor = "dark_blue";
//            GlobalVariables.ears = "pink";
//            GlobalVariables.nose = "pink";
//            GlobalVariables.colorMain = "white";
//        }
//        else if (selectedPreset == "Brown")
//        {
//            GlobalVariables.trait[0] = "Good";
//            GlobalVariables.trait[1] = "NotHumorist";
//            GlobalVariables.trait[2] = "NotAmbitious";
//            GlobalVariables.trait[3] = "Generous";
//            GlobalVariables.trait[4] = "Hardworking";
//            GlobalVariables.shape = 6;
//            GlobalVariables.faceType = "flat";
//            GlobalVariables.furryType = 3;
//            GlobalVariables.eyesType = "cute_3";
//            GlobalVariables.eyesColor = "yellow";
//            GlobalVariables.ears = "spotty";
//            GlobalVariables.nose = "spotty";
//            GlobalVariables.colorMain = "brown";
//            GlobalVariables.colorBackFoot = "dark_brown";
//            GlobalVariables.colorEars = "dark_brown";
//            GlobalVariables.colorHose = "dark_brown";
//            GlobalVariables.colorSocks = "dark_brown";
//            GlobalVariables.colorTailTip = "dark_brown";
//        }
//        else if (selectedPreset == "Ginger")
//        {
//            GlobalVariables.trait[0] = "Goodhearted";
//            GlobalVariables.trait[1] = "Sociable";
//            GlobalVariables.trait[2] = "Active";
//            GlobalVariables.trait[3] = "Humorist";
//            GlobalVariables.trait[4] = "Gentle";
//            GlobalVariables.shape = 11;
//            GlobalVariables.faceType = "wide";
//            GlobalVariables.furryType = 2;
//            GlobalVariables.eyesType = "normal_2";
//            GlobalVariables.eyesColor = "green";
//            GlobalVariables.ears = "sand";
//            GlobalVariables.nose = "bright";
//            GlobalVariables.colorMain = "bright";
//            GlobalVariables.stripsM = "brown";
//        }
//        else if (selectedPreset == "Gray")
//        {
//            GlobalVariables.trait[0] = "NotSociable";
//            GlobalVariables.trait[1] = "NotVenturesome";
//            GlobalVariables.trait[2] = "Careful";
//            GlobalVariables.trait[3] = "Believing";
//            GlobalVariables.trait[4] = "NotAmbitious";
//            GlobalVariables.shape = 2;
//            GlobalVariables.faceType = "normal";
//            GlobalVariables.furryType = 2;
//            GlobalVariables.eyesType = "cute_2";
//            GlobalVariables.eyesColor = "light_blue";
//            GlobalVariables.ears = "gray";
//            GlobalVariables.nose = "brown";
//            GlobalVariables.colorMain = "gray";
//            GlobalVariables.colorBackFoot = "light_gray";
//            GlobalVariables.colorBreast = "light_gray";
//            GlobalVariables.colorSocks = "light_gray";
//        }
//        else if (selectedPreset == "Black")
//        {
//            GlobalVariables.trait[0] = "NotBelieving";
//            GlobalVariables.trait[1] = "NotGentle";
//            GlobalVariables.trait[2] = "NotSociable";
//            GlobalVariables.trait[3] = "Ambitious";
//            GlobalVariables.trait[4] = "Generous";
//            GlobalVariables.shape = 1;
//            GlobalVariables.faceType = "normal";
//            GlobalVariables.furryType = 1;
//            GlobalVariables.eyesType = "shy_4";
//            GlobalVariables.eyesColor = "amber";
//            GlobalVariables.ears = "black";
//            GlobalVariables.nose = "black";
//            GlobalVariables.colorMain = "black";
//        }
    }
}
