using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_Script : MonoBehaviour {
	public GameObject target;
	private GameObject scoreObject;
	private ScoreScript score;

	void Start(){
		scoreObject = GameObject.FindGameObjectWithTag ("CannonScore");

		score = scoreObject.GetComponent<ScoreScript> ();
		if (score == null)
			print ("RUH ROH");
	}



	void OnTriggerEnter(Collider other){
		if (other.tag == "Cannonball") {
			
			target.SetActive (false);
			Destroy (other.gameObject); // destorys balls (ouch)
			score.UpdateScore (10);
			//Destroy (target);
			//TODO:
			//explosion

		}
	}
}
