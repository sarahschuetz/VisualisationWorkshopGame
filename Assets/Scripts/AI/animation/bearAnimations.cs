using UnityEngine;
using System.Collections;

public class bearAnimations : MonoBehaviour {

	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == "Player") {
			EventManager.triggerEvent("jumpAndKill");
			//Debug.Log("KILL");
		}
	}
}
