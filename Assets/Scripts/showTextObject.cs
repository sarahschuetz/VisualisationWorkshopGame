using UnityEngine;
using System.Collections;

public class showTextObject : MonoBehaviour {
	
	public string[] messages;

	// reference to the camera
	private Camera cam;

	// is text visible
	private bool shown = false;

	// offset of the center to the gameobject
	public Vector3 offset;

	// offset of the words to the center
	public float wordOffset;
	
	// reference of textPrefab
	public GameObject textPrefab;
	
	// array with all GameObjects(messages)
	private GameObject[] allMessages;

	// an empty prefab, to rotate to the camera view
	public GameObject emptyPrefab;

	// an empty object, to rotate to the camera view
	private GameObject empty;
	
	// Use this for initialization
	void Start () {

		cam = GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Camera>();
		
		allMessages = new GameObject[messages.Length];
		int count = 0;

		this.empty = Instantiate(this.emptyPrefab, transform.position + this.offset, Quaternion.identity) as GameObject;
		this.empty.transform.parent = this.transform;

		Vector3 offsetWords = new Vector3(1, 0, 0);
		float degrees = 0;

		if(this.messages.Length > 1) {
			offsetWords =  Quaternion.Euler(0, 0, 45.0f) * offsetWords;
			degrees = 90.0f / (this.messages.Length - 1);
		} else {
			offsetWords =  Quaternion.Euler(0, 0, 90.0f) * offsetWords;
		}

		foreach (var text in messages)
		{
			GameObject g = Instantiate(textPrefab, this.empty.transform.position + offsetWords * wordOffset, Quaternion.identity) as GameObject;	
			TextMesh t = g.GetComponent<TextMesh>();
			t.text = text;
			g.transform.parent = empty.transform;

			allMessages[count] = g;
			count++;
			g.SetActive(false);

			offsetWords = Quaternion.Euler(0, 0, degrees) * offsetWords;
		}
	}

	void Update () {

		//Debug.DrawLine(this.empty.transform.position, this.empty.transform.position + offsetWords * wordOffset, Color.blue);

		if(shown) {
			empty.transform.LookAt(cam.transform);
			empty.transform.RotateAround(empty.transform.position, new Vector3(0, 1, 0), 180);
		}
	}

	/// <summary>
	/// Shows the text.
	/// </summary>
	public void showText()
	{	
		foreach (var text in allMessages) {
		//	Vector3 direction = (cam.transform.position - textPosition).normalized;

			text.SetActive(true);
			this.shown = true;

		}
	}

	/// <summary>
	/// Hides the text.
	/// </summary>
	public void hideText()
	{
		foreach (var text in allMessages) {
			text.SetActive(false);
			this.shown = false;
		}
	}
}
