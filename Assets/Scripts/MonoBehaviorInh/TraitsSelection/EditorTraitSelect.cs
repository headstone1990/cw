using MonoBehaviorInh;
using UnityEngine;
using UnityEngine.UI;

public class EditorTraitSelect : MonoBehaviour
{
    private Traits _traitSelected; //Выбранный трейт, но еще не примененный.
    private string _traitSelectedString;
    private Player _player;
    public Text DescriptionObj; //Текст описания.
    public Text TitleObj; //Заголовок Описания


    //Текстовые поля содержащие русские названия выбранных трейтов.

    public Text[] TraitField = new Text[5];

    private string TraitSelectedString
    {
        get
        {
            return _traitSelectedString;
        }

        set
        {
            _traitSelectedString = value;
            Convert();
        }
    }

    private void Awake()
    {
        _player = GameObject.FindWithTag("CatStorage").GetComponent<CatStorage>().Player;
    }
    private void Convert()
    {
        switch (TraitSelectedString)
        {
            case "Добросердечный":
            case "GoodHearted":
                _traitSelected = Traits.GoodHearted;
                break;
            case "Жестокий":
            case "NotGoodHearted":
                _traitSelected = Traits.NotGoodHearted;
                break;
            case "Добрый":
            case "Good":
                _traitSelected = Traits.Good;
                break;
            case "Злой":
            case "NotGood":
                _traitSelected = Traits.NotGood;
                break;
            case "Общительный":
            case "Sociable":
                _traitSelected = Traits.Sociable;
                break;
            case "Одиночка":
            case "NotSociable":
                _traitSelected = Traits.NotSociable;
                break;
            case "Азартный":
            case "Venturesome":
                _traitSelected = Traits.Venturesome;
                break;
            case "Медлительный":
            case "NotVenturesome":
                _traitSelected = Traits.NotVenturesome;
                break;
            case "Аккуратный":
            case "Careful":
                _traitSelected = Traits.Careful;
                break;
            case "Неуклюжий":
            case "NotCareful":
                _traitSelected = Traits.NotCareful;
                break;
            case "Активный":
            case "Active":
                _traitSelected = Traits.Active;
                break;
            case "Пассивный":
            case "NotActive":
                _traitSelected = Traits.Active;
                break;
            case "Щедрый":
            case "Generous":
                _traitSelected = Traits.Generous;
                break;
            case "Жадный":
            case "NotGenerous":
                _traitSelected = Traits.NotGenerous;
                break;
            case "Амбициозный":
            case "Ambitious":
                _traitSelected = Traits.Ambitious;
                break;
            case "Не ждущий власти":
            case "NotAmbitious":
                _traitSelected = Traits.NotAmbitious;
                break;
            case "Весельчак":
            case "Humorist":
                _traitSelected = Traits.Humorist;
                break;
            case "Угрюмый":
            case "NotHumorist":
                _traitSelected = Traits.NotHumorist;
                break;
            case "Верящий":
            case "Believing":
                _traitSelected = Traits.Believing;
                break;
            case "Скептик":
            case "NotBelieving":
                _traitSelected = Traits.NotBelieving;
                break;
            case "Умный":
            case "Clever":
                _traitSelected = Traits.Clever;
                break;
            case "Несообразительный":
            case "NotClever":
                _traitSelected = Traits.NotClever;
                break;
            case "Нежный":
            case "Gentle":
                _traitSelected = Traits.Gentle;
                break;
            case "Грубый":
            case "NotGentle":
                _traitSelected = Traits.NotGentle;
                break;
            case "Трудолюбивый":
            case "HardWorking":
                _traitSelected = Traits.HardWorking;
                break;
            case "Ленивый":
            case "NotHardWorking":
                _traitSelected = Traits.NotHardWorking;
                break;
        }
    }

