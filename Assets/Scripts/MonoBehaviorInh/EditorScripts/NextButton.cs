using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MonoBehaviorInh.EditorScripts
{
    public class NextButton : MonoBehaviour
    {
        private PlayerAvatar _playerAvatar;
        [SerializeField]
        private GameObject _warning;
        [SerializeField]
        private Text _warningText;

        private void Awake()
        {
            _playerAvatar = GameObject.FindGameObjectWithTag("CatStorage").GetComponent<CatStorage>().Player.PlayerAvatar;
        }

        public void ButtonClick()
        {
            if (string.IsNullOrEmpty(_playerAvatar["ColorMain"]))
            {
                ActivateWarningAndChangeWarningText("Выберете основной окрас шерсти");
            }
            else if(string.IsNullOrEmpty(_playerAvatar["Ears"]))
            {
                ActivateWarningAndChangeWarningText("Выберете цвет ушей");
            }
            else if (string.IsNullOrEmpty(_playerAvatar["Nose"]))
            {
                ActivateWarningAndChangeWarningText("Выберете цвет носа");
            }
            else if (string.IsNullOrEmpty(_playerAvatar["EyesColor"]))
            {
                ActivateWarningAndChangeWarningText("Выберете цвет глаз");
            }
            else
            {
                SceneManager.LoadScene("TraitsSelection");
            }
        }

        private void ActivateWarningAndChangeWarningText(string warningText)
        {
            _warning.SetActive(true);
            _warningText.text = warningText;
        }
    }
}
