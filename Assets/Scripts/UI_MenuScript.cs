using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void MainMenu (){

		SceneManager.LoadScene("TestMenu");
		CannonScript.numCannonBalls = 0;
		Target_Script.numEnemies = 0;

	}

	public void ReplayLevel(){

		SceneManager.LoadScene("ProtoType");
		CannonScript.numCannonBalls = 0;
		Target_Script.numEnemies = 0;
	}
}
