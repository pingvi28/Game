using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error : MonoBehaviour 
{
	private void OnTriggerEnter(Collider other)
	{
		PlayerController playerController = other.GetComponent<PlayerController>();
		if(playerController != null)
		{
			LevelController.instance.GameOver();
			playerController.transform.position = new Vector3(playerController.transform.position.x, transform.position.y + 0.5f, playerController.transform.position.z);
			playerController.GameOver();
		}
	}
}
