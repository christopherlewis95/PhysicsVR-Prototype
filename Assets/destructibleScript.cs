using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructibleScript : MonoBehaviour {

	public GameObject replacement;



	void OnCollisionEnter ()
	{
		Destroy (gameObject);
		GameObject.Instantiate (replacement, transform.position, transform.rotation);

	}

}
