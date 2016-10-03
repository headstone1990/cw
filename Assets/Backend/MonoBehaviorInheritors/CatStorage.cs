namespace CW.Backend.MonoBehaviorInheritors
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    using UserExceptions;

    public class CatStorage : MonoBehaviour
    {
        public static CatStorage Instance { get; private set; }

        public Player Player { get; private set; }

        public void CreatePlayer(
            PlayerAvatar.FurryTypes furryType,
            PlayerAvatar.FaceTypes faceType,
            PlayerAvatar.EyesTypes eyesType)
        {
            if (Player == null)
            {
                Player = new Player(TimeController.CurrentTime);
                Player.PlayerAvatar[PlayerAvatar.Parts.FaceType] = faceType;
                Player.PlayerAvatar[PlayerAvatar.Parts.FurryType] = furryType;
                Player.PlayerAvatar[PlayerAvatar.Parts.EyesType] = eyesType;
            }
            else
            {
                throw new PlayerAlreadyExistException("Trying to create more than one player");
            }
        }

        private void Awake()
        {
            if (Instance == null)
            {
                DontDestroyOnLoad(gameObject);
                Instance = this;
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
            }

            if (Player == null && SceneManager.GetActiveScene().name != "MainMenu"
                && SceneManager.GetActiveScene().name != "PresetsOrEditorChoose")
            {
                CreatePlayerWithDefaultParameters();
            }
        }

        private void CreatePlayerWithDefaultParameters()
        {
            try
            {
                CreatePlayer(
                    PlayerAvatar.FurryTypes.NormalFur,
                    PlayerAvatar.FaceTypes.Normal,
                    PlayerAvatar.EyesTypes.Normal3);
            }
            catch (PlayerAlreadyExistException e)
            {
                Debug.Log(e);
            }
        }
    }
}