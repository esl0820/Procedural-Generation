using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	
	Collider thingCurrentlyInside;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( thingCurrentlyInside != null) {
			Destroy (thingCurrentlyInside);
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel ( Application.loadedLevel);
		}
	}
	
	//Unity automatically calls this function when an object with a Rigidbody
	// enters this object's trigger-collider, AND it will tell you WHAT entered it
	
	void OnTriggerEnter ( Collider activator ) {
		thingCurrentlyInside = activator; // want to remember the thing that entered the trigger
	}
	
	void OnTriggerExit ( Collider exiter) {
		thingCurrentlyInside = null;
	}
}

