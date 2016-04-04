using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThirdField : MonoBehaviour
{
    public Presets presets;
    public Text text;
    public GameObject panel;
    public void OnPointerEnter()
    {
        if (presets.selectedPreset == "White")
        {
            panel.SetActive(true);
            text.text = "+ больше доверия от предводителя, старейшин и целителя,\n- требуется больше времени для увеличения характеристики силы.";
        }
        else if (presets.selectedPreset == "Brown")
        {
            panel.SetActive(true);
            text.text = "+ обмен у Пэньки Золотой Лапки стоит дешевле,\n+ больше шансов встретить Пэньку,\n- меньше ресурсов даётся в вознаграждение за задания.";
        }
        else if (presets.selectedPreset == "Ginger")
        {
            panel.SetActive(true);
            text.text = "+ поднимает настроение собеседника на 1 пункт,\n- приходится терпеть больше шалостей от котят.";
        }
        else if (presets.selectedPreset == "Gray")
        {
            panel.SetActive(true);
            text.text = "+ хорошие отношения со Звёздным племенем,\n+ из такого персонажа получается более хороший целитель,\n- требуется больше на 1 час времени на сон.";
        }
        else if (presets.selectedPreset == "Black")
        {
            panel.SetActive(true);
            text.text = "+ навыки повышаются быстрее,\n- сложно заслужить доверие предводителя.";
        }
    }
    public void OnPointerExit()
    {
        panel.SetActive(false);
    }
}