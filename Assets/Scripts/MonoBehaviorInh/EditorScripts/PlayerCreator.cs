using UnityEngine;

namespace MonoBehaviorInh.EditorScripts
{
    public class PlayerCreator : MonoBehaviour {
        private CatStorage _catStorage;

        [SerializeField]
        private PlayerAvatar.FurryTypes _furryType;
        [SerializeField]
        private PlayerAvatar.FaceTypes _faceType;
        [SerializeField]
        private PlayerAvatar.EyesTypes _eyesType;


        private void Awake ()
        {
            _catStorage = GameObject.FindWithTag("CatStorage").GetComponent<CatStorage>();
        }

        public void CreatePlayer()
        {
            _catStorage.CreatePlayer(_furryType, _faceType, _eyesType);
        }
    }
}
