using UnityEngine;

namespace MonoBehaviorInheritors
{
    public class CatStorage : MonoBehaviour
    {
        public Player Player { get; private set; }
        public static CatStorage Storage { get; private set; }


        private void Awake()
        {

            if (Storage == null)
            {
                DontDestroyOnLoad(gameObject);
                Storage = this;
            }
            else if(Storage != this)
            {
                Destroy(gameObject);
            }
            if (Player == null)
            {
                CreatePlayer(PlayerAvatar.FurryTypes.NormalFur, PlayerAvatar.FaceTypes.Normal,
                    PlayerAvatar.EyesTypes.Normal3);
            }
        }

        public void CreatePlayer(PlayerAvatar.FurryTypes furryType, PlayerAvatar.FaceTypes faceType, PlayerAvatar.EyesTypes eyesType)
        {
            Player = new Player();
            Player.PlayerAvatar[PlayerAvatar.Parts.FaceType] = faceType;
            Player.PlayerAvatar[PlayerAvatar.Parts.FurryType] = furryType;
            Player.PlayerAvatar[PlayerAvatar.Parts.EyesType] = eyesType;
            //else
            //{
            //    throw new MoreThanOnePlayerCreatedException();
            //}
        }
    }
}
