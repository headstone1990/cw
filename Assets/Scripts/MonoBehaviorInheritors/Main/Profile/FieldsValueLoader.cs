using System;

using CW.Backend;
using CW.Backend.MonoBehaviorInheritors;

using UnityEngine;
using MonoBehaviorInheritors;
using MonoBehaviorInheritors.Main;
using UnityEngine.UI;

public class FieldsValueLoader : MonoBehaviour
{
    [SerializeField] private Text _name;
    [SerializeField] private Text _rang;
    [SerializeField] private Text _age;
    [SerializeField] private Text _clan;
    [SerializeField] private Sprite _male;
    [SerializeField] private Sprite _female;
    [SerializeField] private Image _genderImage;
    [SerializeField] private Slider[] _sliders;

    private Player _player;


    private void Awake()
    {
        _player = CatStorage.Instance.Player;
    }

    private void OnEnable()
    {
        TextFieldValueAssign();
        GenderImageAssign();
        ProgressbarAssign();

    }

    private void ProgressbarAssign()
    {
        foreach (Slider slider in _sliders)
        {
            slider.value = (int)_player.Characteristics.GetType().GetProperty(slider.name).GetValue(_player.Characteristics, null);
            slider.GetComponentInChildren<Text>().text = string.Format("{0}/100", (int)_player.Characteristics.GetType().GetProperty(slider.name).GetValue(_player.Characteristics, null));
        }
    }

    private void GenderImageAssign()
    {
        if (_player.IsMale)
        {
            _genderImage.sprite = _male;
        }
        else
        {
            _genderImage.sprite = _female;
        }
    }

    private void TextFieldValueAssign()
    {
        _name.text = _player.Name;
        _age.text = string.Format("{0} {1} {2} {3}", _player.Age.Moon, MoonStringDeclension, _player.Age.Day, DayStringDeclension);
        _rang.text = _player.Rang;
        _clan.text = _player.Clan;
    }

    private string MoonStringDeclension
    {
        get
        {
            if (_player.Age.Moon > 10 && _player.Age.Moon < 20)
            {
                return "лун";
            }
            int lastDigit = _player.Age.Moon%10;
            if (lastDigit == 0 || lastDigit > 4)
            {
                return "лун";
            }
            return lastDigit == 1 ? "луна" : "луны";
        }
    }

    private string DayStringDeclension
    {
        get
        {
            if (_player.Age.Day > 10 && _player.Age.Day < 20)
            {
                return "дней";
            }
            int lastDigit = _player.Age.Day % 10;
            if (lastDigit == 0 || lastDigit > 4)
            {
                return "дней";
            }

            return lastDigit == 1 ? "день" : "дня";
        }
    }
}
