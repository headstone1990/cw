using UnityEngine;

namespace MonoBehaviorInh
{
    public class CatStorage : MonoBehaviour
    {
        public Player Player { get; set; }
        public static CatStorage Storage { get; set; }


        private void Awake()
        {
            Storage = this;
            DontDestroyOnLoad(gameObject);
        }

        public void CreatePlayer(PlayerAvatar.FurryTypes furryType, PlayerAvatar.FaceTypes faceType, PlayerAvatar.EyesTypes eyesType)
        {
            Player = new Player();
            Player.PlayerAvatar[PlayerAvatar.Parts.FaceType] = faceType;
            Player.PlayerAvatar[PlayerAvatar.Parts.FurryType] = furryType;
            Player.PlayerAvatar[PlayerAvatar.Parts.EyesType] = eyesType;
        }
    }
}
