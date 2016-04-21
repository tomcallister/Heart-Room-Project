using UnityEngine;
using System.Collections;

public class RotateIndividual : MonoBehaviour {

	public int rotationSpeed = 15;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (0, Time.deltaTime * rotationSpeed, 0, Space.World);

	}
}
