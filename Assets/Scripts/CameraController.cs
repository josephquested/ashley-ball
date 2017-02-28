using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public float cameraHeight;
	// the height of the camera above the playerTransform

	Transform playerTransform;
	// variable for storing the players transform

	void Start ()
	{
		playerTransform = GameObject.FindWithTag("Player").transform;
		// gets a reference to the player by using the FindWithTag method
	}

	void Update ()
	{
		UpdatePosition();
		// will update the camera position every frame
	}

	void UpdatePosition ()
	{
		Vector3 position = new Vector3(
			playerTransform.position.x,
			playerTransform.position.y + cameraHeight,
			playerTransform.position.z - 10
		);
		// declares a variable for the new camera position
		// notice the ugly way you do multi-line Vector3s

		transform.position = position;
		// sets the camera position
	}
}
