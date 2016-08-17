namespace CW.Backend
{
    using System.Collections.Generic;
    using global::MonoBehaviorInheritors.Main;
    using UnityEngine;

    public abstract class Cat
    {
        private IngameTime _birthday;

        protected Cat(IngameTime birthday)
        {
            Characteristics = new Characteristics();
            Traits = new List<Traits>();
            _birthday = birthday;
        }

        public Texture2D Avatar { get; set; }

        public CatsAction CurrentAction { get; set; }

        public Characteristics Characteristics { get; set; }

        public string Clan { get; set; }

        public bool IsMale { get; set; }

        public int MoonInClan { get; set; }

        public string Name { get; set; }

        public string Rang { get; set; }

        public List<Traits> Traits { get; set; }

        public IngameTimeInterval Age
        {
            get { return TimeController.CurrentTime - _birthday; }
        }

        public IngameTime DebugBirthdaySetter
        {
            set
            {
                _birthday = value;
            }
        }

        protected LinkedList<CatsAction> PreviousActions { get; set; }
    }
}