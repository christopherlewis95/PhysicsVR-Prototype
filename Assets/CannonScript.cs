using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;


public class CannonScript : MonoBehaviour {
	private GameObject HLever = GameObject.FindGameObjectWithTag("HLever");
	private GameObject VLever = GameObject.FindGameObjectWithTag("VLever");
	private GameObject PLever = GameObject.FindGameObjectWithTag("SLever");

	float currentAngleX = 0;
	float previousAngleX = 0;
	float currentAngleY = 0;
	float previousAngleY = 0;
	float strength;
	float pstrength;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		currentAngleY = HLever.GetComponent<HLeverScript> ().getAngle ();
		currentAngleX = VLever.GetComponent<VLeverScript> ().getAngle ();
		strength = PLever.GetComponent<SLeverScript> ().getAngle ();
		print (currentAngleX);
		print (currentAngleY);
		print (strength);

		LateUpdate ();
	}

	void LateUpdate(){
		
		if (currentAngleX != previousAngleX) {
			previousAngleX = currentAngleX;
			this.transform.Rotate (currentAngleX, 0, 0);
		}
		if (currentAngleY != previousAngleY) {
			previousAngleY = currentAngleY;
			this.transform.Rotate (0 ,currentAngleY, 0);
		}
		if ( strength != pstrength) {
			pstrength = strength;
			this.transform.Rotate (0 ,0, strength);
		}
	}
}
