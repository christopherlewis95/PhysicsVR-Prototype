using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameInfoScript : MonoBehaviour {
	public GameObject GameOverCanvas;
	public static int Handicap = 0;
	public static int score = 0;
	public static int finalScore;
	public bool ballsOn;
	public bool scoreOn;
	public bool enemiesOn;
	public bool gameOverOn;
	public Text textBox;

	private int enemies;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreOn == true) {
			

			if (Target_Script.numEnemies == 0) {

				finalScore = score * CannonScript.numCannonBalls;
				scoreOn = false;
			}

			else if (Target_Script.numEnemies == 0 && CannonScript.numCannonBalls == 0) {

				finalScore = score;
				scoreOn = false;
			}

			else if ((CannonScript.numCannonBalls == 0) && Target_Script.numEnemies > 0) {

				print ("UH OH");
				finalScore = 0;
				if(!GameOverCanvas.activeInHierarchy)
				scoreOn = false;
				GameOverCanvas.SetActive (true);
				
			} 


			textBox.text =   "x " + score;



		}

		else if(ballsOn == true){

			textBox.text = CannonScript.numCannonBalls + " Left"; // Is really Lazy... I am aware - Chris
		}

		else if(enemiesOn == true){

			enemies = Target_Script.numEnemies; // REALLY LAZY METHOD SO WHEN PEOPLE READ THIS... I AM AWARE ITS BAD - Chris (Hidden talent diminished)

			if (enemies == 0) {
				textBox.text = " TARGETS DOWN ";
				enemiesOn = false;



				if(!GameOverCanvas.activeInHierarchy)



			

				GameOverCanvas.SetActive(true);
			}

			else {
				textBox.text = enemies + " Enemies Left";
			}
		}

		else if( gameOverOn ) 
			textBox.text = CannonScript.numCannonBalls + " Shots x " + score + " = " + finalScore + " Points";


	}



	public void UpdateScore(int additive){
		score = score + additive;
	}


	IEnumerator delay(int time)
	{
		//print(Time.time);
		yield return new WaitForSeconds(time);
		//particleDestroy.Stop ();
		//print(Time.time);
	}

}
