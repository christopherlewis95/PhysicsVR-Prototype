using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;


public class PowerScript : MonoBehaviour {


	public GameObject hand;
	public VRTK_InteractGrab grabdata;
	public AudioSource tada;

	//public GameObject attachedSphere;


	// Use this for initialization
	void Start () {
		//rend = GetComponent<MeshRenderer> ();
		//rend = true;
		//grabdata = hand.GetComponent<VRTK_InteractGrab>();
	}

	// Update is called once per frame
	void Update () {





	}


	void OnTriggerEnter (Collider other){

		if (other.tag == "mouth") {
			GlobalPowerScript.powerOn = true;
			//attachedSphere.SetActive (false);

			Destroy (other.gameObject);
			hand.SetActive (true);
			tada.Play ();
			StartCoroutine (delay (2));
			grabdata.throwMultiplier = 5.0f;
		}

	}

	IEnumerator delay(int time)
	{
		//print(Time.time);
		yield return new WaitForSeconds(time);
		tada.Stop ();
		//print(Time.time);
	}

}
