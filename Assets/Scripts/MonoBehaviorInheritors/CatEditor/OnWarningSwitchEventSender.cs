using Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.CatEditor
{
    using CW.Frontend.CustomUIElements.Interfaces;

    public class OnWarningSwitchEventSender : MonoBehaviour
    {
        private GameObject _eventSystem;
        [SerializeField]
        private Button[] _disabledButtons;

        private void Awake()
        {
            _eventSystem = GameObject.FindGameObjectWithTag("EventSystem");
        }

        private void OnEnable()
        {
            ExecuteEvents.Execute<IOnWarningSwitch>(_eventSystem, null,
                (handler, data) => handler.OnWarningEnable(gameObject, _disabledButtons));
        }
        private void OnDisable()
        {
            ExecuteEvents.Execute<IOnWarningSwitch>(_eventSystem, null,
                (handler, data) => handler.OnWarningDisable(_disabledButtons));
        }



    }
}