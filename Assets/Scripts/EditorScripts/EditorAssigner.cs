using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EditorAssigner : MonoBehaviour
{
    public string ParamValue { get; set; }
    public string ParamString { get; set; }
    private PlayerAvatar _playerAvatar;

    private void Start()
    {
        _playerAvatar = GameObject.FindGameObjectWithTag("CatStorage").GetComponent<CatStorage>().Player.PlayerAvatar;
    }

    public void Assign()
    {
        _playerAvatar[ParamString] = ParamValue;
    }

    public void NullAsign()
    {
        _playerAvatar[ParamString] = null;
    }




}
