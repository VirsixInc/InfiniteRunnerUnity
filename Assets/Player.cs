using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float jumpStrength = 100f;
	public bool grounded = false;

	int jumpCounter = 0;
	public int maxJumps = 2;

	void Start () {
	
	}

	void Update () {
		if(Input.GetButtonDown("Jump") && (grounded || jumpCounter > 0)) {
			rigidbody2D.AddForce(Vector2.up * jumpStrength);
			jumpCounter--;
			Vector2 vel = rigidbody2D.velocity;
			vel.y = 0f;
			rigidbody2D.velocity = vel;
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Ground") {
			grounded = true;
			jumpCounter = maxJumps;
		}
	}

	void OnCollisionExit2D(Collision2D col) {
		if(col.gameObject.tag == "Ground") {
			grounded = false;
		}
	}
}
