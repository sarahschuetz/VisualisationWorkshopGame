using UnityEngine;
using System.Collections;

public class bearENDAnimation : MonoBehaviour {

	private bool firstTrigger = true;
	
	void OnTriggerEnter(Collider other) {
		
//		if(other.gameObject.tag == "Player") {
//			
//			if(this.firstTrigger) {
//				EventManager.triggerEvent("jumpAndKill");
//				this.firstTrigger = false;
//				Debug.Log("firstTrigger");
//			} else {
//				GameObject.FindGameObjectWithTag("UICanvas").GetComponent<Animator>().SetTrigger("closeEyes");
//				Debug.Log("secondTrigger");
//			}
//		}
	}
}
