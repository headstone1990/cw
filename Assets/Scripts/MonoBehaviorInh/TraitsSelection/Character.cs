using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    string traitSelected; //Выбранный трейт, но еще не примененный.

    public Text descriptionText; //Текст описания.
    public Text titleText; //Заголовок Описания.
    //Текстовые поля содержащие русские названия выбранных трейтов.
    public Text trait0; 
    public Text trait1;
    public Text trait2;
    public Text trait3;
    public Text trait4;
    //Логические переменные обозначающие занят ли соответсвующий слот трейта.
    bool trait0Unfilled = true;
    bool trait1Unfilled = true;
    bool trait2Unfilled = true;
    bool trait3Unfilled = true;
    bool trait4Unfilled = true;

    //Методы вызывающиеся при нажатии на соответсвующую кнопку трейта.
    //Присваивают значения descriptionText.text, titleText.text и traitSelected.
    public void GoodHeartedSelect()
    {
        descriptionText.text = "+ проще получить доверие,\n+ проще добиться хороших отношений с домашними и одиночками,\n- если убиваешь кота, действует эффект " + '\u0022' + "Сломлен духом." + '\u0022';
        titleText.text = "Добросердечный.";
        traitSelected = "GoodHearted";
    }
    public void NotGoodHeartedSelect()
    {
        descriptionText.text = "+ не действует эффект " + '\u0022' + "Угрызение совести" + '\u0022' + ",\n- сложнее повысить свою репутацию.";
        titleText.text = "Жестокий.";
        traitSelected = "NotGoodHearted";
    }
    public void GoodSelect()
    {
        descriptionText.text = "+ проще стать целителем,\n- если замышляешь предательство или убийство, действует эффект" + '\u0022' + "Угрызение совести" + '\u0022';
        titleText.text = "Добрый.";
        traitSelected = "Good";
    }
    public void NotGoodSelect()
    {
        descriptionText.text = "+ никогда не действует эффект " + '\u0022' + "Угрызение совести" + '\u0022' + ",\n- сложно заслужить доверие целителя.";
        titleText.text = "Злой.";
        traitSelected = "NotGood";
    }
    public void SociableSelect()
    {
        descriptionText.text = "+ проще повысить репутацию в собственном племени,\n+ повышение настроения при общении и выполнении Личных заданий,\n- понижение настроения от длительного отсутствия общения.";
        titleText.text = "Общительный.";
        traitSelected = "Sociable";
    }
    public void NotSociableSelect()
    {
        descriptionText.text = "+ повышение настроения от длительного отсутствия общения,\n+ никто не обижается на отказ от Личных заданий,\n- сложно повысить репутацию в собственном племени.";
        titleText.text = "Одиночка.";
        traitSelected = "NotSociable";
    }
    public void VenturesomeSelect()
    {
        descriptionText.text = "+  больше дичи заметно во время охоты,\n- дичь движется быстрее.";
        titleText.text = "Азартный."; 
        traitSelected = "Venturesome";
    }
    public void NotVenturesomeSelect()
    {
        descriptionText.text = "+ дичь движется медленнее,\n- меньше дичи заметно во время охоты.";
        titleText.text = "Медлительный."; 
        traitSelected = "NotVenturesome";
    }
    public void CarefulSelect()
    {
        descriptionText.text = "+ изначально хорошее отношение с целителем, наставником и оруженосцем,\n+ отношение с целителем, наставником и оруженосцем не падает ниже нейтрального,\n- меньше шансов на прощение при провале задания.";
        titleText.text = "Аккуратный."; 
        traitSelected = "Careful";
    }
    public void NotCarefulSelect()
    {
        descriptionText.text = "+ больше шансов на прощение при провале задания,\n- отношение с целителем, наставником и оруженосцем не поднимается выше нормального.";
        titleText.text = "Неуклюжий."; 
        traitSelected = "NotCareful";
    }
    public void ActiveSelect()
    {
        descriptionText.text = "+ требуется в 1,5-2 раза меньше энергии для охоты, рыбалки и сражений,\n- требуется на 3 единицы больше еды для насыщения.";
        titleText.text = "Активный."; 
        traitSelected = "Active";
    }
    public void NotActiveSelect()
    {
        descriptionText.text = "+ требуется на 3 единицы меньше еды для насыщения,\n- требуется на 1 единицу больше энергии для охоты, рыбалки и сражений.";
        titleText.text = "Пассивный."; 
        traitSelected = "NotActive";
    }
    public void GenerousSelect()
    {
        descriptionText.text = "+ обмен у Пэньки Золотой Лапки стоит дешевле,\n+ больше шансов встретить Пэньку,\n- меньше ресурсов даётся в вознаграждение за задания.";
        titleText.text = "Щедрый."; 
        traitSelected = "Generous";
    }
    public void NotGenerousSelect()
    {
        descriptionText.text = "+ больше шансов найти предмет обычной редкости,\n- меньше шансов встретить Пэньку Золотую Лапку.";
        titleText.text = "Жадный."; 
        traitSelected = "NotGenerous";
    }
    public void AmbitiousSelect()
    {
        descriptionText.text = "+ навыки повышаются быстрее,\n- сложно заслужить доверие предводителя.";
        titleText.text = "Амбициозный."; 
        traitSelected = "Ambitious";
    }
    public void NotAmbitiousSelect()
    {
        descriptionText.text = "+ хорошие отношения с предводителем,\n- навыки повышаются медленнее.";
        titleText.text = "Не ждущий власти."; 
        traitSelected = "NotAmbitious";
    }
    public void HumoristSelect()
    {
        descriptionText.text = "+ поднимает настроение собеседника на 1 пункт,\n- приходится терпеть больше шалостей от котят.";
        titleText.text = "Весельчак."; 
        traitSelected = "Humorist";
    }
    public void NotHumoristSelect()
    {
        descriptionText.text = "+ нет шалостей от котят,\n- не может развеселить собеседника.";
        titleText.text = "Угрюмый."; 
        traitSelected = "NotHumorist";
    }
    public void BelievingSelect()
    {
        descriptionText.text = "+ хорошие отношения со Звёздным племенем,\n+ из такого персонажа получается более хороший целитель,\n- требуется больше на 1 час времени на сон.";
        titleText.text = "Верящий."; 
        traitSelected = "Believing";
    }
    public void NotBelievingSelect()
    {
        descriptionText.text = "+ требуется меньше на 1 час времени на сон,\n- плохие отношения со Звёздным племенем.";
        titleText.text = "Скептик."; 
        traitSelected = "NotBelieving";
    }
    public void CleverSelect()
    {
        descriptionText.text = "+ больше доверия от предводителя, старейшин и целителя,\n- требуется больше времени для увеличения характеристики силы.";
        titleText.text = "Умный."; 
        traitSelected = "Clever";
    }
    public void NotCleverSelect()
    {
        descriptionText.text = "+ быстрее повышается характеристика силы,\n- предводитель и целитель дают меньше поручений.";
        titleText.text = "Несообразительный."; 
        traitSelected = "NotClever";
    }
    public void GentleSelect()
    {
        descriptionText.text = "+ хорошие отношения со всеми котятами, королевами и старейшинами,\n- легко портится настроение.";
        titleText.text = "Нежный."; 
        traitSelected = "Gentle";
    }
    public void NotGentleSelect()
    {
        descriptionText.text = "+ реже портится настроение,\n- сложно заслужить доверие котят, королев и старейшин.";
        titleText.text = "Грубый."; 
        traitSelected = "NotGentle";
    }
    public void HardWorkingSelect()
    {
        descriptionText.text = "+ при опоздании на тренировку не портится отношение с наставником/оруженосцем,\n+ более внимательный во время тренировок,\n- чаще просят выполнить Общие задания.";
        titleText.text = "Трудолюбивый.";
        traitSelected = "HardWorking";
    }
    public void NotHardWorkingSelect()
    {
        descriptionText.text = "+ нет случайных заданий,\n- плохое отношение с наставником/оруженосцем.";
        titleText.text = "Ленивый."; 
        traitSelected = "NotHardWorking";
    }
    //Метод вызывающийся при нажатии на кнопку отмены, находящуюся под полем содержащим текст описания трейта.
    //Присваивftn значения descriptionText.text, titleText.text и traitSelected.
    public void Cancel()
    {
        descriptionText.text = "";
        titleText.text = "Описание.";
        traitSelected = null;
    }
