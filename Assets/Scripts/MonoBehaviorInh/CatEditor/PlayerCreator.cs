using System;
using UnityEngine;
using UserExceptions;

namespace MonoBehaviorInh.CatEditor
{
    public class PlayerCreator : MonoBehaviour {
        private CatStorage _catStorage;

        [SerializeField]
        private PlayerAvatar.FurryTypes _furryType = DefaultValue;
        [SerializeField]
        private PlayerAvatar.FaceTypes _faceType = DefaultValue;
        [SerializeField]
        private PlayerAvatar.EyesTypes _eyesType = DefaultValue;

        private const int DefaultValue = 0;


        private void Awake ()
        {
            _catStorage = GameObject.FindWithTag("CatStorage").GetComponent<CatStorage>();
        }

        public void CreatePlayer()
        {
            try
            {
                _catStorage.CreatePlayer(_furryType, _faceType, _eyesType);
            }
            catch (MoreThanOnePlayerCreatedException e)
            {
                Debug.Log(e);
            }
        }
    }
}
