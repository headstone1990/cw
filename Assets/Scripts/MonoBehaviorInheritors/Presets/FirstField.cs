using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FirstField : MonoBehaviour
{
    public Presets presets;
    public Text text;
    public GameObject panel;
    public void OnPointerEnter()
    {
        if (presets.selectedPreset == "White")
        {
            panel.SetActive(true);
            text.text = "+  больше дичи заметно во время охоты,\n- дичь движется быстрее.";
        }
        else if (presets.selectedPreset == "Brown")
        {
            panel.SetActive(true);
            text.text = "+ нет шалостей от котят,\n- не может развеселить собеседника.";
        }
        else if (presets.selectedPreset == "Ginger")
        {
            panel.SetActive(true);
            text.text = "+ проще повысить репутацию в собственном племени,\n+ повышение настроения при общении и выполнении Личных заданий,\n- понижение настроения от длительного отсутствия общения.";
        }
        else if (presets.selectedPreset == "Gray")
        {
            panel.SetActive(true);
            text.text = "+ дичь движется медленнее,\n- меньше дичи заметно во время охоты.";
        }
        else if (presets.selectedPreset == "Black")
        {
            panel.SetActive(true);
            text.text = "+ реже портится настроение,\n- сложно заслужить доверие котят, королев и старейшин.";
        }
    }
    public void OnPointerExit()
    {
        panel.SetActive(false);
    }
}