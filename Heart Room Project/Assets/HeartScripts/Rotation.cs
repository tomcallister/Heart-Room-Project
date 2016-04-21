using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public int rotationSpeed = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//rotate around the world's Y-axis, 1 degree per second
		transform.Rotate (Vector3.up * (Time.deltaTime * rotationSpeed), Space.World);

	}
}
