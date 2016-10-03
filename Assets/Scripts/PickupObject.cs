using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour {

	GameObject mainCamera;
	public bool carrying;
	GameObject ObjectCube;
	public float distance;
	public float smooth;
	public bool canThrow;

	// Use this for initialization
	void Start () {
	
		mainCamera = GameObject.FindWithTag ("MainCamera");

	}
	
	// Update is called once per frame
	void Update () {
		if (carrying) {
			carry (ObjectCube);
			checkDrop ();

		} else {
			pickup ();
		}

	}
	void carry(GameObject o) {
		o.transform.position = Vector3.Lerp (o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
		o.transform.rotation = Quaternion.identity;
	}

	void pickup () {
		if (Input.GetKeyDown (KeyCode.L)) {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3 (x, y));
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				Pickupable p = hit.collider.GetComponent<Pickupable>();
				if (p != null) {
					carrying = true;
					canThrow = true;
					ObjectCube = p.gameObject;
					//p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
					p.gameObject.GetComponent<Rigidbody>().useGravity = false;
			
				}
			}
		}
	}

	void checkDrop() {
		if (Input.GetKeyDown(KeyCode.L)) {
			dropObject ();
		}
	}

	void dropObject () {
		carrying = false;
		canThrow = false;
		//ObjectCube.gameObject.GetComponent<Rigidbody>().isKinematic = false;
		ObjectCube.gameObject.GetComponent<Rigidbody>().useGravity = true;
		ObjectCube = null;
	}
}