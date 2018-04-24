using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputScript : MonoBehaviour {

	public InputField mainInputField;
	public Button[] buttons;
	Text textbox;
	// private InventoryScript myInventory;

	public void Start()
	{
		//myInventory = GameObject.Find("Inventory").GetComponent<InventoryScript> ();
	}

	public void Update()
	{
		

		/*
		if () {
			//mainInputField.text = "";
			buttons [0].gameObject.SetActive (true);
		}

		else if (mainInputField.text == "0Prblems") {
			mainInputField.text = "";
			myInventory.ZeroProblems ();

		} 

		else if (mainInputField.text == "Jerry") {
			mainInputField.text = "";
			myInventory.Teeny ();

		} 

		else if (mainInputField.text == "Tom") {
			mainInputField.text = "";
			myInventory.NoTeeny ();

		} 

		else if (mainInputField.text == "BoofManGu") {
			mainInputField.text = "";
			myInventory.Boof ();

		} 

		else if (mainInputField.text == "ShrimpNoodle") {
			mainInputField.text = "";
			myInventory.NoBoof ();

		} 

		else if (mainInputField.text == "TeleportOne") {
			mainInputField.text = "";
			SceneManager.LoadScene ("Level1");

		} 

		else if (mainInputField.text == "TeleportTwo") {
			mainInputField.text = "";
			SceneManager.LoadScene ("Level2");

		} 

		else if (mainInputField.text == "TeleportThree") {
			mainInputField.text = "";
			SceneManager.LoadScene ("Level3");
		

		} 

		else if (mainInputField.text == "TeleportAltThree") {
			mainInputField.text = "";
			SceneManager.LoadScene ("Level3-Alt");


		} 


		else if (mainInputField.text == "TeleportFour") {
			mainInputField.text = "";
			SceneManager.LoadScene ("Level4");

		}

*/
	}
	public void activeButton(int index, string name){

		if (index == 0) {
			buttons [0].gameObject.SetActive (true);
			textbox = buttons [0].GetComponentInChildren<Text> ();
			textbox.text = name;


		}

		if (index == 1) {
			buttons [1].gameObject.SetActive (true);
			textbox = buttons [1].GetComponentInChildren<Text> ();
			textbox.text = name;
		}

		if (index == 2) {
			buttons [2].gameObject.SetActive (true);
			textbox = buttons [2].GetComponentInChildren<Text> ();
			textbox.text = name;
		}
	}
}
