using UnityEngine;
using System.Collections;

public class OpenHeart : MonoBehaviour {

	public int OPENSPEED = 3;

	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void Update () {
		GameObject FPSController = GameObject.Find("FPSController");
		PlayerPickUps playerPickUps = FPSController.GetComponent<PlayerPickUps>();
		if (playerPickUps.count == 3 && transform.eulerAngles.y < 100f) {

			transform.Rotate(Vector3.up * Time.deltaTime * OPENSPEED);

		}
	}
}
