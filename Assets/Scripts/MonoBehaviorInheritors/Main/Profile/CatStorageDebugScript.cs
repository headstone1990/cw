using System;
using DefaultNamespace;
using UnityEngine;

namespace MonoBehaviorInheritors.Main.Profile
{
    using CW.Backend;
    using CW.Backend.MonoBehaviorInheritors;

    public class CatStorageDebugScript : MonoBehaviour
    {
        private Player _player;

        [SerializeField] private string _name;
        [SerializeField] private bool _isMale;
        [SerializeField] private string _clan;
        [SerializeField] private string _rang;
        [Range(0, 100)] [SerializeField] private int _strength;
        [Range(0, 100)] [SerializeField] private int _agility;
        [Range(0, 100)] [SerializeField] private int _stamina;
        [Range(0, 100)] [SerializeField] private int _intellect;
        [Range(0, 100)] [SerializeField] private int _look;
        [Range(0, 100)] [SerializeField] private int _popularity;
        [SerializeField] private Texture2D _avatar;
        [Range(1, 1003)] [SerializeField] private int _moonOfBirthday;
        [Range(1, 30)] [SerializeField] private int _dayOfBirthday;

        private void Awake()
        {
            _player = CatStorage.Instance.Player;
            _player.Name = _name;
            _player.IsMale = _isMale;
            _player.Clan = _clan;
            _player.Rang = _rang;
            _player.Characteristics.Strength = _strength;
            _player.Characteristics.Agility = _agility;
            _player.Characteristics.Stamina = _stamina;
            _player.Characteristics.Intellect = _intellect;
            _player.Characteristics.Look = _look;
            _player.Characteristics.Popularity = _popularity;
            _player.Avatar = _avatar;
            _player.DebugBirthdaySetter = new IngameTime((ulong)_moonOfBirthday, (ulong)_dayOfBirthday, 0, 0);
        }
    }
}
