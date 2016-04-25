using UnityEngine;
using System.Collections;

public class OpenHeartNegative : MonoBehaviour {

	public int OPENSPEED = -3;
	
	// Use this for initialization
	void Start () {
	}
	
	
	// Update is called once per frame
	void Update () {
		GameObject FPSController = GameObject.Find("FPSController");
		PlayerPickUps playerPickUps = FPSController.GetComponent<PlayerPickUps>();
		if (playerPickUps.count == 3 && transform.eulerAngles.y > 30f) {
			GameObject HeartHalo = GameObject.Find("HeartHalo");
			transform.Rotate(Vector3.up * Time.deltaTime * OPENSPEED);
			HeartHalo.gameObject.SetActive (false);
		}
	}
}