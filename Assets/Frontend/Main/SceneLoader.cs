namespace CW.Frontend.Main
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class SceneLoader : MonoBehaviour
    {
        [SerializeField]
        private string _location = null; // Set in inspector

        public void LoadScene()
        {
            SceneManager.LoadScene(_location);   
        }
    }
}
