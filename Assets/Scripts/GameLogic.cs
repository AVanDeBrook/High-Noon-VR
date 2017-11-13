using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {
	//Singleton
	public static GameLogic instance;
	public Transform[] spawnPoints;
	public GameObject target;
	public GameObject gameOverScreen;

	public Light dirLight;

	//Called when a new level is loaded.
	public delegate void LevelLoaded();
    public event LevelLoaded OnLevelLoaded;

	 float timerMax = 60;
	public float timer = 0;
	public bool GameOver{
		get{return timer <= 0;}
	}



	private int _currentScore = 0;
	public int CurrentScore{
		get{return _currentScore; }
		set{
			_currentScore = value;
			ScoreHUD.instance.UpdateMe();
		}
	}


	void Start () {
		timer = timerMax;
		instance = this;
		SpawnTarget(0);
	}

	void Update()
	{
		timer = Mathf.Clamp(timer - Time.deltaTime,0,timerMax);
		if(timer <= 0)
		{
			//Game Over
			CallGameOver();
		}
	}
	
	public void TargetSmashed()
	{
		CurrentScore++;
		SpawnTarget();
		SpawnTarget();
	}

	void SpawnTarget()
	{
		Instantiate(target, spawnPoints[Random.Range(0,spawnPoints.Length)].position, Quaternion.identity);
	}

	void SpawnTarget(int index)
	{
		Instantiate(target, spawnPoints[index].position, Quaternion.identity);
	}

	void CallGameOver()
	{
		foreach(GameObject g in GameObject.FindGameObjectsWithTag("Target"))
		{
			g.GetComponent<Target>().frozen = true;
			g.GetComponent<Rigidbody>().isKinematic = true;
		}

		dirLight.color = Color.red;
		gameOverScreen.SetActive(true);
	}

	public void Restart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

}
