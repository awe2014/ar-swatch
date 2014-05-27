using UnityEngine;
using System.Collections;

public class FurnitureMain : MonoBehaviour, ITappable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Tap()
    {
        Application.LoadLevel("furniture");
    }
}
