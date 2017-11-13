using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour {
	public GameObject bulletGO;
	public int bulletSpeed;
	public float maxReload = 0.5f;
	public float reloadTime = 0.5f;
	public bool reloading{
		get{return reloadTime != maxReload;}
	}

	void Update(){
	
		if(reloading)
		{
			reloadTime = Mathf.Clamp(reloadTime + Time.deltaTime,0,maxReload);
		}
		if(Input.GetButtonDown("Tap") && !reloading)
		{
			GameObject bullet = Instantiate(bulletGO,transform.position,transform.rotation) as GameObject;
			bullet.GetComponent<Rigidbody>().AddForce(bulletSpeed * transform.forward);
			reloadTime = 0;
		}
	}
}
