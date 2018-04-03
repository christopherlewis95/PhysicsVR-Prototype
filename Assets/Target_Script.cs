using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Script : MonoBehaviour {
	public GameObject target;
	void OnTriggerEnter(Collider other){
		if (other.tag == "Cannonball") {
			Destroy (target);
			//TODO:
			//explosion
			//increment score
		}
	}
}
