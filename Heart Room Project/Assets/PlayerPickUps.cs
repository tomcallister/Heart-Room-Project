using UnityEngine;
using System.Collections;

public class PlayerPickUps : MonoBehaviour {

	public int count;


	// Use this for initialization
	void Start () {
		count = 0;
	}

	void OnTriggerEnter(Collider other) {
			if (other.gameObject.CompareTag ("WhiteBloodCell")) {
				other.gameObject.SetActive (false);
				count++;
			}
	}
}
