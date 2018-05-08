using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
	
	public Text timerText;
	private float startTime;
	private bool update = true;
	// Use this for initialization
	void Start () {

		startTime = Time.time;

	}

	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");

		if (GlobalDestroyObjectScript.numObjects == 0) {
			update = false;
		} 
		else if (GlobalDestroyObjectScript.numObjects > 0 && update != true) {
			update = true;
		}

		else if(update == true){
			timerText.text = minutes + ":" + seconds;
		}
	}

}
