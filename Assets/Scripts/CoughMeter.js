#pragma strict

var coughingSource : AudioSource;
var coughing : boolean = false;
var meterDrain : float = 0.1;
var coughTime : float = 0.0;
var maxCoughTime : float = 10.0;

var coughingSound : AudioClip;

var coughTimer : float = 10.0;


function Start () {

	coughTime = maxCoughTime;
	coughingSource = GetComponent(AudioSource);
	coughingSource.enabled = false;

}

function AlterMeter (amount : int) {

	coughTime = Mathf.Clamp(coughTime+coughTimer, 0, 100);

	}

function Update () {

	if (coughTime >= 0) {

	coughTime -= Time.deltaTime * meterDrain;

	}

	if (coughTime <= 0) {

		coughTime = 0;
		coughing = true;
		coughingSource.enabled = true;

		}

		else if (coughTime >= 0) {

		coughing = false;
		coughingSource.enabled = false;

		}

}

function CoughingSoundOn () {

	if (coughing == true) {

		coughingSource.enabled = true;
		//GetComponent.<AudioSource>().clip = coughingSound;
		GetComponent.<AudioSource>().Play();

		}

}

	@script RequireComponent(AudioSource)