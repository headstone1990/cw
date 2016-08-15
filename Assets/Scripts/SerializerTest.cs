namespace CW
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    using UnityEngine;
    public class SerializerTest : MonoBehaviour
    {
        private SerializableData _data1;
        private SerializableData _data2;
        BinaryFormatter _formatter = new BinaryFormatter();

        private void Start()
        {
            _data1 = new SerializableData();
            _data1.Dictionary.Add(0, "test1");
            _data1.Dictionary.Add(1, "test2");
        }

        public void Serialize()
        {
            FileStream stream = File.Create(@"C:\Users\HeadStone\Documents\save.dat");
            _formatter.Serialize(stream, _data1);
            stream.Close();
        }

        public void Deserialize()
        {
            FileStream stream = File.OpenRead(@"C:\Users\HeadStone\Documents\save.dat");
            _data2 = _formatter.Deserialize(stream) as SerializableData;
            stream.Close();
            if (_data2 == null) return;
            foreach (var pair in _data2.Dictionary)
            {
                Debug.Log(pair.Key);
                Debug.Log(pair.Value);
            }
        }
    }

    [System.Serializable]
    public class SerializableData
    {
        public int Test2 { get; set; }
        public string Test { get; set; }
        public Dictionary<int, string> Dictionary { get; set; }

        public SerializableData()
        {
            Dictionary = new Dictionary<int, string>();
        }
    }
}