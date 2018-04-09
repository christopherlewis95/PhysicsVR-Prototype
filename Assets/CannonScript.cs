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
	float xInitial;
	float yInitial;
	float sInitial = 0;
	float strength;
	float pstrength;
	float maxStrength = 100;
	// Use this for initialization
	void Start () {


		xInitial =  Base.transform.rotation.x;
		yInitial = Base.transform.rotation.y;
		//sInitial = this.gameObject.transform.rotation.z;
		
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
			print (currentAngleX);
			previousAngleX = currentAngleX;
			currentAngleX = currentAngleX + xInitial;
			Base.transform.eulerAngles = new Vector3(currentAngleX, -currentAngleY, 0);
			//this.transform.Rotate (currentAngleX, 0, 0);
		}
		else if (currentAngleY != previousAngleY) {
			previousAngleY = currentAngleY;
			currentAngleY = currentAngleY + yInitial;
			print (currentAngleY);
			Base.transform.eulerAngles = new Vector3(currentAngleX, -currentAngleY, 0);
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
