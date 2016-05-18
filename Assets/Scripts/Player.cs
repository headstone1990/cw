using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : Cat
{
    private PlayerAvatar _playerAvatar = new PlayerAvatar();


    public PlayerAvatar PlayerAvatar
    {
        get { return _playerAvatar; }
        set { _playerAvatar = value; }
    }

}
