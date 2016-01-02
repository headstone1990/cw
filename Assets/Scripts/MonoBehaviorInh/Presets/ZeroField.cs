using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZeroField : MonoBehaviour
{
    public Presets presets;
    public Text text;
    public GameObject panel;
    public void OnPointerEnter()
    {
        if (presets.selectedPreset == "White")
        {
            panel.SetActive(true);
            text.text = "+ не действует эффект " + '\u0022' + "Угрызение совести" + '\u0022' + ",\n- сложнее повысить свою репутацию.";
        }
        else if (presets.selectedPreset == "Brown")
        {
            panel.SetActive(true);
            text.text = "+ проще стать целителем,\n- если замышляешь предательство или убийство, действует эффект" + '\u0022' + "Угрызение совести" + '\u0022';
        }
        else if (presets.selectedPreset == "Ginger")
        {
            panel.SetActive(true);
            text.text = "+ проще получить доверие,\n+ проще добиться хороших отношений с домашними и одиночками,\n- если убиваешь кота, действует эффект " + '\u0022' + "Сломлен духом." + '\u0022';
        }
        else if (presets.selectedPreset == "Gray")
        {
            panel.SetActive(true);
            text.text = "+ повышение настроения от длительного отсутствия общения,\n+ никто не обижается на отказ от Личных заданий,\n- сложно повысить репутацию в собственном племени.";
        }
        else if (presets.selectedPreset == "Black")
        {
            panel.SetActive(true);
            text.text = "+ требуется меньше на 1 час времени на сон,\n- плохие отношения со Звёздным племенем.";
        }
    }
    public void OnPointerExit()
    {
        panel.SetActive(false);
    }
}