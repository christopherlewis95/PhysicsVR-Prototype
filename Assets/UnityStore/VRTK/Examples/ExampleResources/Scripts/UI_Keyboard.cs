﻿namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;

    public class UI_Keyboard : MonoBehaviour
    {
        private InputField input;
		private GameObject field;
		private InputScript inputData;
		//public Button[] buttons;

		void Start()
		{
			input = GetComponentInChildren<InputField>();
			field= GameObject.FindGameObjectWithTag("Data");
			inputData = field.GetComponent<InputScript> ();

		}

        public void ClickKey(string character)
        {
            input.text += character;
        }

        public void Backspace()
        {
            if (input.text.Length > 0)
            {
                input.text = input.text.Substring(0, input.text.Length - 1);
            }
        }

        public void Enter()
        {
			checkValues ();

            VRTK_Logger.Info("You've typed [" + input.text + "]");
            input.text = "";
        }



		private void checkValues(){

			if (input.text == "VINH LE") {
				//mainInputField.text = "";
				inputData.activeButton(0);
			}

			if (input.text == "CHRIS") {
				//mainInputField.text = "";
				inputData.activeButton(1);
			}


		}

    }
}