using UnityEngine;
using System.Collections;

public class paddleControl1 : MonoBehaviour {
	public static HingeJoint hing;
	//public static JointSpring spr;
	public static JointLimits lm;
	//public static Rigidbody rb;
	JointSpring js;
	public float fuerza=1000f;
	public float damper=25f;
	public float giroI = -10f;
	public float giroF = 70f;
	public string name= "right";
	// Use this for initialization
	void Start () {
		hing = GetComponent<HingeJoint>();

		//spr = hing.spring;
		hing.useSpring = true;






	}

	// Update is called once per frame
	void Update () {

		JointSpring sp = new JointSpring ();
		JointLimits lm = new JointLimits();
		sp.spring = fuerza;
		sp.damper = damper;

		if (Input.GetKey (name)) {

			sp.targetPosition = giroI;

		} else {
			sp.targetPosition = giroF;
		}

		hing.spring = sp;

	}
}
