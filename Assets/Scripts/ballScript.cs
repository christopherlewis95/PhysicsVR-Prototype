using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballScript : MonoBehaviour {
	public Rigidbody rb;
	public SphereCollider myCollider;
	public GameObject scoreObject;
	public GameInfoScript score;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		scoreObject = GameObject.FindGameObjectWithTag ("CannonScore");
		score = scoreObject.GetComponent<GameInfoScript> ();
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
	/*
	 void OnCollisionEnter (Collision col)
	{
		
		if(col.gameObject.tag == "Target")
		{
			print ("FACK");
			score.UpdateScore (10);
		}
	
	}
	*/
}