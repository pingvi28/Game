using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	//public Transform player;
	public Text scoreText;
	public static int score;

	void Update () {
		//float pos = player.position.x + 3;
		//scoreText.text = pos.ToString("0");

		scoreText.text = score.ToString("0");
	}
}

