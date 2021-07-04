using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scences01 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //score
            LevelController.instance.SetScore();
            Debug.Log("sasa");
            NextLevel();
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
