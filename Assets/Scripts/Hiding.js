#pragma strict


var camera1 : Camera;
var hidingCamera : Camera;
var rayLength = 3;
var isHiding : boolean = false;
private var guiShow : boolean = false;

function Start () {

	camera1.GetComponent.<Camera>().enabled = true;
	hidingCamera.GetComponent.<Camera>().enabled = false;

}

function Update () {

	var hit : RaycastHit;
	var fwd = transform.TransformDirection(Vector3.forward);

	if(Physics.Raycast(transform.position, fwd, hit, rayLength)) {

		if (hit.collider.gameObject.tag == "Table" || hit.collider.gameObject.tag == "Present" || hit.collider.gameObject.tag == "Curtains"  && isHiding == false) {

		guiShow = true;
		if(Input.GetKeyDown("h")) {

		//Disable Player
		GameObject.Find("Player1").GetComponent(CharacterController).enabled = false;
		GameObject.Find("Player1").GetComponent(MeshRenderer).enabled = false;

		//change camera

		camera1.GetComponent.<Camera>().enabled = false;
		hidingCamera.GetComponent.<Camera>().enabled = true;

		Wait();

		}

		}

		}

		else {

		guiShow = false;

		}

		if(isHiding == true) {

		if(Input.GetKeyDown("h")) {


			GameObject.Find("Player1").GetComponent(CharacterController).enabled = true;
			GameObject.Find("Player1").GetComponent(MeshRenderer).enabled = true;



			camera1.GetComponent.<Camera>().enabled = true;
			hidingCamera.GetComponent.<Camera>().enabled = false;

			isHiding = false;

			}

			}

			}

	function Wait() {

	yield WaitForSeconds(0.5);
	isHiding = true;
	guiShow = false;

}

function OnGUI() {

	if(guiShow == true) {

		GUI.Box(Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Hide Inside");

		}
	}