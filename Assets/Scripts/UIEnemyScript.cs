using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEnemyScript : MonoBehaviour {


	public int enemies;
	//public int score;
	public Text scoreText;
	public GameObject GameOverCanvas;
	Target_Script targets;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		enemies = Target_Script.numEnemies; // REALLY LAZY METHOD SO WHEN PEOPLE READ THIS... I AM AWARE ITS BAD - Chris (Hidden talent diminished)



	}

	void LateUpdate(){

		if (enemies == 0) {
			scoreText.text = " TARGETS DOWN ";
			GameOverCanvas.SetActive(true);
		}

		else {
			scoreText.text = enemies + " Enemies Left";
		}




	}


}
