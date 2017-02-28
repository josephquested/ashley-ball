using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	// public variable used to assign speed to the players movement

	public float jumpPower;
	// remember: public variables can be set in the Unity Inspector

	Rigidbody rb;
	// the convention is to declare rigidbody references as 'rb'

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		// assigns the rb variable using the GetComponent method
	}

	void Update ()
	{
		MovementInput();
		// updates the player movement every frame

		JumpInput();
		// same for jump input
	}

	void MovementInput ()
	{
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		// declares a variable for movement, based on input axis. "GetAxisRaw" can also be used,
		// for more immediate and tactile movement. GetAxisRaw is binary, as opposed to incremental

		rb.AddForce(movement * speed);
	}

	void JumpInput ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			rb.AddForce(Vector3.up * jumpPower);
			// look at that! Vector3 has several useful in-built properties for you to use
			// Vector3.up, Vector3.right, Vector3.down etc.
		}
	}
}
