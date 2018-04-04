using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour {

	public int Handicap = 0;
	public int score;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		score = Handicap;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateScore(int additive){
		score = score + additive;
		scoreText.text = score + " Points";


	}

}
