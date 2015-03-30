using UnityEngine;
using System.Collections;

public class CubeSpin : MonoBehaviour {

	public Transform gameThing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, Time.deltaTime * 90f, 0f);
		transform.position = Vector3.MoveTowards(transform.position, gameThing.position, 10f * Time.deltaTime);
	
	}
}
