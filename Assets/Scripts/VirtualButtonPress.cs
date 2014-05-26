using UnityEngine;
using System.Collections;

public class VirtualButtonPress : MonoBehaviour 
{
    public bool buttonPressed = false;
    public bool useSphereCast = false;
    public bool playSoundOnPress = false;
    public AudioClip soundToPlayOnPress;
	//private QualityController qualityController;

	// Use this for initialization
	void Start () 
	{
		//qualityController = QualityController.Instance;
	}
	
	// Update is called once per frame
	void Update () 
	{
        ProcessTouches();
        HandleButtonPressed();
	}


    void ProcessTouches()
    {
		// For Mouse Input

		if (Input.GetMouseButtonDown(0))
		{
            RaycastAtScreenPosition(Input.mousePosition);
		}
		
		// For Touches
		foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                RaycastAtScreenPosition(touch.position);

            }
        }
    }

    private void RaycastAtScreenPosition(Vector2 screenPosition)
    {
        var ray = Camera.main.ScreenPointToRay(screenPosition);
        RaycastHit hit;
        bool castHitSomething = false;

        if (useSphereCast)
        {
            castHitSomething = Physics.SphereCast(ray, 1.0f, out hit, 300);
            print("SphereCast Hit : " + hit.collider.name);
        }
        else
        {
            castHitSomething = Physics.Raycast(ray, out hit);
        }

        if (castHitSomething)
        {
            if (hit.collider == this.collider)
            {
                buttonPressed = true;
            }
        }
    }

    void HandleButtonPressed()
    {
        if(!buttonPressed)
            return;

        ITappable tappedObject = this.GetComponent(typeof(ITappable)) as ITappable;

        if (tappedObject != null)
        {
            tappedObject.Tap();
            if (playSoundOnPress)
            {
                audio.PlayOneShot(soundToPlayOnPress);
            }
        }        

        buttonPressed = false;

	}
}
