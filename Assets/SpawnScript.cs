using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public Transform spawn;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
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
		}
	}

}
