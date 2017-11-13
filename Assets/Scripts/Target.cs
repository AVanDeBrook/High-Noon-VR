using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
	public float gravity = 9.8f;
	Rigidbody rb;
	public bool dead = false, frozen = false;
	public int maxY = 30, maxX = 40;

	void Awake () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(new Vector3(400 * Random.Range(-1,1), 500));
	}
	
	
	void FixedUpdate () {
		//rb.AddForce(Vector3.down * gravity);
		transform.LookAt(Camera.main.transform);
	}

	//Detect target collision
	void OnCollisionEnter(Collision c)
	{
		if(frozen) return;
		if(c.collider.CompareTag("Bullet"))
		{
			dead = true;
			Destroy(gameObject);
			GameLogic.instance.TargetSmashed();
		}
	}
}
