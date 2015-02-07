using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 10.0F;
	public float gravity = 5.0F;
    public bool isGrounded = false;
    private bool up = false;
	private float jumptime = 0F;

	private Vector3 moveDirection = Vector3.zero;


	void Update() {
		Debug.Log(jumptime);
		Debug.Log ("move: "+moveDirection.y);
		if (!up)
			Debug.Log ("up is false");

        if (moveDirection.y > 0.5F) {
			isGrounded = false;
			up = true;
		} else if (moveDirection.y < -0.5F) {
			up = false;
			isGrounded = false;
		} else if (up == false) {
			isGrounded = true;
		}
		if (jumptime < 1F) {
			moveDirection.y = jumpSpeed;
			jumptime += Time.deltaTime;
		}
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		//if (isGrounded) {

            if (Input.GetButton("Jump")) {
                moveDirection.y = jumpSpeed;
				jumptime = Time.deltaTime;
				Debug.Log("Hopper");
            }
		//}
		if (!(jumptime < 1F)) {
			moveDirection.y -= gravity * Time.deltaTime;
		}
		transform.Translate(moveDirection * Time.deltaTime);
	}
}
