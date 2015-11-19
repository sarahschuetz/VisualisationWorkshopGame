using UnityEngine;
using System.Collections;

public class showTextCamera : MonoBehaviour {

	// distance to show hints
	public float rayLength = 10;

	// reference to the camera
	private Camera cam;

	// object of last shown text
	private showTextObject textScript;

	// is there any text shown currently
	private bool textShown = false;

	// Use this for initialization
	void Start () {

		cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

		checkVisibility();

	}

	/// <summary>
	/// Checks the visibility using raycast.
	/// </summary>
	void checkVisibility() {

		Vector3 fwd = cam.transform.forward;
		RaycastHit hit;

		Debug.DrawLine(cam.transform.position, cam.transform.position + fwd * rayLength, Color.red);
		
		if (Physics.Raycast(cam.transform.position, fwd, out hit, rayLength)) {
			if(hit.transform.tag == "showHints") {

				Debug.DrawLine(cam.transform.position, cam.transform.position + fwd * rayLength, Color.green);

				MonoBehaviour m = hit.transform.gameObject.GetComponent<MonoBehaviour>();  

				if(m is showTextObject)
				{
					this.textScript = (showTextObject) m;
					this.textScript.showText();
					this.textShown = true;
				}
			} else {
				if(this.textShown) {
					
					this.textScript.hideText();
					this.textShown = false;
				}
			}              

		} else {
			if(this.textShown) {

				this.textScript.hideText();
				this.textShown = false;
			}
		}
	}
}
