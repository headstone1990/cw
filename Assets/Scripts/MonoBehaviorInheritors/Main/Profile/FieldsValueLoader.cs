using System;
using UnityEngine;
using MonoBehaviorInheritors;
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
        _age.text = string.Format("{0} moons {1} days", _player.Age.Moon, _player.Age.Day);
        _rang.text = _player.Rang;
        _clan.text = _player.Clan;
    }
}
