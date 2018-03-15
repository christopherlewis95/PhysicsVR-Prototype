using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;


public class CannonScript : MonoBehaviour {

	private GameObject HLever;
	private GameObject VLever;
	private GameObject SKnob;
	HLeverScript hLeverData;
	VLeverScript vLeverData;
	SLeverScript sKnobData;
	public Transform firepoint;
	public GameObject cannonBall;
	float currentAngleX = 0;
	float previousAngleX = 0;
	float currentAngleY = 0;
	float previousAngleY = 0;
	float xInitial = 0;
	float yInitial = 0;
	float sInitial = 0;
	float strength;
	float pstrength;
	float maxStrength = 100;
	// Use this for initialization
	void Start () {
		HLever= GameObject.FindGameObjectWithTag("HLever");
		hLeverData = HLever.GetComponent<HLeverScript> ();
		 VLever = GameObject.FindGameObjectWithTag("VLever");
		vLeverData = VLever.GetComponent<VLeverScript> ();
		SKnob = GameObject.FindGameObjectWithTag("SLever");
		sKnobData = SKnob.GetComponent<SLeverScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentAngleY = hLeverData.getAngle (); // Swivel Left and Right
		currentAngleX = vLeverData.getAngle (); // Up and Down
		strength = sKnobData.getAngle ();

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

		else if ( strength != pstrength) {
			pstrength = strength;
			//strength = strength + sInitial;
			//shooooooott ();

		}
	
	}

	public void shooooooott(){

		var bullet = Instantiate (cannonBall, firepoint.position, firepoint.rotation);
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * (40*(strength/maxStrength));

	}
}
