using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHUD : MonoBehaviour {
	public TextMeshProUGUI text;
	public static ScoreHUD instance;
	
	public void Awake()
	{
		instance = this;
		text = GetComponent<TextMeshProUGUI>();
	}

	public void UpdateMe () {
		text.text = GameLogic.instance.CurrentScore.ToString();
	}
}
