using System;
using UnityEngine;
using System.Collections;

public class TraitSelector : MonoBehaviour
{
    [SerializeField]
    private string _selectedTraitLocalizedString;
    [SerializeField]
    private string _description;
    private TraitSelectorController _traitSelectorController;

    private void Awake()
    {
        _traitSelectorController = GameObject.FindGameObjectWithTag("Script").GetComponent<TraitSelectorController>();
    }



    public void Select()
    {
        _traitSelectorController.TraitSelect((Traits)Enum.Parse(typeof(Traits), gameObject.name, true), _selectedTraitLocalizedString, _description);
    }


}
