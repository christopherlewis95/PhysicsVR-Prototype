namespace VRTK.Examples
{
	using UnityEngine;
	using UnityEventHelper;

	public class VLeverScript : MonoBehaviour
	{
		public TextMesh go;
		private VRTK_Control_UnityEvents controlEvents;
		float angle;

		private void Start()
		{
			controlEvents = GetComponent<VRTK_Control_UnityEvents>();
			if (controlEvents == null)
			{
				controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
			}

			controlEvents.OnValueChanged.AddListener(HandleChange);
		}

		private void HandleChange(object sender, Control3DEventArgs e)
		{
			go.text = "Arc: " + (-e.value).ToString()  + " Degrees";
			angle = e.value;
		}

		public float getAngle(){


			return this.angle;

		}

	}
}