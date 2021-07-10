using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance;
	public Animator animFade;
	public Animator animPause;
	public Animator animHome;

	public float restartDelay = 1f;
	private bool gameHasEnded = false;

	private void Awake()
	{
		animFade.SetTrigger("fade");
		instance = this;
	}

	private void Update() 
	{
		if (Score.score == 15) 
		{
			SceneManager.LoadScene("Intermediate");
		}
	}

	public void AnimEndGame()
	{
		animFade.SetTrigger("EndGame");
		animPause.SetTrigger("Pause");
		animHome.SetTrigger("Home");
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
	}

	private void Restart ()
	{
		animFade.SetTrigger("fade");
		Score.score = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void goToHome()
	{
		SceneManager.LoadScene("MainScene");
	}
}