//Дописать комментарии
    public void Apply()
    {

        if (traitSelected == "GoodHearted")
        {
            ApplyingTrait("GoodHearted", "NotGoodHearted");
        }
        else if (traitSelected == "NotGoodHearted")
        {
            ApplyingTrait("NotGoodHearted", "GoodHearted");
        }
        else if (traitSelected == "Good")
        {
            ApplyingTrait("Good", "NotGood");
        }
        else if (traitSelected == "NotGood")
        {
            ApplyingTrait("NotGood", "Good");
        }
        else if (traitSelected == "Sociable")
        {
            ApplyingTrait("Sociable", "NotSociable");
        }
        else if (traitSelected == "NotSociable")
        {
            ApplyingTrait("NotSociable", "Sociable");
        }
        else if (traitSelected == "Venturesome")
        {
            ApplyingTrait("Venturesome", "NotVenturesome");
        }
        else if (traitSelected == "NotVenturesome")
        {
            ApplyingTrait("NotVenturesome", "Venturesome");
        }
        else if (traitSelected == "Careful")
        {
            ApplyingTrait("Careful", "NotCareful");
        }
        else if (traitSelected == "NotCareful")
        {
            ApplyingTrait("NotCareful", "Careful");
        }
        else if (traitSelected == "Active")
        {
            ApplyingTrait("Active", "NotActive");
        }
        else if (traitSelected == "NotActive")
        {
            ApplyingTrait("NotActive", "Active");
        }
        else if (traitSelected == "Generous")
        {
            ApplyingTrait("Generous", "NotGenerous");
        }
        else if (traitSelected == "NotGenerous")
        {
            ApplyingTrait("NotGenerous", "Generous");
        }
        else if (traitSelected == "Ambitious")
        {
            ApplyingTrait("Ambitious", "NotAmbitious");
        }
        else if (traitSelected == "NotAmbitious")
        {
            ApplyingTrait("NotAmbitious", "Ambitious");
        }
        else if (traitSelected == "Humorist")
        {
            ApplyingTrait("Humorist", "NotHumorist");
        }
        else if (traitSelected == "NotHumorist")
        {
            ApplyingTrait("NotHumorist", "Humorist");
        }
        else if (traitSelected == "Believing")
        {
            ApplyingTrait("Believing", "NotBelieving");
        }
        else if (traitSelected == "NotBelieving")
        {
            ApplyingTrait("NotBelieving", "Believing");
        }
        else if (traitSelected == "Clever")
        {
            ApplyingTrait("Clever", "NotClever");
        }
        else if (traitSelected == "NotClever")
        {
            ApplyingTrait("NotClever", "Clever");
        }
        else if (traitSelected == "Gentle")
        {
            ApplyingTrait("Gentle", "NotGentle");
        }
        else if (traitSelected == "NotGentle")
        {
            ApplyingTrait("NotGentle", "Gentle");
        }
        else if (traitSelected == "HardWorking")
        {
            ApplyingTrait("HardWorking", "NotHardWorking");
        }
        else if (traitSelected == "NotHardWorking")
        {
            ApplyingTrait("NotHardWorking", "HardWorking");
        }
//

//


        TraitDisplay();
    }
    //Методы вызывающиеся при нажатии на кнопку Cancel расположенную справа от соответствующего трейта
    //Присваивают значение null соответствующим эллементам массива GlobalVariables.trait[] и вызывают метод TraitDisplay()
    public void CancelTrait0()
    {
        GlobalVariables.trait[0] = null;
        trait0Unfilled = true;
        TraitDisplay();
    }
    public void CancelTrait1()
    {
        GlobalVariables.trait[1] = null;
        trait1Unfilled = true;
        TraitDisplay();
    }
    public void CancelTrait2()
    {
        GlobalVariables.trait[2] = null;
        trait2Unfilled = true;
        TraitDisplay();
    }
    public void CancelTrait3()
    {
        GlobalVariables.trait[3] = null;
        trait3Unfilled = true;
        TraitDisplay();
    }
    public void CancelTrait4()
    {
        GlobalVariables.trait[4] = null;
        trait4Unfilled = true;
        TraitDisplay();
    }
