using UnityEngine;
using System.Collections;

public class PhonographScript : MonoBehaviour {

	public Transform target;
	public float playDistance;
	public float examineDistance;
	private float distance;
	public bool playSoundByDistance;
	public bool playSound = true;
	public AudioSource audioSource;
	private bool inRange;
	private float timer;



	void Update(){

		distance = Vector3.Distance (target.position, transform.position);

		if (distance <= playDistance) {
			playSoundByDistance = true;
		} else
			playSoundByDistance = false;


		if (playSoundByDistance && playSound){
			if (!audioSource.isPlaying) {
				audioSource.Play ();
			}
		}
		if (!playSoundByDistance || !playSound) {
			audioSource.Stop ();
		}

		if (distance <= examineDistance) {
			inRange = true;
			timer += Time.deltaTime;
		}
		if (inRange) {
			if (Input.GetKeyDown (KeyCode.E) && timer >= 0.4f) {
				timer = 0;
				if (!audioSource.isPlaying) {
					playSound = true;
				} else
					playSound = false;
			}
		}
		if (distance > examineDistance) {
			inRange = false;
		}
	}
		


	void OnGUI(){
		GUIStyle myStyle;

		myStyle = new GUIStyle ("Label");
		myStyle.normal.textColor = Color.yellow;
		myStyle.fontSize = 20;


		if (inRange) {
			GUI.Label (new Rect (Screen.width / 2 - 200, Screen.height / 2 + 100, 300, 50), "Press 'E' to examine!", myStyle);
		}
	}

}
