using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	Animator m_Animator;
	bool m_Attack;
	bool m_Run;
	bool m_Jump;
	float m_StationaryTurnSpeed = 180;
	float m_MovingTurnSpeed = 360;
	float m_ForwardAmount;
	private Vector3 m_CamForward;    
	private Vector3 m_Move;
	private Transform m_Cam; 
	float m_TurnAmount;
	float speed = 100f;
	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		m_Attack = Input.GetKeyDown(KeyCode.L);
		m_Run = Input.GetKey(KeyCode.LeftShift);
		m_Jump = Input.GetKeyDown(KeyCode.Space);
		ApplyExtraTurnRotation ();
		m_Animator.SetBool("Attack", m_Attack);
		m_Animator.SetBool("Run", m_Run);
		m_Animator.SetBool ("Jump", m_Jump);
		if(m_Attack) {
			//print ("attack");
			//gameObject.transform.Rotate(180* Time.deltaTime,180* Time.deltaTime, 180* Time.deltaTime);
			//m_Animator.SetBool("Attack", false);

		}
	}


	void ApplyExtraTurnRotation()
	{
		// help the character turn faster (this is in addition to root rotation in the animation)
		//float turnSpeed = Mathf.Lerp(m_StationaryTurnSpeed, m_MovingTurnSpeed, m_ForwardAmount);
		//transform.Rotate(0, m_TurnAmount * turnSpeed * Time.deltaTime, 0);
		transform.Rotate(0, Input.GetAxis("Horizontal")*Time.deltaTime*speed, 0);


		//transform.Rotate(180,180, 180);

	}

}
