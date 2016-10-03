namespace CW.Backend
{
    using System.Collections.Generic;
    using global::MonoBehaviorInheritors.Main;
    using UnityEngine;

    public abstract class Cat
    {
        private readonly IngameTime _birthday;

        protected Cat(IngameTime birthday)
        {
            Characteristics = new Characteristics();
            Traits = new List<Traits>();
            _birthday = birthday;
            LocalizedNames = new CharacterNamesList(this);
        }

        public Texture2D Avatar { get; set; }

        private CatsAction _currentAction;

        public Characteristics Characteristics { get; set; }

        public string Clan { get; set; }

        public bool IsMale { get; set; }

        public string Name { get; set; }

        public CharacterNamesList LocalizedNames { get; set; }


        public Rang Rang { get; set; }

        public List<Traits> Traits { get; set; }

        public IngameTimeInterval Age
        {
            get { return TimeController.CurrentTime - _birthday; }
        }

        public IngameTime DebugBirthdaySetter
        {
            set
            {
                //W_birthday = value;
            }
        }

        protected LinkedList<CatsAction> PreviousActions { get; set; }

        public void Die() {
           
        }
    }
}