using MonoBehaviorInheritors;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInh.CatEditor
{

    public class CatIntegrityChecker : MonoBehaviour
    {
        [SerializeField] private GameObject _warningGameObject = null;
        [SerializeField] private Text _warningText = null;
        private PlayerAvatar _playerAvatar;

        private void Start()
        {
            _playerAvatar = CatStorage.Storage.Player.PlayerAvatar;
        }

        public bool IsSetValuesForRequiredParts()
        {
            if ((PlayerAvatar.FurColorsAndStripsAndSpots)_playerAvatar[PlayerAvatar.Parts.ColorMain] == PlayerAvatar.FurColorsAndStripsAndSpots.None)
            {
                EnableWarning();
                SetWarningText("Выберите основной окрас");
                return false;
            }
            if ((PlayerAvatar.EarsAndNoses)_playerAvatar[PlayerAvatar.Parts.Ears] == PlayerAvatar.EarsAndNoses.None)
            {
                EnableWarning();
                SetWarningText("Выберете цвет ушей");
                return false;
            }
            if ((PlayerAvatar.EarsAndNoses)_playerAvatar[PlayerAvatar.Parts.Nose] == PlayerAvatar.EarsAndNoses.None)
            {
                EnableWarning();
                SetWarningText("Выберете цвет носа");
                return false;
            }
            if ((PlayerAvatar.EyesColors)_playerAvatar[PlayerAvatar.Parts.EyesColor] == PlayerAvatar.EyesColors.None)
            {
                EnableWarning();
                SetWarningText("Выберете цвет глаз");
                return false;
            }
                return true;
        }

        private void SetWarningText(string text)
        {
            _warningText.text = text;
        }

        private void EnableWarning()
        {
            _warningGameObject.SetActive(true);
        }
    }
}