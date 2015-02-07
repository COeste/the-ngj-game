using UnityEngine;
using System.Collections;

public class TopDownMovement : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	
	
	private Vector3 moveDirection = Vector3.zero;
	private Vector3 objectRotation = Vector3.zero;
	
	void Update() {
		//if (controller.isGrounded) {
		Debug.Log (speed);
		moveDirection = new Vector3(Input.GetAxis ("Vertical"), 0, 0);
		//moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;

		objectRotation = new Vector3(0,0,transform.rotation.y + Input.GetAxis("Horizontal"));

		transform.Translate(moveDirection * Time.deltaTime);
		transform.Rotate(objectRotation);
	}
}
