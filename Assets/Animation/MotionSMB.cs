using UnityEngine;
using System.Collections;

public class MotionSMB : StateMachineBehaviour {
	public float m_Damping=0.15f;
	private readonly int m_HashHorzPara=Animator.StringToHash("Horizontal");
private readonly int m_HashVerticalPara=Animator.StringToHash("Vertical");
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
//	if(Input.GetKeyDown("j")){
//	Vector2 input1=new Vector2(1,1).normalized;
//	animator.SetFloat(m_HashHorzPara,input1.x,m_Damping,15*Time.deltaTime);
//	animator.SetFloat(m_HashVerticalPara,input1.y,m_Damping,15*Time.deltaTime);
//		return;
//	}

	float hor=Input.GetAxis("Horizontal");
	float ver=Input.GetAxis("Vertical");
	//if(Input.GetKeyDown("w")){
	
     // rigd.AddForce ( * speed);
       //Debug.Log("ahahhaah");
        //Vector3 input =new Vector3(0f, 0.0f, 1f);
	//console.print("w");
	Vector2 input=new Vector2(hor,ver).normalized;
	//animator.SetFloat(m_HashHorzPara,input.x,m_Damping,15*Time.deltaTime);
	animator.SetFloat(m_HashVerticalPara,input.y,m_Damping,15*Time.deltaTime);
		//}



		
	
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//	 Debug.Log("ehdah:");
	//animator.SetFloat(m_HashHorzPara,0.0f,m_Damping,15*Time.deltaTime);
	//animator.SetFloat(m_HashVerticalPara,0.0f,m_Damping,15*Time.deltaTime);
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
