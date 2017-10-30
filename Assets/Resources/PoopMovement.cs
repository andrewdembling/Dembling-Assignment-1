using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopMovement : MonoBehaviour {
	
	public Rigidbody2D MyRigidbody2D;
	public float ForceStrength;
	public float JumpStrength;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") > 0)
		{
			MyRigidbody2D.MoveRotation(30);
			MyRigidbody2D.AddForce(Vector2.up * JumpStrength);
	}
		if (Input.GetAxis("Vertical") < 0)
		{
			MyRigidbody2D.AddForce(Vector2.down * ForceStrength);
		}
		if (Input.GetAxis("Horizontal") < 0)
		{
			MyRigidbody2D.AddForce(Vector2.left * ForceStrength);
		}
		if (Input.GetAxis("Horizontal") > 0)
		{
			MyRigidbody2D.AddForce(Vector2.right * ForceStrength);
		}
	
	}
}
