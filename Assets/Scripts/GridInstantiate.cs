using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public Transform wall;
	public Transform floor;
	public GameObject path;
	public float pathChance;
	public GameObject numPaths;
	public float floorChance = .85f;
	public int maxSize = 5;

	float randy;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < 5; x++) {
			for ( int z = 0; z < 5; z++) {
				Vector3 pos = new Vector3(x * 8f, 0f, z * 8f) + transform.position;
				randy = Random.Range (0f, 1f);
					if ( randy <= floorChance) {
						Instantiate (floor, pos, Quaternion.Euler (0f,0f,0f));
					} else if ( randy > floorChance) {
						Instantiate (wall, pos, Quaternion.Euler (0f,0f,0f));
					}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (numPaths.GetComponent<numPaths>().paths < maxSize) {
			Vector3 pos = new Vector3(8f, 0f,8f) + transform.position;
			Instantiate ( path , pos , Quaternion.Euler (0f,0f,0f));
			numPaths.GetComponent<numPaths>().paths++;
		}
	}
}
