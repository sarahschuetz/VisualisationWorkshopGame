using UnityEngine;
using UnityEngine.Events;
using System.Collections; 

public class followNavMesh : MonoBehaviour {
	
	// Object which should follow something
	NavMeshAgent agent;
	
	// Object which the current object will follow
	public Transform target;
	
	// Distance the follower starts following
	public int followDistance = 100;
	
	// What is the distance between you and your follower
	private float distance;

	// Is there already a message sent, that the object is currently following the target
	private bool followingMessageSent;

	private bool following;

	private randomAnimations randomAnim;
	


	// Use this for initialization
	void Start () {
		
		this.agent = GetComponent<NavMeshAgent>();
		this.followingMessageSent = false;
		this.following = false;
		this.randomAnim = gameObject.GetComponentInChildren<Animator>().GetBehaviour<randomAnimations>();

	}
	
	// Update is called once per frame
	void Update () {
		
		this.distance = Vector3.Distance(target.position, transform.position);

		// Debug.Log(this.distance);
		
		if(this.distance <= this.followDistance) {

			if(!this.followingMessageSent) {

				this.followingMessageSent = true;

			/*	switch(gameObject.tag) {
				case "bear01":
					EventManager.triggerEvent("startFollowing01");
					Debug.Log("01");
					break;

				case "bear02":
					EventManager.triggerEvent("startFollowing02");
					Debug.Log("02");
					break;
				}*/
			
				if(this.randomAnim != null) {
					this.randomAnim.startFollowing();
				}

				//Debug.Log(gameObject.GetComponentInChildren<StateMachineBehaviour>());

				//RuntimeAnimatorController controller = gameObject.GetComponentInChildren<Animator>().runtimeAnimatorController;

				//controller
				//Debug.Log(controller);
				//.startFollowing();

			} else {

				if(this.following) { 

					//Debug.Log("START MOVING");
					agent.Resume();
					agent.SetDestination(target.position);
				}
			}
		}
	}

	// EventManager
	/*private UnityAction listener; 
	
	void Awake() {
		this.listener = new UnityAction(startMoving);
	}
	
	void OnEnable() {
		EventManager.startListening("startFollowMoving", this.listener);
	}
	
	void OnDisable() {
		EventManager.stopListening("startFollowMoving", this.listener);
	}*/
	
	public void startFollowMoving() {
		this.following = true;;
	}
}
