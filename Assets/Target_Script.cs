using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_Script : MonoBehaviour {
	public GameObject target;
	public GameObject explosion;
	private GameObject scoreObject;
	private GameInfoScript score;
	ParticleSystem particleDestroy;
	public static int numEnemies = 0;

	void Start(){
		numEnemies++;
		scoreObject = GameObject.FindGameObjectWithTag ("CannonScore");
		particleDestroy = explosion.GetComponent<ParticleSystem> ();
		score = scoreObject.GetComponent<GameInfoScript> ();
		if (score == null)
			print ("RUH ROH");
	}



	void OnTriggerEnter(Collider other){
		if (other.tag == "Cannonball") {
			numEnemies--;
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
