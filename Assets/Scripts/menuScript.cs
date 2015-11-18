using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {
	
	public string sceneToLoad;
	
	
	// Use this for initialization
	public void StartGame () {
		Application.LoadLevel(sceneToLoad);
	}
	
	// Use this for initialization
	public void QuitGame () {
		Application.Quit();
	}
}