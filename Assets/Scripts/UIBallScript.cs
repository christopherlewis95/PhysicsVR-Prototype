using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBallScript : MonoBehaviour {

	private float BallVelocity;
	private float BallHeight;
	public ballScript myBall;


	// Use this for initialization
	void Start () {
		//myBall.GetComponent<ballScript> ();


	}

	// Update is called once per frame
	void Update () {
		BallVelocity = myBall.getRelativeVelocity();
		BallHeight = myBall.getRelativeHeight ();
	}




}
