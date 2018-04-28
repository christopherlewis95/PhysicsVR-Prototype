using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;


public class PowerScript : MonoBehaviour {


	public GameObject hand;
	public VRTK_InteractGrab grabdata;


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
			grabdata.throwMultiplier = 5.0f;
		}

	}


}
