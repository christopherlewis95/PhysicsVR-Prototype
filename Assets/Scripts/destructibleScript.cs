using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructibleScript : MonoBehaviour {

	public GameObject replacement;
	bool isDestroyed = false;


	void OnCollisionEnter ()
	{
		
			if (isDestroyed == false) {
				GameObject.Instantiate (replacement, transform.position, transform.rotation);
				if (gameObject.tag != "safe")
					GlobalDestroyObjectScript.numObjects--;
				Destroy (gameObject);
				isDestroyed = true;
			}





	}

}
