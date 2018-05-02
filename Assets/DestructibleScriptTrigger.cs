using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleScriptTrigger : MonoBehaviour {

	public GameObject replacement;
	bool isDestroyed = false;
	public bool isHouse;
	public bool isWall;


	public GameObject crumble;
	AudioSource crumbleSound;

	public GameObject explosion;
	AudioSource explosionSound;


	// Use this for initialization
	void Start () {
		crumbleSound = crumble.GetComponent<AudioSource> ();
		explosionSound = explosion.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		if (isHouse == true) {

			if (other.tag == "heavy") {

				if (isDestroyed == false) {
					GameObject.Instantiate (replacement, transform.position, transform.rotation);
					if (gameObject.tag != "safe")
						GlobalDestroyObjectScript.numObjects--;
					Destroy (gameObject);
					isDestroyed = true;



				}

			}

		}

		if (isWall == true) {

			if (other.tag == "destructive" || other.tag == "heavy" ) {

				if (isDestroyed == false) {
					GameObject.Instantiate (replacement, transform.position, transform.rotation);
					if (gameObject.tag != "safe")
						GlobalDestroyObjectScript.numObjects--;
					Destroy (gameObject);
					isDestroyed = true;

					crumbleSound.Play ();
					StartCoroutine (delay (3,1));
				}

			}


		}


	}

	IEnumerator delay(int time, int set)
	{
		//print(Time.time);

		if (set == 1) {
			yield return new WaitForSeconds (time);
			crumbleSound.Stop ();
		}

		if (set == 2) {
			yield return new WaitForSeconds (time);
			crumbleSound.Stop ();
		}
		
		//cannonBlast.Stop ();
		//print(Time.time);
	}

}
