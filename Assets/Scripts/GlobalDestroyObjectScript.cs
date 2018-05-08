using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDestroyObjectScript : MonoBehaviour {

	public static int numObjects = 0;

	// Use this for initialization
	void Start () {
		numObjects++;
	}
	
	// Update is called once per frame
	void Update () {
		print (numObjects);
	}
}
