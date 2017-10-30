using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody2D MyRigidbody2D;
	public float ForceStrength;
	public float JumpStrength;
	public GameObject Tear;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") > 0)
		{
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
		if (Input.GetKey(KeyCode.Space))
			Shoot () ;
	}

	void Shoot() {
		Instantiate(Tear, MyRigidbody2D.transform.position, MyRigidbody2D.transform.rotation );
	}
}
