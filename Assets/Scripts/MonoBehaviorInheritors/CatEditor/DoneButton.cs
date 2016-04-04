using MonoBehaviorInh.CatEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MonoBehaviorInheritors.CatEditor
{
    [RequireComponent(typeof(CatIntegrityChecker))]
    [RequireComponent(typeof(FullCatImageSaver))]
    public class DoneButton : MonoBehaviour
    {
        [SerializeField] private string _loadedScene = null; //Set in inspector
        private FullCatImageSaver _imageSaver;
        private CatIntegrityChecker _catIntegrityChecker;

        private void Awake()
        {
            _imageSaver = GetComponent<FullCatImageSaver>();
            _catIntegrityChecker = GetComponent<CatIntegrityChecker>();
        }
        public void Click()
        {
            if (!_catIntegrityChecker.IsSetValuesForRequiredParts()) return;
            _imageSaver.SaveCatImage();
            SceneManager.LoadScene(_loadedScene);
        }
    }
}