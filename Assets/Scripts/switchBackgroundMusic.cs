using UnityEngine;
using System.Collections;

public class switchBackgroundMusic : MonoBehaviour {

	public AudioClip backgroundMusicWood;
	public AudioClip backgroundMusicVillage;

	private AudioSource wood;
	private AudioSource village;


	void Start() {

		wood = SoundManager.SoundManagerInstance.Play(backgroundMusicWood, this.transform, 1f, 1f, true);


	}

	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == "Player") {

			SoundManager.SoundManagerInstance.RemoveAudioSource(wood);
			village = SoundManager.SoundManagerInstance.Play(backgroundMusicVillage, this.transform, 1f, 1f, true);
		}
	}

	void OnTriggerExit(Collider other) {
		
		if(other.gameObject.tag == "Player") {

			SoundManager.SoundManagerInstance.RemoveAudioSource(village);
			wood = SoundManager.SoundManagerInstance.Play(backgroundMusicWood, this.transform, 1f, 1f, true);
		}
	}
}
