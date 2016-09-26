using UnityEngine;
using System.Collections;

public class Ambience_NN : MonoBehaviour {


	//Sounds variable (may also use some of the NavMesh variable as well).
	public AudioSource ambiencePlayer;
	public AudioClip[] ambienceClip;

	public enum Areas {None, AreaZero, AreaOne, AreaTwo, AreaThree, AreaFour, AreaFive, AreaSix, AreaSeven, AreaEight, AreaNine};
	public Areas area;


	void Awake(){
		GetComponent<AudioSource> ().loop = true;
	}

	void Update(){

		if (area == Areas.AreaZero)
			EnterAreaZero ();
		if (area == Areas.AreaOne)
			EnterAreaOne ();
		if (area == Areas.AreaTwo)
			EnterAreaTwo ();
		if (area == Areas.AreaThree)
			EnterAreaThree ();
		if (area == Areas.AreaFour)
			EnterAreaFour ();
		if (area == Areas.AreaFive)
			EnterAreaFive ();
		if (area == Areas.AreaSix)
			EnterAreaSix ();
		if (area == Areas.AreaSeven)
			EnterAreaSeven ();
		if (area == Areas.AreaEight)
			EnterAreaEight ();
		if (area == Areas.AreaNine)
			EnterAreaNine ();

	}//Closing bracket for Update.

	//The area the player enters.
	void EnterAreaZero(){
		
		if (ambienceClip [0] != null) {
			ambiencePlayer.clip = ambienceClip [0];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaOne(){
		
		if (ambienceClip [1] != null) {
			ambiencePlayer.clip = ambienceClip [1];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaTwo(){
		
		if (ambienceClip [2] != null) {
			ambiencePlayer.clip = ambienceClip [2];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaThree(){
		
		if (ambienceClip [3] != null) {
			ambiencePlayer.clip = ambienceClip [3];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaFour(){
		
		if (ambienceClip [4] != null) {
			ambiencePlayer.clip = ambienceClip [4];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaFive(){
		
		if (ambienceClip [5] != null) {
			ambiencePlayer.clip = ambienceClip [5];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaSix(){
		
		if (ambienceClip [6] != null) {
			ambiencePlayer.clip = ambienceClip [6];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaSeven(){
		
		if (ambienceClip [7] != null) {
			ambiencePlayer.clip = ambienceClip [7];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaEight(){
		
		if (ambienceClip [8] != null) {
			ambiencePlayer.clip = ambienceClip [8];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}

	void EnterAreaNine(){
		
		if (ambienceClip [9] != null) {
			ambiencePlayer.clip = ambienceClip [9];
			if (!ambiencePlayer.isPlaying) {
				ambiencePlayer.Play ();
			}
		}
	}



}
