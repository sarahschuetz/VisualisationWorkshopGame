using UnityEngine;
using System.Collections;

public class isClickable : MonoBehaviour {

	void OnMouseDown() {
			
		GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().useInventory(this.gameObject);

	}
}
