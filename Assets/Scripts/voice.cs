using UnityEngine;
using System.Collections;

public class voice : MonoBehaviour {

	public AudioClip voiceClip;
	private GameObject player;


	// Use this for initialization
	void Start () {
	
		this.player = GameObject.FindGameObjectWithTag("Player");
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {

			SoundManager.SoundManagerInstance.Play(voiceClip, this.player.transform);
		}
	}
}
