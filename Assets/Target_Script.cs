using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_Script : MonoBehaviour {
	public GameObject target;
	public GameObject explosion;
	private GameObject scoreObject;
	private ScoreScript score;
	ParticleSystem particleDestroy;

	void Start(){
		scoreObject = GameObject.FindGameObjectWithTag ("CannonScore");
		particleDestroy = explosion.GetComponent<ParticleSystem> ();
		score = scoreObject.GetComponent<ScoreScript> ();
		if (score == null)
			print ("RUH ROH");
	}



	void OnTriggerEnter(Collider other){
		if (other.tag == "Cannonball") {

			particleDestroy.Play ();

			StartCoroutine (delay(1));

			target.SetActive (false);
			Destroy (other.gameObject); // destorys balls (ouch)
			score.UpdateScore (10);
			//Destroy (target);
			//TODO:
			//explosion

		}
	}



	IEnumerator delay(int time)
	{
		//print(Time.time);
		yield return new WaitForSeconds(time);
		particleDestroy.Stop ();
		//print(Time.time);
	}
}
