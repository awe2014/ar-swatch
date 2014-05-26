using UnityEngine;
using System.Collections;

public class SpinObject : MonoBehaviour {

    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(Vector3.up * Time.deltaTime * speed);
	
	}
}
