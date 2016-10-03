using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour {

	public PickupObject pickupObject;

	public Rigidbody rb;

	void Update () {

		ThrowObjectWithForce ();

	}

	public void ThrowObjectWithForce() {

		if (pickupObject.canThrow == true) {

			if (Input.GetKeyDown(KeyCode.O)) {
				Debug.Log ("Pressed Nigga");

				pickupObject.carrying = false;

				rb.useGravity = true;
				rb.AddForce (transform.forward * 3000);

			}
		}
	}
}
