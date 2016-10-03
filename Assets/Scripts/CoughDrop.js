#pragma strict

var CoughDropGrab : AudioSource;
var buttonInRange;
var buttonActivated;
var coughMeter : CoughMeter;
var coughTimer : float = 10;
public var useCoughdrop : AudioClip;


public var guiSkin : GUISkin;

private var hasPlayed = false;

function Start() {

	

}


function Update () {
	// use a cough drop
	if (Input.GetKeyDown (KeyCode.B) ) {
		
		// reduce cough drops by 1

		// add time to cough timer

		coughMeter.AlterMeter(coughTimer);

		// play sound effect

		AudioSource.PlayClipAtPoint (useCoughdrop, transform.position);


	}

}
