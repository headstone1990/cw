using UnityEngine;
using System.Collections;

public class BeforeEditorOpen : MonoBehaviour {
    CatStorage _catStorage;
    public string FurryType;
    public string FaceType;
    public string EyesType;

	void Awake ()
    {
        _catStorage = GameObject.FindWithTag("CatStorage").GetComponent<CatStorage>();
	}

    public void PlayerCreate()
    {
        _catStorage.PlayerCreate(FurryType, FaceType, EyesType);
    }
}
