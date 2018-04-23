using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntegrityScript : MonoBehaviour {

	public Text integrityText;
	// private float startTime ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		integrityText.text = GlobalDestroyObjectScript.numObjects.ToString();
	}
}
