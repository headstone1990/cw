using System;
using Tests.SOSaving.SO;
using UnityEngine;

namespace Tests.SOSaving
{
    public class Script : MonoBehaviour
    {
        private TestCatStorage _testCatStorage;
        [SerializeField]
        private CatDataStorage _catDataStorage;
        private void Start()
        {
            CreateCat();
        }

        private void CreateCat()
        {
            _testCatStorage = new TestCatStorage();
            _catDataStorage.FromJson("2");
            _testCatStorage.InitCats(_catDataStorage.CatDatas);
            foreach (var cat in _testCatStorage.TestCats)
            {
                Debug.Log(cat.Data.Name);
            }
            //_catDataStorage.ToJson("2");
        }
    }
}