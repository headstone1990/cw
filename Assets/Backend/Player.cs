namespace CW.Backend
{
    using global::MonoBehaviorInheritors.Main;

    public class Player : Cat
    {
        public Player(IngameTime birthday) : base(birthday)
        {
            PlayerAvatar = new PlayerAvatar();
        }

        public PlayerAvatar PlayerAvatar { get; set; }
    }
}