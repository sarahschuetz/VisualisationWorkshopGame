using UnityEngine;
using System.Collections;

public abstract class isCollectable : MonoBehaviour {

	public Texture texture;

	// number of objects
	public int number;

	// if true, once you have the object you never loose it
	public bool forever;

	// Use this for initialization
	void Start () {
		this.number = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {

		GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().addObject(this);
		gameObject.SetActive(false);
	}

	public abstract void action();
}