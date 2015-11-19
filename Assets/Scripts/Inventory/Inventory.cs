using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	private List<isCollectable> allObjects;
	private bool seeInventory = false;

	private GameObject lastClickedGameObject;
	
	// Use this for initialization
	void Start () 
	{
		this.allObjects = new List<isCollectable>();
		this.lastClickedGameObject = null;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.I) && !seeInventory) {

			seeInventory = true;

		} else if(Input.GetKeyDown(KeyCode.I) && seeInventory) {

			seeInventory = false;
		}

		if(seeInventory)
		{
			if(Input.GetKeyDown(KeyCode.Alpha1))
			{

			}
		}
	}

	int calculateInventoryHeight() {

		if(allObjects.Count == 0) {
			return 50;
		} else {
			return 20 + 55 * allObjects.Count + 5;
		}
	}
	
	void OnGUI () 
	{
		if(seeInventory)
		{
			GUIStyle style = new GUIStyle(GUI.skin.GetStyle("Window"));
			style.onNormal = style.normal;

			GUI.Window(0, new Rect(10, 10, 80, calculateInventoryHeight()), InventoryGUI, "Inventory", style);
		}
	}
	
	void InventoryGUI (int id)
	{
		//GUI.skin = numberSlot;

		int yPosition = 20;

		List<isCollectable> remove = new List<isCollectable>();

		foreach(isCollectable currentObject in allObjects) {

			if(GUI.Button(new Rect(10, yPosition, 60, 50), currentObject.texture)) {

				if(this.lastClickedGameObject != null) {

					currentObject.action(this.lastClickedGameObject);
				

					if(!currentObject.forever) {

						currentObject.number--;

						if(currentObject.number < 1) {
							remove.Add(currentObject);
						}
					}

					this.seeInventory = false;
				
				}
			}

			if(!currentObject.forever) {

				GUI.Label(new Rect(15, yPosition, 20, 40), currentObject.number.ToString() + "x");
			}

			yPosition += 55;
		}

		foreach(isCollectable currentObject in remove) {
			this.allObjects.Remove(currentObject);
		}
	}

	public void addObject(isCollectable currentObject) {

		if(!this.seeInventory) {
			this.seeInventory = true;
		}

		this.lastClickedGameObject = null;

		if(!this.allObjects.Contains(currentObject)) {
			this.allObjects.Add(currentObject);
		}
	}

	public void useInventory(GameObject g) {

		if(!this.seeInventory) {
			this.seeInventory = true;
		}

		this.lastClickedGameObject = g;
	}
}
