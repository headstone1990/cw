using System.Collections.Generic;
using Tests.SOSaving.SO;

namespace Tests.SOSaving
{
    public class TestCatStorage
    {
        private List<TestCat> _testCats;

        public TestCatStorage()
        {
            _testCats = new List<TestCat>();
        }

        public List<TestCat> TestCats
        {
            get { return _testCats; }
            set { _testCats = value; }
        }

        public void InitCats(List<CatData> catDatas)
        {
            foreach (var catData in catDatas)
            {
                _testCats.Add(new TestCat(catData));
            }
        }
    }
}