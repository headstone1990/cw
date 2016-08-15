namespace CW.Frontend.CustomUIElements.Interfaces
{
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    public interface IOnWarningSwitch : IEventSystemHandler
    {
        void OnWarningEnable(GameObject warningButton, params Button[] disabledButtons);

        void OnWarningDisable(params Button[] enabledButtons);
    }
}