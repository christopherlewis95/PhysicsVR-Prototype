using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour {


	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public float getRelativeVelocity()
	{

		return rb.velocity.y;
	}

	public float getRelativeHeight()
	{
		float myYPos = this.transform.position.y;

		// Since this needs to be changed
		if (myYPos > 0 && (rb.velocity.y == 0))
			myYPos = 0;


		return myYPos;
	}
}
