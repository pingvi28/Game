using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScriptsMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextLevel()
    {
        Application.LoadLevel(1);
    }
    public void LeaderboardOpen()
    {
    }
    public void GoToMenuLevel()
    {
        Application.LoadLevel(0);
    }
    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}