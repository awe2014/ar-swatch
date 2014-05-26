using UnityEngine;
using System.Collections;

public class LegScript : MonoBehaviour, ITappable {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Tap()
    {
        this.renderer.material.color = Color.red;
        print("Object has been tapped");
    }
}
