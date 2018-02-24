using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxHeight : MonoBehaviour {

	public Text velocity;
	private float boxVel;
	private float boxH;
	public boxScript myBox;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		boxH = myBox.getRelativeHeight ();
		velocity.text = boxH.ToString("f2");
	}
}
