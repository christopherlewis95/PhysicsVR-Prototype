using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class GlobalPowerScript : MonoBehaviour {

	public static bool powerOn;
	public GameObject controller;
	SteamVR_RenderModel model;

	public VRTK_ControllerEvents.ButtonAlias grabButton = VRTK_ControllerEvents.ButtonAlias.StartMenuPress;

	bool powerOverride = false;

	//private GameObject[] allDestructiveObjects ;

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

			if (powerOverride == false) {
				/*GameObject[] GameObjects = (GameObject.FindGameObjectsWithTag ("destructive") as GameObject[]);
				//GameObject[] ChildrenObjects = (GameObject.Fi ("destructive") as GameObject[])

				for (int i = 0; i < GameObjects.Length; i++) {
					GameObjects [i].tag = "heavy";

				}*/
				powerOverride = true;
			}
		}

		/*
		if (grabButton) {

			print ("OI");
		}
		*/
	}
}
