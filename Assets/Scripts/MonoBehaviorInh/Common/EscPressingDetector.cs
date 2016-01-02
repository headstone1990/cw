using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EscPressingDetector : MonoBehaviour
{
    Button save;
    Button load;
    Button settings;
    Button mainMenu;
    Button exit;
    public GameObject escMenu;
    public GameObject blankBackgroundEscMenu;
    public GameObject savePanel;
    public GameObject loadPanel;
    public GameObject settingsPanel;
    public GameObject mainMenuDialogPanel;
    public GameObject exitDialogPanel;


    void Awake()
    {
        escMenu = GameObject.Find("EscMenu");
        blankBackgroundEscMenu = GameObject.Find("BlankBackgroundEscMenu");
        savePanel = GameObject.Find("SavePanel");
        loadPanel = GameObject.Find("LoadPanel");
        settingsPanel = GameObject.Find("SettingsPanel");
        mainMenuDialogPanel = GameObject.Find("MainMenuDialogPanel");
        exitDialogPanel = GameObject.Find("ExitDialogPanel");

        save = GameObject.Find("Save").GetComponent<Button>();
        load = GameObject.Find("Load").GetComponent<Button>();
        settings = GameObject.Find("Settings").GetComponent<Button>();
        mainMenu = GameObject.Find("MainMenu").GetComponent<Button>();
        exit = GameObject.Find("Exit").GetComponent<Button>();

        escMenu.SetActive(false);
        blankBackgroundEscMenu.SetActive(false);
        savePanel.SetActive(false);
        loadPanel.SetActive(false);
        settingsPanel.SetActive(false);
        mainMenuDialogPanel.SetActive(false);
        exitDialogPanel.SetActive(false);
    }
	void Update ()
    {
        if (Input.GetKeyDown("escape"))
        {
            EscMenu();
        }
	}
    public void EscMenu()
    {
        if (!savePanel.activeSelf && !loadPanel.activeSelf && !settingsPanel.activeSelf && !mainMenuDialogPanel.activeSelf && !exitDialogPanel.activeSelf)
        {
            escMenu.SetActive(!escMenu.activeSelf);
            blankBackgroundEscMenu.SetActive(!blankBackgroundEscMenu.activeSelf);
        }
        else if (savePanel.activeSelf)
        {
            savePanel.SetActive(false);
            EnableComponents();
        }
        else if (loadPanel.activeSelf)
        {
            loadPanel.SetActive(false);
            EnableComponents();
        }
        else if (settingsPanel.activeSelf)
        {
            settingsPanel.SetActive(false);
            EnableComponents();
        }
        else if (mainMenuDialogPanel.activeSelf)
        {
            mainMenuDialogPanel.SetActive(false);
            EnableComponents();
        }
        else if (exitDialogPanel.activeSelf)
        {
            exitDialogPanel.SetActive(false);
            EnableComponents();
        }
    }
    public void SaveMenu()
    {
        savePanel.SetActive(true);
        DisableComponents();
    }
    public void LoadMenu()
    {
        loadPanel.SetActive(true);
        DisableComponents();
    }
    public void SettingsMenu()
    {
        settingsPanel.SetActive(true);
        DisableComponents();
    }
    public void MainMenuDialog()
    {
        mainMenuDialogPanel.SetActive(true);
        DisableComponents();
    }
    public void ExitDialog()
    {
        exitDialogPanel.SetActive(true);
        DisableComponents();
    }

    void DisableComponents()
    {
        save.enabled = false;
        load.enabled = false;
        settings.enabled = false;
        mainMenu.enabled = false;
        exit.enabled = false;
    }
    void EnableComponents()
    {
        save.enabled = true;
        load.enabled = true;
        settings.enabled = true;
        mainMenu.enabled = true;
        exit.enabled = true;
    }
}
