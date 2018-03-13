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
	float xInitial = 0;
	float yInitial = 0;
	float sInitial = 0;
	float strength;
	float pstrength;
	// Use this for initialization
	void Start () {
		HLever= GameObject.FindGameObjectWithTag("HLever");
		hLeverData = HLever.GetComponent<HLeverScript> ();
		 VLever = GameObject.FindGameObjectWithTag("VLever");
		vLeverData = VLever.GetComponent<VLeverScript> ();
		SLever = GameObject.FindGameObjectWithTag("SLever");
		sLeverData = SLever.GetComponent<SLeverScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentAngleY = hLeverData.getAngle (); // Swivel Left and Right
		currentAngleX = vLeverData.getAngle (); // Up and Down
		strength = sLeverData.getAngle ();

		//LateUpdate ();
	}

	void LateUpdate(){
		
		if (currentAngleX != previousAngleX) {
			print (currentAngleX);
			previousAngleX = currentAngleX;
			currentAngleX = currentAngleX + xInitial;
			this.transform.eulerAngles = new Vector3(currentAngleX, -currentAngleY, 0);
			//this.transform.Rotate (currentAngleX, 0, 0);
		}
		else if (currentAngleY != previousAngleY) {
			previousAngleY = currentAngleY;
			currentAngleY = currentAngleY + yInitial;
			print (currentAngleY);
			this.transform.eulerAngles = new Vector3(currentAngleX, -currentAngleY, 0);
			//this.transform.Rotate (0 ,currentAngleY, 0);
		}
		/*
		if ( strength != pstrength) {
			pstrength = strength;
			this.transform.Rotate (0 ,0, strength);
		}
		*/
	}
}
