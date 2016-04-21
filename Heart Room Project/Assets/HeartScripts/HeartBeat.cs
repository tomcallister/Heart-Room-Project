using UnityEngine;
using System.Collections;

public class HeartBeat : MonoBehaviour {

	private int beat;
	public Vector3 size = new Vector3(.25f,.0f,.5f);
	// Use this for initialization
	void Start () {
		beat = 1;
		HeartStart ();
	}
	
	void HeartStart()
	{
		StartCoroutine (HeartThump ());
	}
	
	IEnumerator HeartThump()
	{
		switch (beat) 
		{
		case 1: 
			//beat
			this.transform.localScale += size;
			beat = 2;
			yield return new WaitForSeconds(.125f);
			HeartStart();
			break;
		case 2:
			this.transform.localScale -= size;
			beat = 3;
			yield return new WaitForSeconds(.125f);
			HeartStart();
			break;
		case 3:
			this.transform.localScale += size;
			beat = 4;
			yield return new WaitForSeconds(.125f);
			HeartStart();
			break;
		case 4:
			this.transform.localScale -= size;
			beat = 1;
			yield return new WaitForSeconds(.6f);
			HeartStart();
			break;
		default:
			print ("oops");
			yield return new WaitForSeconds(0);
			break;
		}
	}
}