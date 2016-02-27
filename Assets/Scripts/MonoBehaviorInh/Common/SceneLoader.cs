using UnityEngine;
using UnityEngine.SceneManagement;

namespace MonoBehaviorInh.Common
{
    public class SceneLoader : MonoBehaviour {

        [SerializeField]
        private string _location;

        public void LoadScene()
        {
            SceneManager.LoadScene(_location);
        }

    }
}
