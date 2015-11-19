using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class particleManager : MonoBehaviour {

	private GameObject[] objects;
	private List<Component> particles;

	// Use this for initialization
	void Start () {

		this.objects = GameObject.FindGameObjectsWithTag("fireplace");
		this.particles = new List<Component>();

		foreach(GameObject o in this.objects){
			foreach(ParticleSystem particle in o.GetComponentsInChildren<ParticleSystem>()) {
				this.particles.Add(particle);
			}
		}

		foreach(ParticleSystem particle in this.particles) {
			particle.Stop();
		}

	}
}
