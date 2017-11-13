using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.CompareTag("Bullet"))
		{
			Application.LoadLevel("main");
		}
	}
}
