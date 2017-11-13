using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScoreBoard : MonoBehaviour {

	void OnEnable()
	{
		gameObject.GetComponent<TextMeshPro>().text = "Score: " + GameLogic.instance.CurrentScore.ToString();
	}
}
