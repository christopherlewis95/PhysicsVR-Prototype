using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructibleScript : MonoBehaviour {

	public GameObject replacement;
	bool isDestroyed = false;


	void OnCollisionEnter ()
	{

			GameObject.Instantiate (replacement, transform.position, transform.rotation);
			GlobalDestroyObjectScript.numObjects--;
			Destroy (gameObject);


			



	}

}
