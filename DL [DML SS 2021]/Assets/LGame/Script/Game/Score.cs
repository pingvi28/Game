using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;

	// Update is called once per frame
	void Update () {
		float pos = player.position.x + 3;
		scoreText.text = pos.ToString("0");
	}
}
