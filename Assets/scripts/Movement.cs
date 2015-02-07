using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
    public bool isGrounded = true;
    private bool up = false;
	private float jumptime = 0F;


	private Vector3 moveDirection = Vector3.zero;


	void Update() {
		Debug.LogError ("Tester");
		Debug.Log(jumptime);
		if (jumptime < 1F && !isGrounded) {
			moveDirection.y = jumpSpeed;
			jumptime += Time.deltaTime;
		} else
			jumptime = 0F;

        if (moveDirection.y > 0.5F)
        {
            isGrounded = false;
			up = true;
        }
        else if (moveDirection.y < -0.5F)
        {
            up = false;
            isGrounded = false;
        }
        else if(up == false)
            isGrounded = true;
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		if (isGrounded) {

            if (Input.GetButton("Jump")) {
                moveDirection.y = jumpSpeed;
				jumptime += Time.deltaTime;
            }
		}
		moveDirection.y -= gravity * Time.deltaTime;
		transform.Translate(moveDirection * Time.deltaTime);
	}
}
