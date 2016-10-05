using UnityEngine;
using System.Collections;

public class HighlightObjectTable : MonoBehaviour {

	public GUISkin GameSkin;
	public string objectName;
	public Transform cam;

	public Color startColor;
	public bool _displayObjectName = false;
	public bool selected = false;


	void Start () {

		startColor = GetComponent<Renderer> ().material.color;

	}


	void Update () {

		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast (ray, out hit, 2f)) {

			if (hit.collider.tag == "Table") {

				GetComponent<Renderer> ().material.color = Color.blue;
				_displayObjectName = true;
				selected = true;

				Debug.DrawLine (ray.origin, hit.point, Color.green);

			}

		}



		else {

			GetComponent<Renderer>().material.color = startColor;
			_displayObjectName = false;
			selected = false;

		}

	}


	void OnGUI () {

		GUI.skin = GameSkin;

		DisplayName ();

	}

	public void DisplayName () {

		if (_displayObjectName == true) {
			//dsplay object name

		}	
	}
}