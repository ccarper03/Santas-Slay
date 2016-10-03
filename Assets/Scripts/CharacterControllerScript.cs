using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {

	public AudioClip wrapper;
	public float moveSpeed = 5f;
	public float jumpSpeed = 20;
	public float gravity = 9.8f;
	CharacterController controller;
	Vector3 currentMovement;
	public Transform cam;

	void Start () {

		controller = GetComponent<CharacterController> ();
		Cursor.lockState = CursorLockMode.Locked;

	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.L)) {

			Debug.Log ("hit L key");
			
			RaycastHit hit;
			Ray ray = new Ray (cam.position, cam.forward);

			if (Physics.Raycast (ray, out hit, 2f)) {

				if (hit.collider.tag == "CoughDrop") {

					Debug.Log ("hit coughdrop");

					AudioSource.PlayClipAtPoint (wrapper, hit.collider.transform.position);

					Destroy (hit.collider.gameObject);

					Debug.Log ("killed Object");

					}
				}
			}



			float translation = Input.GetAxis ("Vertical") * moveSpeed;
			float straffe = Input.GetAxis ("Horizontal") * moveSpeed;
			translation *= Time.deltaTime;
			straffe *= Time.deltaTime;

			transform.Translate (straffe, 0, translation);

			if (Input.GetKeyDown ("escape"))
				Cursor.lockState = CursorLockMode.None;


			if (controller.isGrounded == false)
				currentMovement -= new Vector3 (0, gravity * Time.deltaTime, 0);
			else
				currentMovement.y = 0;

			if (controller.isGrounded && Input.GetButtonDown ("Jump"))
				currentMovement.y = jumpSpeed;

			controller.Move (currentMovement * Time.deltaTime);


		}

}