using CW.Backend;
using CW.Backend.MonoBehaviorInheritors;

using MonoBehaviorInh;
using MonoBehaviorInheritors;
using MonoBehaviorInheritors.Main;
using MonoBehaviorInheritors.TraitsSelection;
using UnityEngine;
using UnityEngine.UI;

public class TraitSelectorController : MonoBehaviour
{
    private Traits _selectedTrait; //Выбранный трейт, но еще не примененный.
    private string _selectedTraitLocalizedString;
    private Player _player;
    [SerializeField]
    private Text _description; //Текст описания.
    [SerializeField]
    private Text _title; //Заголовок Описания


    //Текстовые поля содержащие русские названия выбранных трейтов.
    [SerializeField]
    private Text[] _traitFields;


    private void Awake()
    {
        _player = CatStorage.Instance.Player;
    }
//    private void Convert()
//    {
//        switch (_selectedTraitLocalizedString)
//        {
//            case "Добросердечный":
//            case "Goodhearted":
//                _selectedTrait = Traits.Goodhearted;
//                break;
//            case "Жестокий":
//            case "NotGoodhearted":
//                _selectedTrait = Traits.NotGoodhearted;
//                break;
//            case "Добрый":
//            case "Good":
//                _selectedTrait = Traits.Good;
//                break;
//            case "Злой":
//            case "NotGood":
//                _selectedTrait = Traits.NotGood;
//                break;
//            case "Общительный":
//            case "Sociable":
//                _selectedTrait = Traits.Sociable;
//                break;
//            case "Одиночка":
//            case "NotSociable":
//                _selectedTrait = Traits.NotSociable;
//                break;
//            case "Азартный":
//            case "Venturesome":
//                _selectedTrait = Traits.Venturesome;
//                break;
//            case "Медлительный":
//            case "NotVenturesome":
//                _selectedTrait = Traits.NotVenturesome;
//                break;
//            case "Аккуратный":
//            case "Careful":
//                _selectedTrait = Traits.Careful;
//                break;
//            case "Неуклюжий":
//            case "NotCareful":
//                _selectedTrait = Traits.NotCareful;
//                break;
//            case "Активный":
//            case "Active":
//                _selectedTrait = Traits.Active;
//                break;
//            case "Пассивный":
//            case "NotActive":
//                _selectedTrait = Traits.Active;
//                break;
//            case "Щедрый":
//            case "Generous":
//                _selectedTrait = Traits.Generous;
//                break;
//            case "Жадный":
//            case "NotGenerous":
//                _selectedTrait = Traits.NotGenerous;
//                break;
//            case "Амбициозный":
//            case "Ambitious":
//                _selectedTrait = Traits.Ambitious;
//                break;
//            case "Не ждущий власти":
//            case "NotAmbitious":
//                _selectedTrait = Traits.NotAmbitious;
//                break;
//            case "Весельчак":
//            case "Humorist":
//                _selectedTrait = Traits.Humorist;
//                break;
//            case "Угрюмый":
//            case "NotHumorist":
//                _selectedTrait = Traits.NotHumorist;
//                break;
//            case "Верящий":
//            case "Believing":
//                _selectedTrait = Traits.Believing;
//                break;
//            case "Скептик":
//            case "NotBelieving":
//                _selectedTrait = Traits.NotBelieving;
//                break;
//            case "Умный":
//            case "Clever":
//                _selectedTrait = Traits.Clever;
//                break;
//            case "Несообразительный":
//            case "NotClever":
//                _selectedTrait = Traits.NotClever;
//                break;
//            case "Нежный":
//            case "Gentle":
//                _selectedTrait = Traits.Gentle;
//                break;
//            case "Грубый":
//            case "NotGentle":
//                _selectedTrait = Traits.NotGentle;
//                break;
//            case "Трудолюбивый":
//            case "Hardworking":
//                _selectedTrait = Traits.Hardworking;
//                break;
//            case "Ленивый":
//            case "NotHardworking":
//                _selectedTrait = Traits.NotHardworking;
//                break;
//        }
//    }

//    private Traits ConvertWithReturn(string i)
//    {
//        switch (i)
//        {
//            case "Добросердечный":
//            case "Goodhearted":
//                return Traits.Goodhearted;;
//            case "Жестокий":
//            case "NotGoodhearted":
//                return Traits.NotGoodhearted;
//            case "Добрый":
//            case "Good":
//               return Traits.Good;
//            case "Злой":
//            case "NotGood":
//                return Traits.NotGood;
//            case "Общительный":
//            case "Sociable":
//                return Traits.Sociable;
//            case "Одиночка":
//            case "NotSociable":
//                return Traits.NotSociable;
//            case "Азартный":
//            case "Venturesome":
//                return Traits.Venturesome;
//            case "Медлительный":
//            case "NotVenturesome":
//               return Traits.NotVenturesome;
//            case "Аккуратный":
//            case "Careful":
//               return Traits.Careful;
//            case "Неуклюжий":
//            case "NotCareful":
//                return Traits.NotCareful;
//            case "Активный":
//            case "Active":
//                return Traits.Active;
//            case "Пассивный":
//            case "NotActive":
//                return Traits.Active;
//            case "Щедрый":
//            case "Generous":
//                return Traits.Generous;
//            case "Жадный":
//            case "NotGenerous":
//                return Traits.NotGenerous;
//            case "Амбициозный":
//            case "Ambitious":
//                return Traits.Ambitious;
//            case "Не ждущий власти":
//            case "NotAmbitious":
//                return Traits.NotAmbitious;
//            case "Весельчак":
//            case "Humorist":
//                return Traits.Humorist;
//            case "Угрюмый":
//            case "NotHumorist":
//                return Traits.NotHumorist;
//            case "Верящий":
//            case "Believing":
//                return Traits.Believing;
//            case "Скептик":
//            case "NotBelieving":
//                return Traits.NotBelieving;
//            case "Умный":
//            case "Clever":
//                return Traits.Clever;
//            case "Несообразительный":
//            case "NotClever":
//                return Traits.NotClever;
//            case "Нежный":
//            case "Gentle":
//                return Traits.Gentle;
//            case "Грубый":
//            case "NotGentle":
//                return Traits.NotGentle;
//            case "Трудолюбивый":
//            case "Hardworking":
//                return Traits.Hardworking;
//            case "Ленивый":
//            case "NotHardworking":
//                return Traits.NotHardworking;
//            default:
//                return 0;
//        }
//    }

