﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sapiControl : MonoBehaviour {
	private Rigidbody2D myRigidBody;
	private Animator myAnim;
	public float sapiJump = 500f;


	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Jump")) {
			myRigidBody.AddForce (transform.up * sapiJump);
		}
		myAnim.SetFloat ("vVelocity", myRigidBody.velocity.y);
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer ("Enemy")) {
			Application.LoadLevel (Application.loadedLevel);
		}

	}
}



