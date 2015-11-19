using UnityEngine;
using System.Collections;

public class bearAnimations : MonoBehaviour {

	private bool firstTrigger = true;

	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == "Player") {

			if(this.firstTrigger) {

				gameObject.GetComponent<Animator>().GetBehaviour<randomAnimations>().jumpAndKill();

				this.firstTrigger = false;
			} else {
				GameObject.FindGameObjectWithTag("UICanvas").GetComponent<Animator>().SetTrigger("closeEyes");
			}
		}
	}
}
