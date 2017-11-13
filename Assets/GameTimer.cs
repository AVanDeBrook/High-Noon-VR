using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameTimer : MonoBehaviour {
	TextMeshProUGUI text;
	
	void Start()
	{
		text = GetComponent<TextMeshProUGUI>();
	}

	// Update is called once per frame
	void Update () {
		if(GameLogic.instance.timer > 10)
		{
			text.text = ((int)GameLogic.instance.timer).ToString();
		}
		else
		{
			text.text = (GameLogic.instance.timer).ToString("F2");
		}

	}
}
