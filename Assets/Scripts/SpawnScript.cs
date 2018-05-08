using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public Transform spawn;
	private AudioSource pop;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		pop = spawn.GetComponentInParent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Net") {
			this.transform.rotation = spawn.rotation;
			this.transform.position = spawn.position;
			rb.velocity = new Vector3 (0f, 0f, 0f);
			rb.angularVelocity = new Vector3 (0f, 0f, 0f);
			pop.Play ();
			StartCoroutine (delay (2, 1));
		}
	}

	public void respawn(){
		this.transform.rotation = spawn.rotation;
		this.transform.position = spawn.position;
		rb.velocity = new Vector3 (0f, 0f, 0f);
		rb.angularVelocity = new Vector3 (0f, 0f, 0f);
		pop.Play ();
		StartCoroutine (delay (2, 1));

	}


	IEnumerator delay(int time, int set)
	{
		//print(Time.time);

		if (set == 1) {
			yield return new WaitForSeconds (time);
			pop.Stop ();
		}

		if (set == 2) {
			yield return new WaitForSeconds (time);
			pop.Stop ();
		}

		//cannonBlast.Stop ();
		//print(Time.time);
	}

}
