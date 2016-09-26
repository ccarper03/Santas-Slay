using UnityEngine;
using System.Collections;

public class PhonographScript : MonoBehaviour {

	public Transform target;
	public float playDistance;
	public float distance;
	public bool playSoundByDistance;
	public bool playSoundByExamined;
	public AudioSource audioSource;
	private bool inRange;
	private float timer;


	void Update(){

		distance = Vector3.Distance (target.position, transform.position);

		if (distance <= playDistance) {
			playSoundByDistance = true;
		} else
			playSoundByDistance = false;


		if (playSoundByDistance && playSoundByExamined){
			if (!audioSource.isPlaying) {
				audioSource.Play ();
			}
		}
		if (!playSoundByDistance || !playSoundByExamined) {
			audioSource.Stop ();
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			inRange = true;

		}
	}

	void OnTriggerStay (Collider other) {
		
		timer += Time.deltaTime;
		if (other.gameObject.tag == "Player") {
			if (Input.GetKeyDown (KeyCode.E)) {
				if (!audioSource.isPlaying) {
					playSoundByExamined = true;
				} else
					playSoundByExamined = false;
			}
		}
	}
		
	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
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
