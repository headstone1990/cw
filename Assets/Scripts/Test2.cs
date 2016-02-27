using UnityEngine;
using UnityEngine.UI;
public enum TestEnum
{
    Test1,
    Test2,
    Test3
}
public class Test2 : MonoBehaviour
{
    [SerializeField]
    private TestEnum _testEnum1;
    private TestEnum _testEnum2;
    private TestEnum _testEnum3;
    [SerializeField]
    private Text _testText;

    [SerializeField]
    private int _testInt;

    public void Test()
    {
        _testEnum1 = TestEnum.Test1;
        _testEnum2 = TestEnum.Test2;
        _testEnum3 = TestEnum.Test3;
        string testString = _testEnum1 + " " +  _testEnum2 + " " + _testEnum3;
        _testText.text = testString;
    }
}
