using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float gravity = 9.8f;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		rb.AddForce(Vector3.down * gravity);
	}

	void OnCollisionEnter(Collision c)
	{
		Destroy(gameObject);
	}
}
