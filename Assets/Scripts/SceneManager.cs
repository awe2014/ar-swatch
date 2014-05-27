using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void LoadFurniturePlacement()
    {
        Application.LoadLevel("furniturePlacement");
    }
	
	// Update is called once per frame
	void Update () {

        CheckAndroidExit();
	
	}

    private void CheckAndroidExit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
