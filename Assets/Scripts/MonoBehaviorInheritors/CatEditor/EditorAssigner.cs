using UnityEngine;

namespace MonoBehaviorInheritors.CatEditor
{
    public class EditorAssigner : MonoBehaviour
    {
        private PlayerAvatar _playerAvatar;
        [SerializeField]
        private CatPainter _catPainter;
        [SerializeField]
        private PlayerAvatar.Parts _part;
        [SerializeField]
        private PlayerAvatar.FaceTypes _faceType;
        [SerializeField]
        private PlayerAvatar.FurryTypes _furryType;
        [SerializeField]
        private PlayerAvatar.EyesTypes _eyesType;
        [SerializeField]
        private PlayerAvatar.EyesColors _eyesColor;
        [SerializeField]
        private PlayerAvatar.EarsAndNoses _earsAndNose;
        [SerializeField]
        private PlayerAvatar.FurColorsAndStripsAndSpots _furColorAndStripsAndSpots;

        private const int DefaultValue = 0;



        private void Start()
        {
            _playerAvatar = _catPainter.PlayerAvatar;
        }

        public void Assign()
        {
            switch (_part)
            {
                case PlayerAvatar.Parts.FaceType:
                    _playerAvatar[PlayerAvatar.Parts.FaceType] = _faceType;
                    _catPainter.DrawShapeAndShadow();
                    break;
                case PlayerAvatar.Parts.FurryType:
                    _playerAvatar[PlayerAvatar.Parts.FurryType] = _furryType;
                    _catPainter.DrawShapeAndShadow();
                    break;
                case PlayerAvatar.Parts.EyesType:
                    _playerAvatar[PlayerAvatar.Parts.EyesType] = _eyesType;
                    _catPainter.DrawEyesType();
                    break;
                case PlayerAvatar.Parts.EyesColor:
                    _playerAvatar[PlayerAvatar.Parts.EyesColor] = _eyesColor;
                    _catPainter.DrawEyesColor();
                    break;
                case PlayerAvatar.Parts.Ears:
                    _playerAvatar[PlayerAvatar.Parts.Ears] = _earsAndNose;
                    _catPainter.DrawEars();
                    break;
                case PlayerAvatar.Parts.Nose:
                    _playerAvatar[PlayerAvatar.Parts.Nose] = _earsAndNose;
                    _catPainter.DrawNose();
                    break;
                case PlayerAvatar.Parts.ColorMain:
                    _playerAvatar[PlayerAvatar.Parts.ColorMain] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorMain);
                    break;
                case PlayerAvatar.Parts.ColorBack:
                    _playerAvatar[PlayerAvatar.Parts.ColorBack] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorBack);
                    break;
                case PlayerAvatar.Parts.ColorBackFoot:
                    _playerAvatar[PlayerAvatar.Parts.ColorBackFoot] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorBackFoot);
                    break;
                case PlayerAvatar.Parts.ColorBreast:
                    _playerAvatar[PlayerAvatar.Parts.ColorBreast] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorBreast);
                    break;
                case PlayerAvatar.Parts.ColorEars:
                    _playerAvatar[PlayerAvatar.Parts.ColorEars] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorEars);
                    break;
                case PlayerAvatar.Parts.ColorHose:
                    _playerAvatar[PlayerAvatar.Parts.ColorHose] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorHose);
                    break;
                case PlayerAvatar.Parts.ColorSocks:
                    _playerAvatar[PlayerAvatar.Parts.ColorSocks] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorSocks);
                    break;
                case PlayerAvatar.Parts.ColorTail:
                    _playerAvatar[PlayerAvatar.Parts.ColorTail] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorTail);
                    break;
                case PlayerAvatar.Parts.ColorTailTip:
                    _playerAvatar[PlayerAvatar.Parts.ColorTailTip] = _furColorAndStripsAndSpots;
                    _catPainter.DrawFurColors(PlayerAvatar.Parts.ColorTailTip);
                    break;
                case PlayerAvatar.Parts.StripsS:
                {
                    const PlayerAvatar.Parts part = PlayerAvatar.Parts.StripsS;
                    _playerAvatar[part] = _furColorAndStripsAndSpots;
                    _catPainter.DrawStripsAndSpots(part);
                    _catPainter.SetSibling(part.ToString());
                }
                    break;
                case PlayerAvatar.Parts.StripsM:
                {
                    const PlayerAvatar.Parts part = PlayerAvatar.Parts.StripsM;
                    _playerAvatar[part] = _furColorAndStripsAndSpots;
                    _catPainter.DrawStripsAndSpots(part);
                    _catPainter.SetSibling(part.ToString());
                }
                    break;
                case PlayerAvatar.Parts.StripsL:
                {
                    const PlayerAvatar.Parts part = PlayerAvatar.Parts.StripsL;
                    _playerAvatar[part] = _furColorAndStripsAndSpots;
                    _catPainter.DrawStripsAndSpots(part);
                    _catPainter.SetSibling(part.ToString());
                }
                    break;
                case PlayerAvatar.Parts.SpotsS:
                {
                    const PlayerAvatar.Parts part = PlayerAvatar.Parts.SpotsS;
                    _playerAvatar[part] = _furColorAndStripsAndSpots;
                    _catPainter.DrawStripsAndSpots(part);
                    _catPainter.SetSibling(part.ToString());
                }
                    break;
                case PlayerAvatar.Parts.SpotsM:
                {
                    const PlayerAvatar.Parts part = PlayerAvatar.Parts.SpotsM;
                    _playerAvatar[part] = _furColorAndStripsAndSpots;
                    _catPainter.DrawStripsAndSpots(part);
                    _catPainter.SetSibling(part.ToString());
                }
                    break;
                case PlayerAvatar.Parts.SpotsL:
                {
                    const PlayerAvatar.Parts part = PlayerAvatar.Parts.SpotsL;
                    _playerAvatar[part] = _furColorAndStripsAndSpots;
                    _catPainter.DrawStripsAndSpots(part);
                    _catPainter.SetSibling(part.ToString());
                }
                    break;
                case PlayerAvatar.Parts.SpotsLe:
                {
                    const PlayerAvatar.Parts part = PlayerAvatar.Parts.SpotsLe;
                    _playerAvatar[part] = _furColorAndStripsAndSpots;
                    _catPainter.DrawStripsAndSpots(part);
                    _catPainter.SetSibling(part.ToString());
                }
                    break;
            }
        }
    }
}
