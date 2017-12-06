using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1controller : MonoBehaviour {

	public float moveSpeed;
	private RigidBody2D rb2d;


	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<RigidBody2D> ();
		moveSpeed=2f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, 0f);
		transform.Translate (0f,0f , moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);

		float h = Input.GetAxis ("Horizontal");
		rb2d.AddForce (Vector2.right * moveSpeed * h);
	}
}
