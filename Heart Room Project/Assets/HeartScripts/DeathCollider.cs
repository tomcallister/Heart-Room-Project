using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class DeathCollider : MonoBehaviour {

	FirstPersonController FPC;

	//public Vector3 spawnPoint;

	Transform SpawnPoint, Player;

	void Start () {
		SpawnPoint = GameObject.Find ("SpawnPoint").transform;
		Player = GameObject.Find ("FPSController").transform;
		FPC = Player.GetComponent<FirstPersonController>();
	}

	void OnTriggerEnter (Collider other)
	{
		//	Application.LoadLevel(0);
		if(other.tag == "Player")
			{
			FPC.enabled = false;
			Player.transform.position = SpawnPoint.transform.position;
			Player.transform.rotation = new Quaternion ();
			//Instantiate(Player, spawnPoint, Quaternion.Euler(0,90,0));
			FPC.enabled = true;
			}
	}
}
