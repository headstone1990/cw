using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CW.Backend
{
    public class CharacterNamesList
    {
        private Cat _parentCat;

        private Dictionary<Rang, CharacterName> _namesList = new Dictionary<Rang, CharacterName>();

        public CharacterNamesList(Cat parentCat)
        {
            _parentCat = parentCat;
        }

        public CharacterName this[Rang catRang]
        {
            get
            {
                switch (catRang)
                {
                    case Rang.Kit:
                        return _namesList[Rang.Kit];
                    case Rang.Apprentice:
                    case Rang.MedicineCatApprentice:
                        return _namesList[Rang.Apprentice];
                    case Rang.Warrior:
                    case Rang.SeniorWarrior:
                    case Rang.Deputy:
                    case Rang.Queen:
                    case Rang.MedicineCat:
                    case Rang.Elder:
                        return _namesList[Rang.Warrior];
                    case Rang.Leader:
                        return _namesList[Rang.Leader];
                    case Rang.Kittypet:
                        return _namesList[Rang.Kittypet];
                    case Rang.Loner:
                        return _namesList[Rang.Loner];
                    case Rang.Rogue:
                        return _namesList[Rang.Rogue];
                    default:
                        throw new ArgumentOutOfRangeException("catRang", catRang, "This Rang does not exist");
                }
            }
            set
            {
                switch (catRang)
                {
                    case Rang.Kit:
                        _namesList[Rang.Kit] = value;
                        break;
                    case Rang.Apprentice:
                    case Rang.MedicineCatApprentice:
                        _namesList[Rang.Apprentice] = value;
                        break;
                    case Rang.Warrior:
                    case Rang.SeniorWarrior:
                    case Rang.Deputy:
                    case Rang.Queen:
                    case Rang.MedicineCat:
                    case Rang.Elder:
                        _namesList[Rang.Warrior] = value;
                        break;
                    case Rang.Leader:
                        _namesList[Rang.Leader] = value;
                        break;
                    case Rang.Kittypet:
                        _namesList[Rang.Kittypet] = value;
                        break;
                    case Rang.Loner:
                        _namesList[Rang.Loner] = value;
                        break;
                    case Rang.Rogue:
                        _namesList[Rang.Rogue] = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("catRang", catRang, "This Rang does not exist");
                }
            }
        }

        public CharacterName CurrentName
        {
            get
            {
                switch (_parentCat.Rang)
                {
                    case Rang.Kit:
                        return _namesList[Rang.Kit];
                    case Rang.Apprentice:
                    case Rang.MedicineCatApprentice:
                        return _namesList[Rang.Apprentice];
                    case Rang.Warrior:
                    case Rang.SeniorWarrior:
                    case Rang.Deputy:
                    case Rang.Queen:
                    case Rang.MedicineCat:
                    case Rang.Elder:
                        return _namesList[Rang.Warrior];
                    case Rang.Leader:
                        return _namesList[Rang.Leader];
                    case Rang.Kittypet:
                        return _namesList[Rang.Kittypet];
                    case Rang.Loner:
                        return _namesList[Rang.Loner];
                    case Rang.Rogue:
                        return _namesList[Rang.Rogue];
                    default:
                        throw new InvalidEnumArgumentException("This Rang does not exist");
                }
            }
        }

        public class CharacterName
        {
            private string _russianName;
            private string _englishName;

            public string RussianNameSet
            {
                set { _russianName = value; }
            }
            public string EnglishNameSet
            {
                set { _englishName = value; }
            }
            
            //Функционал недоделан
            public string CurrentLanguageName
            {            
                get { return _russianName; }
            }

            public override string ToString()
            {
                return CurrentLanguageName;
            }
        }
    }
}
