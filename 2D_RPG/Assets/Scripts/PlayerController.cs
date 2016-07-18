using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	Rigidbody myRB;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody> ();
	}

	void Update () {
			Move ();
		if (Input.GetKeyDown ("space"))
		{
			Jump ();
		}
	}

	void Move () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (horizontal, vertical, 0.0f);
		myRB.AddForce (movement * moveSpeed);
		Debug.Log ("moving...");
	}

	void Jump () {
		Vector3 jump = new Vector3 (0.0f, 1, 0.0f);
		myRB.AddForce (jump * jumpHeight);
	}
}
