using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPowerScript : MonoBehaviour {

	public static bool powerOn;
	public GameObject controller;
	SteamVR_RenderModel model;

	// Use this for initialization
	void Start () {
		powerOn = false;
		model = controller.GetComponent<SteamVR_RenderModel> ();
	}

	// Update is called once per frame
	void Update () {
		if (powerOn == true) {
			print ("POWER OVERRIDE");
			//model.modelOverride = "Hand";
		}
	}
}
