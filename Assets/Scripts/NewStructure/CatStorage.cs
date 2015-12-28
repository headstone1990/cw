using UnityEngine;
using System.Collections;

public class CatStorage : MonoBehaviour
{
    public Player Player { get; set; }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlayerCreate(string furryType, string faceType, string eyesType)
    {
        Player = new Player();
        Player.PlayerAvatar["FurryType"] = furryType;
        Player.PlayerAvatar["FaceType"] = faceType;
        Player.PlayerAvatar["EyesType"] = eyesType;
    }
}
