using UnityEngine;
using System.Collections;

public class inputManager : MonoBehaviour {

	private bool paused;

	// Use this for initialization
	void Start () {

		this.paused = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("p")){

			if(!paused) {
				Time.timeScale = 0;
				paused = true;
				Debug.Log("PAUSE");
			} else {
				Time.timeScale = 1;
				paused = false;
				Debug.Log("End PAUSE");
			}
		}
	}
}
