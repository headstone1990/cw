namespace CW.Frontend.PresetsOrEditorChoose
{
    using Backend;
    using Backend.MonoBehaviorInheritors;

    using CW.Backend.UserExceptions;

    using UnityEngine;

    public class PlayerCreator : MonoBehaviour
    {
        private const int DefaultValue = 0;
        private CatStorage _catStorage;

        [SerializeField]
        private PlayerAvatar.FurryTypes _furryType = DefaultValue;  //Set in inspector
        [SerializeField]
        private PlayerAvatar.FaceTypes _faceType = DefaultValue;    //Set in inspector
        [SerializeField]
        private PlayerAvatar.EyesTypes _eyesType = DefaultValue;    //Set in inspector

        public void CreatePlayer()
        {
            try
            {
                _catStorage.CreatePlayer(_furryType, _faceType, _eyesType);
            }
            catch (PlayerAlreadyExistException e)
            {
                Debug.Log(e);
            }
        }

        private void Awake()
        {
            _catStorage = CatStorage.Instance;
        }
    }
}
