using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Tests.SOSaving.SO
{
    [CreateAssetMenu(menuName = "Data/CatDataStorage")]
    public class CatDataStorage : ScriptableObject
    {
        public List<CatData> CatDatas;

        public void ToJson(string slot)
        {
            string saveFileName = Application.persistentDataPath + "/Save_" + slot+ ".save";
            var json = JsonUtility.ToJson(this, true);
            File.WriteAllText(saveFileName, json);
        }

        public void FromJson(string slot)
        {
            string saveFileName = Application.persistentDataPath + "/Save_" + slot+ ".save";
            var json = File.ReadAllText(saveFileName);
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}