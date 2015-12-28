using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SecondField : MonoBehaviour
{
    public Presets presets;
    public Text text;
    public GameObject panel;
    public void OnPointerEnter()
    {
        if (presets.selectedPreset == "White")
        {
            panel.SetActive(true);
            text.text = "+ навыки повышаются быстрее,\n- сложно заслужить доверие предводителя.";
        }
        else if (presets.selectedPreset == "Brown")
        {
            panel.SetActive(true);
            text.text = "+ хорошие отношения с предводителем,\n- навыки повышаются медленнее.";
        }
        else if (presets.selectedPreset == "Ginger")
        {
            panel.SetActive(true);
            text.text = "+ требуется в 1,5-2 раза меньше энергии для охоты, рыбалки и сражений,\n- требуется на 3 единицы больше еды для насыщения.";
        }
        else if (presets.selectedPreset == "Gray")
        {
            panel.SetActive(true);
            text.text = "+ изначально хорошее отношение с целителем, наставником и оруженосцем,\n+ отношение с целителем, наставником и оруженосцем не падает ниже нейтрального,\n- меньше шансов на прощение при провале задания.";
        }
        else if (presets.selectedPreset == "Black")
        {
            panel.SetActive(true);
            text.text = "+ повышение настроения от длительного отсутствия общения,\n+ никто не обижается на отказ от Личных заданий,\n- сложно повысить репутацию в собственном племени.";
        }
    }
    public void OnPointerExit()
    {
        panel.SetActive(false);
    }
}