using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class fireScript : MonoBehaviour {

	private bool isBurning;
	private float time = 10;

	private List<GameObject> bearList;

	// Use this for initialization
	void Start () {

		// --- TESTING !!!!!!!!!!!!!!!!!!!!!!
		isBurning = true;
		this.bearList = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

		if(isBurning) {
			if(this.time > 0) {

				this.time -= Time.deltaTime;

			} else {

				// --- TESTING !!!!!!!!!!!!!!!!!!!!!!
				//this.isBurning = false;
				//this.resetBears();
			}
		}
	}

	void OnTriggerEnter(Collider other) {

		if(isBurning) {

			if(other.gameObject.tag == "bear") {

				if(!this.bearList.Contains(other.gameObject)) {
					this.bearList.Add(other.gameObject);
					Debug.Log("ADD BEAR");
				}
				other.gameObject.GetComponent<Animator>().GetBehaviour<randomAnimations>().stopFollowing();
			}
		}
	}

	void OnTriggerExit(Collider other) {
		
		if(isBurning) {
			
			if(other.gameObject.tag == "Player") {

				this.resetBears();
			}
		}
	}

	public void makeFire(float time) {

		this.time = time;
		this.isBurning = true;
	}

	public void resetBears() {

		foreach(GameObject bear in this.bearList) {
			
			if(bear.GetComponentInParent<followNavMesh>() != null) {
				bear.GetComponentInParent<followNavMesh>().leaveFireplace();
			}
		}

		this.bearList.Clear();
	}
}