﻿using UnityEngine;
using System.Collections;

public class PaddleLeft : MonoBehaviour {

	public static HingeJoint hinge;// = GetComponent<HingeJoint>();
	public static JointMotor motor;// = hinge.motor;

	public float targetVel = 400;
	public float power = 1000;
	public string inputKeyName = "left";

	// Use this for initialization
	void Start () {
		hinge = GetComponent<HingeJoint>();
		 motor = hinge.motor;
		motor.force = 0;
		motor.targetVelocity = 90;
		motor.freeSpin = false;
		hinge.motor = motor;
		hinge.useMotor = true;

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (inputKeyName)) {
			//Debug.Log ("Space Was Pressed");
			motor.force = power;
			motor.targetVelocity = targetVel;
			motor.freeSpin = false;
			hinge.motor = motor;
			hinge.useMotor = true;

				} 
		else 
		{
			motor.force = 0;
			motor.targetVelocity = targetVel;
			motor.freeSpin = false;
			hinge.motor = motor;
			hinge.useMotor = false;


				}

	}
}
