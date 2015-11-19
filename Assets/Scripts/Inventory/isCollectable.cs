using UnityEngine;
using System.Collections;

public abstract class isCollectable : MonoBehaviour {

	public Texture texture;

	// number of objects
	public int number;

	// if true, once you have the object you never loose it
	public bool forever;

	void OnMouseDown() {

		GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().addObject(this);
		gameObject.SetActive(false);
	}

	public abstract void action(GameObject g);
}