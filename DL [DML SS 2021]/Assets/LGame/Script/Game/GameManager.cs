using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance;

	//public GameObject gameOverPanels;
	//public bool gameOver;
	public float restartDelay = 1f;

	private bool gameHasEnded = false;

	private void Awake()
	{
		instance = this;
	}

	private void Update() 
	{
		if (Score.score == 15) 
		{
			SceneManager.LoadScene("OpeningScene");
		}
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			Score.score = 0;
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", restartDelay);
		}

		/*
		if (gameOverPanels != null)
			gameOverPanels.SetActive(true);

		gameOver = true;
		*/
	}

	private void Restart ()
	{
		Score.score = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