//Дописать комментарии
    void ApplyingTrait(string applyingTrait, string Oppositetrait)
    {
        bool traitOpposite = false;
        bool traitAlreadySelected = false;
        foreach (string element in GlobalVariables.trait)
        {
            if (element == Oppositetrait)
            {
                traitOpposite = true;
                break;
            }
            else if (element == applyingTrait)
            {
                traitAlreadySelected = true;
                break;
            }
        }
        if (traitOpposite)
        {
            descriptionText.text = "Ты не можешь выбрать противоположную черту.";
        }
        else if (traitAlreadySelected) { }
        else
        {
            if (trait0Unfilled)
            {
                GlobalVariables.trait[0] = applyingTrait;
                trait0Unfilled = false;
            }
            else if (trait1Unfilled)
            {
                GlobalVariables.trait[1] = applyingTrait;
                trait1Unfilled = false;
            }
            else if (trait2Unfilled)
            {
                GlobalVariables.trait[2] = applyingTrait;
                trait2Unfilled = false;
            }
            else if (trait3Unfilled)
            {
                GlobalVariables.trait[3] = applyingTrait;
                trait3Unfilled = false;
            }
            else if (trait4Unfilled)
            {
                GlobalVariables.trait[4] = applyingTrait;
                trait4Unfilled = false;
            }
        }

    }
    void TraitDisplay()
    {
        trait0.text = TraitTranslate(0);
        trait1.text = TraitTranslate(1);
        trait2.text = TraitTranslate(2);
        trait3.text = TraitTranslate(3);
        trait4.text = TraitTranslate(4);
    }
