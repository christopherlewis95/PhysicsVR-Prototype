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


			//Use a coroutine to load the Scene in the background
		StartCoroutine(LoadYourAsyncScene("Prototype"));


	}


	public void TransitionTowerFall(){


		//Use a coroutine to load the Scene in the background
		StartCoroutine(LoadYourAsyncScene("TowerFall"));


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
