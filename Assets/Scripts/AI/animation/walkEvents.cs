using UnityEngine;
using System.Collections;

public class walkEvents : StateMachineBehaviour {

	private GameObject gameObject;
	private bool firstAnimation = true;

	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

		if(firstAnimation) {
			this.gameObject = animator.gameObject;

			this.firstAnimation = false;
		}
		//EventManager.triggerEvent("startMoving");
		gameObject.GetComponentInParent<moveAround>().startMoving();
		//Debug.Log("start moving");
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		//EventManager.triggerEvent("stopMoving");
		gameObject.GetComponentInParent<moveAround>().stopMoving();
		//Debug.Log("stop moving");
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
