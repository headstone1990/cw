using System;
using System.Collections.Generic;

public class Player : Cat
{
    private PlayerAvatar _playerAvatar = new PlayerAvatar();
    

    public PlayerAvatar PlayerAvatar
    {
        get { return _playerAvatar; }
        set { _playerAvatar = value; }
    }
}
