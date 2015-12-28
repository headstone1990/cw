using System;
using UnityEngine;
using System.Collections.Generic;

public class Player : Cat
{
    private PlayerAvatar _playerAvatar = new PlayerAvatar();
    private List<Enum> _traits = new List<Enum>(); 

    

    public PlayerAvatar PlayerAvatar
    {
        get { return _playerAvatar; }
        set { _playerAvatar = value; }
    }
  



    // ArmorSlots armorSlots;
}
