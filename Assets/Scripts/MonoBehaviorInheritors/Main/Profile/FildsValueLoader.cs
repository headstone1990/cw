using UnityEngine;
using System.Collections;
using MonoBehaviorInheritors;
using UnityEngine.UI;

public class FildsValueLoader : MonoBehaviour
{
    [SerializeField]
    Text _name;
    [SerializeField]
    Text _age;

    private Player _player;


    private void Start()
    {
        _player = CatStorage.Instance.Player;
    }
    public void OnEnable()
    {
        _name.text = _player.Name;
    }
}
