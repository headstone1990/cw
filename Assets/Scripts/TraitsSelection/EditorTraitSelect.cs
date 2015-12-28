using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
        switch (_traitSelectedString)
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

    private string ReverseConvert()
    {
        switch (_traitSelected)
        {
                
        }
    }

    public void TraitSelect(string trait, string description)
    {
        TraitSelectedString = trait;
        DescriptionObj.text = description;
        TitleObj.text = trait + ".";
    }

    public void Apply()
    {
        Traits oppositeTrait;
        bool alreadySelected = false;
        bool oppositeSelected = false;
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
            DescriptionObj.text = "Эта чера характера уже выбрана";
        }
        else if (oppositeSelected)
        {
            DescriptionObj.text = "Выбрана противоположенная черта характера";
        }
        else
        {
            for (int i = 0; i < TraitField.Length; i++)
            {
                if (string.IsNullOrEmpty(TraitField[i].text))
                {
                    
                }
            }
        }



    }


}
