using UnityEngine;
using System.Collections;

public class dieFromBear : StateMachineBehaviour {

	// OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//	
	//}
	
	// OnStateExit is called before OnStateExit is called on any state inside this state machine
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		
		Application.LoadLevel("Menu");
	}
	
	// OnStateMachineEnter is called when entering a statemachine via its Entry Node
	//	override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash) {
	//
	//	}
	
	// OnStateMachineExit is called when exiting a statemachine via its Exit Node
	//override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
	//
	//}
	

}
