using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;



	void FixedUpdate(){
		if (Input.GetKey (KeyCode.Space)) {
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
	}
}
