using UnityEngine;
using System.Collections;

public class PlayerControllerInput : MonoBehaviour {

	const float sneakSpeed = 0.75f;
	const float sprintSpeed = 1.25f;

	bool isCrouch = false;
	bool isSprint = false;

	float modSpeed = 1.0f;

    float horiMovement = 0.0f;
    float vertMovement = 0.0f;

	Quaternion playerRotation;

    Vector3 movement;

    void Update()
    {
		// Get player movement input
		if (Input.GetButton ("Crouch")) {
			isCrouch = true;
			modSpeed = sneakSpeed;
		} else if (Input.GetButton ("Sprint")) {
			isSprint = true;
			modSpeed = sprintSpeed;
		} else {
			isSprint = false;
			isCrouch = false;
			modSpeed = 1.0f;
		}

		horiMovement = Input.GetAxis ("Horizontal") * modSpeed;
		vertMovement = Input.GetAxis ("Vertical") * modSpeed;

		// Get player rotation input


    }
    
    void FixedUpdate()
    {
		MoveRotatePlayer ();
    }


	void MoveRotatePlayer()
	{
		
		transform.Translate (horiMovement, 
			vertMovement, 0.0f);

		transform.rotation = playerRotation;

		// Implement animations for combinations of 
		// sneaking and sprinting

	}
}
