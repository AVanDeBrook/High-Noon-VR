using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour {

	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.CompareTag("Bullet"))
		{
			GameLogic.instance.Restart();
		}
	}
}
