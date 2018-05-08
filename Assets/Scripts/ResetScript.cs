using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour {

	public GameObject[] objects;
	private SpawnScript[] spawns;





	// Use this for initialization
	void Start () {

		for (int i = 0; i < objects.Length; i++) {
			spawns [i] = objects [i].GetComponent<SpawnScript> ();
			//transforms [i] = objects [i].G
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void reset(){
		for (int i = 0; i < objects.Length; i++) {
			
			objects [i].GetComponent<SpawnScript> ().respawn ();

		}



	}



}
