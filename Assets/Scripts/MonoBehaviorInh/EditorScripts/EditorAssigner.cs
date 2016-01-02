using UnityEngine;

public class EditorAssigner : MonoBehaviour
{
    private PlayerAvatar _playerAvatar;


    public string ParamValue { get; set; }
    public string ParamString { get; set; }

    private void Awake()
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
