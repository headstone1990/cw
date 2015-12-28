using UnityEngine;
using System.Collections;

public class EscMenu : MonoBehaviour {

    public bool saveMenuOpened = false;
    public bool loadMenuOpened = false;
    public bool settingsMenuOpened = false;
    public bool mainMenuDialogOpened = false;
    public bool exitDialogOpened = false;

    public void SaveMenu()
    {
        saveMenuOpened = true;

    }

}
