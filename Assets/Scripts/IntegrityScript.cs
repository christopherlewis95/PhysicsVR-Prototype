using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntegrityScript : MonoBehaviour {

	public Text integrityText;
	public GameObject GameOverText;
	private int numObjects;
	private float negativeAmount;

	// private float startTime ;

	// Use this for initialization
	void Start () {
		numObjects = GlobalDestroyObjectScript.numObjects;
		negativeAmount = 100f / numObjects;
	}
	
	// Update is called once per frame
	void Update () {
		integrityText.text = (GlobalDestroyObjectScript.numObjects * negativeAmount).ToString("f0") + "%";

		if (GlobalDestroyObjectScript.numObjects == 0)
			GameOverText.SetActive (true);	
	}
}
