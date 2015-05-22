﻿using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {

	//public int giftingScore;
	int winningCount;
	int winningScore = 1;
	int previousScore;
	int currentScore;
	float moveForce = 20f;
	float jumpForce = 500f;
	public Transform groundCheck;
	public Transform winningCheck;
	public GUIText Score;
	bool grounded = false;
	bool winning = false;
	bool jump = false;

	void Awake ()
	{
		groundCheck = transform.Find("groundCheck");
		winningCheck = transform.Find("winningCheck");
	}

	void Update ()
	{
		winningCheck.transform.position = new Vector3 (transform.position.x, transform.position.y - 20f, transform.position.z);
		groundCheck.transform.position = new Vector3 (transform.position.x, transform.position.y - 1.27f, transform.position.z);
		//Automatically move the player forward
		//rigidbody2D.AddForce (Vector2.right * moveForce);
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));
		winning = Physics2D.Linecast(transform.position, winningCheck.position, 1 << LayerMask.NameToLayer("Enemy"));

		// If the jump button is pressed and the player is grounded then the player should jump.
		if (gameObject != null) {
			if (Input.GetButtonDown ("Jump") && grounded)
				jump = true;


			if (winning && winningCount == 0)
			{
					previousScore = currentScore;
					currentScore = previousScore + winningScore;
					Score.text = "Score: " + currentScore;
					winningCount = 1;
			}

			if (grounded)
			{
				winningCount = 0;
			}
		}
	}

	void FixedUpdate()
	{
		float move = Input.GetAxis ("Horizontal");

		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if (gameObject != null)
		{
			if (move != 0)
			//if (move * rigidbody2D.velocity.x < maxSpeed)
			// ... add a force to the player.
				GetComponent<Rigidbody2D>().AddForce (new Vector2(Mathf.Sign(move) * moveForce,0f));

			if (move == 0)
				GetComponent<Rigidbody2D>().velocity = new Vector2 (0f, GetComponent<Rigidbody2D>().velocity.y);

			// If the player's horizontal velocity is greater than the maxSpeed...
			//if (Mathf.Abs (rigidbody2D.velocity.x) > maxSpeed)
				// ... set the player's velocity to the maxSpeed in the x axis.
			//rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);

			if (jump)
			{
				// Add a vertical force to the player.
				GetComponent<Rigidbody2D>().AddForce (new Vector2 (0f, jumpForce));
								
				// Make sure the player can't jump again until the jump conditions from Update are satisfied.
				jump = false;
			}
		}
	}
}