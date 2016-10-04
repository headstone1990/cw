namespace CW.Frontend.CustomUIElements
{
    using Interfaces;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    public class CustomEventSystem : EventSystem, IOnWarningSwitch
    {
        public void OnWarningEnable(GameObject warningButton, params Button[] disabledButtons)
        {
            SetSelectedGameObject(null);
            foreach (Button button in disabledButtons)
            {
                button.enabled = false;
            }

            SetSelectedGameObject(warningButton);
        }

        public void OnWarningDisable(params Button[] enabledButtons)
        {
            foreach (Button button in enabledButtons)
            {
                button.enabled = true;
            }

            SetSelectedGameObject(null);
        }
    }
}