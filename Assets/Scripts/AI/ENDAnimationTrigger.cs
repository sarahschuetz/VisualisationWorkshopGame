using UnityEngine;
using System.Collections;

public class ENDAnimationTrigger : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {

		this.animator = GameObject.FindGameObjectWithTag("bearEND").GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == "bearEND") {
	
			animator.SetTrigger("stopWalking");
		}
	}
}