//Дописать комментарии
    string TraitTranslate(int traitNumber)
    {
        string translatedTrait;
        if (GlobalVariables.trait[traitNumber] == "GoodHearted")
        {
            translatedTrait = "Добросердечный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotGoodHearted")
        {
            translatedTrait = "Жестокий";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Good")
        {
            translatedTrait = "Добрый";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotGood")
        {
            translatedTrait = "Злой";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Sociable")
        {
            translatedTrait = "Общительный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotSociable")
        {
            translatedTrait = "Одиночка";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Venturesome")
        {
            translatedTrait = "Азартный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotVenturesome")
        {
            translatedTrait = "Медлительный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Careful")
        {
            translatedTrait = "Аккуратный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotCareful")
        {
            translatedTrait = "Неуклюжий";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Active")
        {
            translatedTrait = "Активный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotActive")
        {
            translatedTrait = "Пассивный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Generous")
        {
            translatedTrait = "Щедрый";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotGenerous")
        {
            translatedTrait = "Жадный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Ambitious")
        {
            translatedTrait = "Амбициозный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotAmbitious")
        {
            translatedTrait = "Не ждущий власти";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Humorist")
        {
            translatedTrait = "Весельчак";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotHumorist")
        {
            translatedTrait = "Угрюмый";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Believing")
        {
            translatedTrait = "Верящий";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotBelieving")
        {
            translatedTrait = "Скептик";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Clever")
        {
            translatedTrait = "Умный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotClever")
        {
            translatedTrait = "Несообразительный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "Gentle")
        {
            translatedTrait = "Нежный";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotGentle")
        {
            translatedTrait = "Грубый";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "HardWorking")
        {
            translatedTrait = "Трудолюбивый";
            return translatedTrait;
        }
        else if (GlobalVariables.trait[traitNumber] == "NotHardWorking")
        {
            translatedTrait = "Ленивый";
            return translatedTrait;
        }
//


//
        else
        {
            return null;
        }
    }
}