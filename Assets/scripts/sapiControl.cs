using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sapiControl : MonoBehaviour {
	private Rigidbody2D myRigidBody;
	private Animator myAnim;
	public float sapiJump = 500f;
	private float sapiDeathTime = -1;
	private Collider2D myCollider;
	public GameObject gameOverText, restartButton, mainMenu;
	public AudioSource jumpsfx;
	public AudioSource deathmusic;



	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator>();
		myCollider = GetComponent<Collider2D> ();
		gameOverText.SetActive (false);
		restartButton.SetActive (false);
		mainMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {


		if (sapiDeathTime == -1) {
			
		if (Input.GetButtonUp ("Jump")) {
			myRigidBody.AddForce (transform.up * sapiJump);
				jumpsfx.Play ();
		}
		myAnim.SetFloat ("vVelocity", myRigidBody.velocity.y);

	}

		else {
			if (Time.time > sapiDeathTime + 4) {

				//Application.LoadLevel (Application.loadedLevel);
				gameOverText.SetActive (true);
				restartButton.SetActive (true);
				mainMenu.SetActive (true);
				gameObject.SetActive (false);

			}
		}
	}


	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer ("Enemy")) {
			//Application.LoadLevel (Application.loadedLevel);
			sapiDeathTime = Time.time;
			myAnim.SetBool ("sapideath", true);
			myRigidBody.velocity = Vector2.zero;
			myRigidBody.AddForce (transform.up * sapiJump); 
			myCollider.enabled = false;
			deathmusic.Play ();

		
		}

	}
}



