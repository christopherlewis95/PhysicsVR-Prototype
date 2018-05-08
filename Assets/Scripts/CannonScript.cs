using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;


public class CannonScript : MonoBehaviour {

	public int setBalls = 0;

	public static int numCannonBalls;

	private GameObject HLever;
	private GameObject VLever;
	private GameObject SKnob;
	public GameObject explosion;

	public GameObject blast;
	AudioSource cannonBlast;

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
		numCannonBalls = setBalls;
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
		cannonBlast = blast.GetComponent<AudioSource> ();

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

		if (GlobalControlScript.canShoot == true) {
			GlobalControlScript.canShoot = false;
			print ("YES");
			if (numCannonBalls != 0) {
				numCannonBalls--;
				var bullet = Instantiate (cannonBall, firepoint.position, firepoint.rotation);
				particleExplosion.Play ();
				cannonBlast.Play ();
	
				StartCoroutine (delay (2.0f, 1));
				StartCoroutine (delay (0.2f, 2));

				bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * (40 * (strength / maxStrength));
		
			}
		}

	}

	IEnumerator delay(float time, int track)
	{
		//print(Time.time);

		yield return new WaitForSeconds(time);

		if (track == 1) {
			particleExplosion.Stop ();
			cannonBlast.Stop ();
		} else if (track == 2) {
			GlobalControlScript.canShoot = true;

		}
		//;
		//print(Time.time);
	}

	/*
	IEnumerator delayShot(float time)
	{
		//print(Time.time);

		GlobalControlScript.canShoot = true;
		//print(Time.time);
	}
	*/
}
