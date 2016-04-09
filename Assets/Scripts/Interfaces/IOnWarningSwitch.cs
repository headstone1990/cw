using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Interfaces
{
    public interface IOnWarningSwitch : IEventSystemHandler
    {
        void OnWarningEnable(GameObject warningButton, params Button[] disabledButtons);
        void OnWarningDisable(params Button[] enabledButtons);
    }
}