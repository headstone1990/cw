using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FourthField : MonoBehaviour
{
    public Presets presets;
    public Text text;
    public GameObject panel;
    public void OnPointerEnter()
    {
        if (presets.selectedPreset == "White")
        {
            panel.SetActive(true);
            text.text = "+ реже портится настроение,\n- сложно заслужить доверие котят, королев и старейшин.";
        }
        else if (presets.selectedPreset == "Brown")
        {
            panel.SetActive(true);
            text.text = "+ при опоздании на тренировку не портится отношение с наставником/оруженосцем,\n+ более внимательный во время тренировок,\n- чаще просят выполнить Общие задания.";
        }
        else if (presets.selectedPreset == "Ginger")
        {
            panel.SetActive(true);
            text.text = "+ хорошие отношения со всеми котятами, королевами и старейшинами,\n- легко портится настроение.";
        }
        else if (presets.selectedPreset == "Gray")
        {
            panel.SetActive(true);
            text.text = "+ хорошие отношения с предводителем,\n- навыки повышаются медленнее.";
        }
        else if (presets.selectedPreset == "Black")
        {
            panel.SetActive(true);
            text.text = "+ обмен у Пэньки Золотой Лапки стоит дешевле,\n+ больше шансов встретить Пэньку,\n- меньше ресурсов даётся в вознаграждение за задания.";
        }
    }
    public void OnPointerExit()
    {
        panel.SetActive(false);
    }
}