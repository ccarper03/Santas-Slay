using UnityEngine;
using System.Collections;

public class SoundEffect_NN : MonoBehaviour {

	public AudioSource soundSource;
	public AudioClip soundEffect;
	private bool inRange;
	public bool destroyAfterExamine;

	public enum PlaySound {AutoPlay, PlayOnTouch};
	public PlaySound playSound;

	void Awake(){
		GetComponent<AudioSource> ().loop = false;
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Player") {
			inRange = true;
		}
	}

	void OnTriggerExit(Collider other){
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
			if (playSound == PlaySound.AutoPlay) {
                soundSource.clip = soundEffect;
				if (!soundSource.isPlaying) {
					soundSource.Play ();
                    if (destroyAfterExamine)
                    {
                        Destroy(gameObject, soundEffect.length);
                    }
                }
			}

			if (playSound == PlaySound.PlayOnTouch) {
				GUI.Label (new Rect (Screen.width / 2 - 200, Screen.height / 2 + 100, 300, 50), "Press 'E' to examine!", myStyle);

				if (Input.GetKeyDown (KeyCode.E)) {
					soundSource.clip = soundEffect;
					soundSource.Play();
					if (destroyAfterExamine) {
						Destroy (gameObject, soundEffect.length);
					}
				}
			}
		}
	}
}
