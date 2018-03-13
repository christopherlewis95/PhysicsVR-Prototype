using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;


public class CannonScript : MonoBehaviour {

	private GameObject HLever;
	private GameObject VLever;
	private GameObject SLever;
	HLeverScript hLeverData;
	VLeverScript vLeverData;
	SLeverScript sLeverData;
	float currentAngleX = 0;
	float previousAngleX = 0;
	float currentAngleY = 0;
	float previousAngleY = 0;
	float strength;
	float pstrength;
	// Use this for initialization
	void Start () {
		HLever= GameObject.FindGameObjectWithTag("HLever");
		hLeverData = HLever.GetComponent<HLeverScript> ();
		 VLever = GameObject.FindGameObjectWithTag("VLever");
		vLeverData = HLever.GetComponent<VLeverScript> ();
		SLever = GameObject.FindGameObjectWithTag("SLever");
		sLeverData = HLever.GetComponent<SLeverScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentAngleY = hLeverData.getAngle ();
		currentAngleX = vLeverData.getAngle ();
		strength = sLeverData.getAngle ();

		LateUpdate ();
	}

	void LateUpdate(){
		
		if (currentAngleX != previousAngleX) {
			print (currentAngleX);
			previousAngleX = currentAngleX;
			this.transform.Rotate (currentAngleX, 0, 0);
		}
		if (currentAngleY != previousAngleY) {
			previousAngleY = currentAngleY;
			print (currentAngleY);
			this.transform.Rotate (0 ,currentAngleY, 0);
		}
		/*
		if ( strength != pstrength) {
			pstrength = strength;
			this.transform.Rotate (0 ,0, strength);
		}
		*/
	}
}
