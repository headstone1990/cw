using UnityEngine;
using UnityEngine.UI;

public class  SaveSelect: MonoBehaviour
{
    Button button;

    void OnEnable()
    {
        button = GetComponent<Button>();
        button.Select();
    }

}
