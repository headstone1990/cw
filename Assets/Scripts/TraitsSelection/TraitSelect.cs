using UnityEngine;
using System.Collections;

public class TraitSelect : MonoBehaviour
{
    public string Trait;
    public string Description;
    private EditorTraitSelect _editorTraitSelect;

    private void Awake()
    {
        _editorTraitSelect = GameObject.FindGameObjectWithTag("Script").GetComponent<EditorTraitSelect>();
    }

    public void Select()
    {
        _editorTraitSelect.TraitSelect(Trait, Description);
    }


}
