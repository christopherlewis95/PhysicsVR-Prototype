using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleScriptTrigger : MonoBehaviour {

	public GameObject replacement;
	bool isDestroyed = false;
	public bool isHouse;
	public bool isWall;


	// Use this for initialization
	void Start () {
		
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

			if (other.tag == "destructive") {

				if (isDestroyed == false) {
					GameObject.Instantiate (replacement, transform.position, transform.rotation);
					if (gameObject.tag != "safe")
						GlobalDestroyObjectScript.numObjects--;
					Destroy (gameObject);
					isDestroyed = true;
				}

			}


		}


	}

}
