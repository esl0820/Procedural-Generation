using UnityEngine;
using System.Collections;

public class CubeGod : MonoBehaviour {

	public Transform blueprint; // assign in Inspector
	public float cubeCount;
	float cubeSpawnRadius = 15f;


	// Use this for initialization
	void Start () {
		float cubeCountMax = Random.Range (100f, 200f);
		while ( cubeCount < cubeCountMax ) {
			Instantiate( blueprint, Random.onUnitSphere * cubeSpawnRadius, Random.rotation);
			cubeCount++;
		}
	}

	void MakeRandomCube () {
		Instantiate( blueprint, Random.onUnitSphere * cubeSpawnRadius, Random.rotation);
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKeyDown (KeyCode.R) ) {
			Application.LoadLevel ( Application.loadedLevel);
		}

		if ( Input.GetKey (KeyCode.Space) ) {
			MakeRandomCube ();
		}
	
	}
}
