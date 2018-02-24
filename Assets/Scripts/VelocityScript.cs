using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VelocityScript : MonoBehaviour {

	public Text velocity;
	private float BallVelocity;
	private float BallHeight;
	public ballScript myBall;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		BallVelocity = myBall.getRelativeVelocity();
		velocity.text = BallVelocity.ToString("f2");
	}
}
