using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructibleScript : MonoBehaviour {

	public GameObject replacement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "destructive")
		{
			replacement.SetActive (true);
			gameObject.SetActive (false);
		}
	}

}
