using UnityEngine;

namespace MonoBehaviorInheritors.TraitsSelection
{
    public class SelectedTraitStorage : MonoBehaviour
    {
        [SerializeField] private Traits _selectedTrait;

        public Traits SelectedTrait
        {
            get
            {
                return _selectedTrait;
            }

            set
            {
                _selectedTrait = value;
            }
        }
    }
}