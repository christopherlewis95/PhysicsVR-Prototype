using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PickUpScript : MonoBehaviour {

	public VRTK_InteractableObject obj;

	// Use this for initialization
	void Start () {
		obj.isGrabbable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalPowerScript.powerOn == true) {
			obj.isGrabbable = true;
		}
	}
}
