using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxVelocity : MonoBehaviour {

	public Text velocity;
	private float boxVel;
	private float boxHeight;
	public boxScript myBox;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		boxVel = myBox.getRelativeVelocity ();
		velocity.text = boxVel.ToString("f2");
	}
}
