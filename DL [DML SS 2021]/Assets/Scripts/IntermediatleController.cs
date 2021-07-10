using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntermediatleController : MonoBehaviour
{
	public static IntermediatleController instance;
	public Animator animPlay;
	public Animator animHome;

	private void Awake()
	{
		instance = this;
		animPlay.SetTrigger("Play");
		animHome.SetTrigger("Home");
	}

	public void goToHome()
	{
		SceneManager.LoadScene("MainScene");
	}
}

/*
	public void GameOver()
	{
		if (gameOverPanel != null)
			gameOverPanel.SetActive(true);

		gameOver = true;
	}
*/