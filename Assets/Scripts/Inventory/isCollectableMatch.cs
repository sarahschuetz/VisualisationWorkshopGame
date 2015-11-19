using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class isCollectableMatch : isCollectable {
	
	public override void action(GameObject g) {
		
		if(g != null && g.tag == "fireplace") {
			Debug.Log ("Make fire!");

			g.GetComponentInChildren<Light>().enabled = true;

			Component[] particles = g.GetComponentsInChildren<ParticleSystem>();

			foreach(ParticleSystem particle in particles) {
				particle.Play();
			}


		}
	}
}
