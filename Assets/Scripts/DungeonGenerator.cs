using UnityEngine;
using System.Collections;

public class DungeonGenerator : MonoBehaviour {

	public GameObject floor = null;
	public GameObject wall = null;
	float randy;
	int counter =0;
	public GameObject grid;
	public float gridChance;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (counter < 50) {
			randy = Random.Range (0.0f,1.0f);
			if (randy <= .25f) {
				transform.Rotate ( 0f, 90f, 0f);
			} else if ( randy > .25f && randy < .50f) {
				transform.Rotate (0f, -90f, 0f);
			} else if ( randy > gridChance && counter > 48) {
				Instantiate ( grid , transform.position, Quaternion.Euler ( 0f, 0f, 0f));
			}
			Instantiate ( floor, transform.position, Quaternion.Euler ( 0f, 0f, 0f));
			transform.Translate (Vector3.forward * 8f); 
			counter++;
		} else {
			gameObject.SetActive (false);
		}
	}
}
