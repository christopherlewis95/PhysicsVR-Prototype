using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK;

public class SceneSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void TransitionKinematics (){
		CannonScript.numCannonBalls = 0;
		Target_Script.numEnemies = 0;
		GameInfoScript.score = 0;
		GameInfoScript.finalScore = 0;
		GlobalDestroyObjectScript.numObjects = 0;
		DestroyAllGameObjects ();

			//Use a coroutine to load the Scene in the background
		StartCoroutine(LoadYourAsyncScene("Prototype"));


	}


	public void TransitionTowerFall(){
		CannonScript.numCannonBalls = 0;
		Target_Script.numEnemies = 0;		
		GameInfoScript.score = 0;
		GameInfoScript.finalScore = 0;
		GlobalDestroyObjectScript.numObjects = 0;

		DestroyAllGameObjects ();

		//Use a coroutine to load the Scene in the background
		StartCoroutine(LoadYourAsyncScene("TowerFall"));


	}

	public void TransitionMenu(){
		CannonScript.numCannonBalls = 0;
		Target_Script.numEnemies = 0;
		GameInfoScript.score = 0;
		GameInfoScript.finalScore = 0;
		GlobalDestroyObjectScript.numObjects = 0;
		DestroyAllGameObjects ();
	
		//Use a coroutine to load the Scene in the background
		StartCoroutine(LoadYourAsyncScene("TestMenu"));


	}
	private void DestroyAllGameObjects(){

		GameObject[] GameObjects = (FindObjectsOfType<GameObject> () as GameObject[]);

		for (int i = 0; i < GameObjects.Length; i++) {
			Destroy (GameObjects [i]);

		}
	}

	IEnumerator LoadYourAsyncScene(string name)
	{
		// The Application loads the Scene in the background at the same time as the current Scene.
		//This is particularly good for creating loading screens. You could also load the Scene by build //number.
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(name);

		//Wait until the last operation fully loads to return anything
		while (!asyncLoad.isDone)
		{
			yield return null;
		}
	}


}
