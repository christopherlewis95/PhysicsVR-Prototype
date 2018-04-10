using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;


public class CannonScript : MonoBehaviour {

	private GameObject HLever;
	private GameObject VLever;
	private GameObject SKnob;
	public GameObject explosion;

	HLeverScript hLeverData;
	VLeverScript vLeverData;
	SLeverScript sKnobData;
	ParticleSystem particleExplosion;
	private bool played;

	public GameObject Base;
	//public GameObject intit
	public Transform firepoint;
	public GameObject cannonBall;
	float currentAngleX;
	float previousAngleX;
	float currentAngleY;
	float previousAngleY;
	float changedX;
	float changedY;

	float xInitial = 0;
	float yInitial = 0;
	float sInitial = 0;
	float strength;
	float pstrength;
	Vector3 initials;
	float maxStrength = 100;
	// Use this for initialization



	void Awake(){
		//xInitial = this.transform.rotation.eulerAngles.x;
		//yInitial = this.transform.rotation.eulerAngles.y;

	}



	void Start () {

		//sInitial = this.gameObject.transform.rotation.z;
		//Base = GetComponent<Transform>();
		initials = this.transform.eulerAngles;

		xInitial = initials.x;
		changedX = xInitial;
		print ("X Initial is" + xInitial);
		yInitial = initials.y;
		changedY = yInitial;
		print ("Y Initial is" + yInitial);

		HLever= GameObject.FindGameObjectWithTag("HLever");
		hLeverData = HLever.GetComponent<HLeverScript> ();
		 VLever = GameObject.FindGameObjectWithTag("VLever");
		vLeverData = VLever.GetComponent<VLeverScript> ();
		SKnob = GameObject.FindGameObjectWithTag("SLever");
		sKnobData = SKnob.GetComponent<SLeverScript> ();

		particleExplosion = explosion.GetComponent<ParticleSystem> ();

	}
	
	// Update is called once per frame
	void Update () {
		currentAngleY = hLeverData.getAngle (); // Swivel Left and Right
		currentAngleX = vLeverData.getAngle (); // Up and Down
		strength = sKnobData.getAngle ();

		//LateUpdate ();
	}

	void LateUpdate(){
		
		if (currentAngleX != previousAngleX) {
			print ("Current Angle X: " + currentAngleX);
			previousAngleX = currentAngleX;
			changedX = currentAngleX + xInitial;

			print ("Current Angle X After Reassign: " + currentAngleX);
			this.transform.eulerAngles = new Vector3(changedX, changedY, 0);
			//this.transform.Rotate (currentAngleX, 0, 0);
		}
		else if (currentAngleY != previousAngleY) {
			print ("Current Angle Y: " + currentAngleY);
			previousAngleY = currentAngleY;
			changedY = -currentAngleY + yInitial;

			this.transform.eulerAngles = new Vector3(changedX, changedY, 0);
			//this.transform.Rotate (0 ,currentAngleY, 0);
		}

		else if ( strength != pstrength) {
			pstrength = strength;
			//strength = strength + sInitial;
			//shooooooott ();

		}
	
	}

	public void shooooooott(){
		//played = true;
		var bullet = Instantiate (cannonBall, firepoint.position, firepoint.rotation);
		particleExplosion.Play ();
	
		StartCoroutine (delay(1));


		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * (40*(strength/maxStrength));

	}

	IEnumerator delay(int time)
	{
		//print(Time.time);
		yield return new WaitForSeconds(time);
		particleExplosion.Stop ();
		//print(Time.time);
	}
}