    //private string ReverseConvert()
    //{
    //    switch (_selectedTrait)
    //    {
    //        case Traits.Goodhearted:
    //            return "Добросердечный";
    //        case Traits.NotGoodhearted:
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
    //        case Traits.Hardworking:
    //            return "Трудолюбивый";
    //        case Traits.NotHardworking:
    //            return "Ленивый";
    //        default:
    //            return null;
    //    }
    //}

    public void TraitSelect(Traits selectedTrait, string selectedTraitLocalizedString, string description)
    {
        _selectedTrait = selectedTrait;
        _selectedTraitLocalizedString = selectedTraitLocalizedString;
        _description.text = description;
        _title.text = selectedTraitLocalizedString + ".";

        //        SelectedTraitLocalizedString = trait;
        //        _description.text = description;
        //        _title.text = trait + ".";
    }
    public void TraitDeselect()
    {
        _selectedTrait = 0;
        _title.text = "Описание";
        _description.text = "";
    }
    public void Apply()
    {
        bool alreadySelected = false;
        bool oppositeSelected = false;
        if (_player.Traits.Count < 5)
        {
            Traits oppositeTrait;
            if ((int)_selectedTrait % 2 == 0)
            {
                oppositeTrait = _selectedTrait - 1; //Негативный трейт, противоположенный - позитивный
            }
            else
            {
                oppositeTrait = _selectedTrait + 1; //Позитивный трейт, противоположенный - негативный
            }

            foreach (Traits e in _player.Traits)
            {
                if (e == _selectedTrait)
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
                _description.text = "Эта черта характера уже выбрана";
            }
            else if (oppositeSelected)
            {
                _description.text = "Выбрана противоположенная черта характера";
            }
            else if (_selectedTrait == 0)
            {
                _description.text = "Вы не выбрали черту характера";
            }
            else
            {
                _player.Traits.Add(_selectedTrait);
                foreach (var e in _traitFields)
                {
                    if (string.IsNullOrEmpty(e.text))
                    {
                        e.text = _selectedTraitLocalizedString;
                        e.GetComponent<SelectedTraitStorage>().SelectedTrait = _selectedTrait;
                        break;
                    }
                }
            }
        }
        else
        {
            _description.text = "Нельзя выбрать больше 5 черт характера";
        }
    }
    public void Cancel(Text i)
    {
        _player.Traits.Remove(i.GetComponent<SelectedTraitStorage>().SelectedTrait);
        i.text = null;
    }


}