    private Traits ConvertWithReturn(string i)
    {
        switch (i)
        {
            case "Добросердечный":
            case "GoodHearted":
                return Traits.GoodHearted;;
            case "Жестокий":
            case "NotGoodHearted":
                return Traits.NotGoodHearted;               
            case "Добрый":
            case "Good":
               return Traits.Good;                
            case "Злой":
            case "NotGood":
                return Traits.NotGood;                
            case "Общительный":
            case "Sociable":
                return Traits.Sociable;
            case "Одиночка":
            case "NotSociable":
                return Traits.NotSociable;
            case "Азартный":
            case "Venturesome":
                return Traits.Venturesome;
            case "Медлительный":
            case "NotVenturesome":
               return Traits.NotVenturesome;
            case "Аккуратный":
            case "Careful":
               return Traits.Careful;
            case "Неуклюжий":
            case "NotCareful":
                return Traits.NotCareful;
            case "Активный":
            case "Active":
                return Traits.Active;
            case "Пассивный":
            case "NotActive":
                return Traits.Active;
            case "Щедрый":
            case "Generous":
                return Traits.Generous;
            case "Жадный":
            case "NotGenerous":
                return Traits.NotGenerous;
            case "Амбициозный":
            case "Ambitious":
                return Traits.Ambitious;
            case "Не ждущий власти":
            case "NotAmbitious":
                return Traits.NotAmbitious;
            case "Весельчак":
            case "Humorist":
                return Traits.Humorist;
            case "Угрюмый":
            case "NotHumorist":
                return Traits.NotHumorist;
            case "Верящий":
            case "Believing":
                return Traits.Believing;
            case "Скептик":
            case "NotBelieving":
                return Traits.NotBelieving;
            case "Умный":
            case "Clever":
                return Traits.Clever;
            case "Несообразительный":
            case "NotClever":
                return Traits.NotClever;
            case "Нежный":
            case "Gentle":
                return Traits.Gentle;
            case "Грубый":
            case "NotGentle":
                return Traits.NotGentle;
            case "Трудолюбивый":
            case "HardWorking":
                return Traits.HardWorking;
            case "Ленивый":
            case "NotHardWorking":
                return Traits.NotHardWorking;
            default:
                return 0;
        }
    }

    //private string ReverseConvert()
    //{
    //    switch (_traitSelected)
    //    {
    //        case Traits.GoodHearted:
    //            return "Добросердечный";
    //        case Traits.NotGoodHearted:
    //            return "Жестокий";
    //        case Traits.Good:
    //            return "Добрый";
    //        case Traits.NotGood:
    //            return "Злой";
    //        case Traits.Sociable:
    //            return "Общительный";
    //        case Traits.NotSociable:
    //            return "Одиночка";
    //        case Traits.Venturesome:
    //            return "Азартный";
    //        case Traits.NotVenturesome:
    //            return "Медлительный";
    //        case Traits.Careful:
    //            return "Аккуратный";
    //        case Traits.NotCareful:
    //            return "Неуклюжий";
    //        case Traits.Active:
    //            return "Активный";
    //        case Traits.NotActive:
    //            return "Пассивный";
    //        case Traits.Generous:
    //            return "Щедрый";
    //        case Traits.NotGenerous:
    //            return "Жадный";
    //        case Traits.Ambitious:
    //            return "Амбициозный";
    //        case Traits.NotAmbitious:
    //            return "Не ждущий власти";
    //        case Traits.Humorist:
    //            return "Весельчак";
    //        case Traits.NotHumorist:
    //            return "Угрюмый";
    //        case Traits.Believing:
    //            return "Верящий";
    //        case Traits.NotBelieving:
    //            return "Скептик";
    //        case Traits.Clever:
    //            return "Умный";
    //        case Traits.NotClever:
    //            return "Несообразительный";
    //        case Traits.Gentle:
    //            return "Нежный";
    //        case Traits.NotGentle:
    //            return "Грубый";
    //        case Traits.HardWorking:
    //            return "Трудолюбивый";
    //        case Traits.NotHardWorking:
    //            return "Ленивый";
    //        default:
    //            return null;
    //    }
    //}

    public void TraitSelect(string trait, string description)
    {
        TraitSelectedString = trait;
        DescriptionObj.text = description;
        TitleObj.text = trait + ".";
    }
    public void TraitDeselect()
    {
        _traitSelected = 0;
        TitleObj.text = "Описание";
        DescriptionObj.text = "";
    }
    public void Apply()
    {
        bool alreadySelected = false;
        bool oppositeSelected = false;
        if (_player.Traits.Count < 5)
        {
            Traits oppositeTrait;
            if ((int)_traitSelected % 2 == 0)
            {
                oppositeTrait = _traitSelected - 1; //Негативный трейт, противоположенный - позитивный
            }
            else
            {
                oppositeTrait = _traitSelected + 1; //Позитивный трейт, противоположенный - негативный
            }

            foreach (Traits e in _player.Traits)
            {
                if (e == _traitSelected)
                {
                    alreadySelected = true;
                }
                else if (e == oppositeTrait)
                {
                    oppositeSelected = true;
                }
            }

            if (alreadySelected)
            {
                DescriptionObj.text = "Эта черта характера уже выбрана";
            }
            else if (oppositeSelected)
            {
                DescriptionObj.text = "Выбрана противоположенная черта характера";
            }
            else if (_traitSelected == 0)
            {
                DescriptionObj.text = "Вы не выбрали черту характера";
            }
            else
            {
                _player.Traits.Add(_traitSelected);
                foreach (var e in TraitField)
                {
                    if (string.IsNullOrEmpty(e.text))
                    {
                        e.text = _traitSelectedString;
                        break;
                    }
                }
            }
        }
        else
        {
            DescriptionObj.text = "Нельзя выбрать больше 5 черт характера";
        }
    }
    public void Cancel(Text i)
    {
        _player.Traits.Remove(ConvertWithReturn(i.text));
        i.text = null;
    }


}
