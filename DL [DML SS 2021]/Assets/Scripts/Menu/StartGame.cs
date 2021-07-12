using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public VectorValue pos;
    public FlagTrigger flag;
    public TextNumber num;
    public SceneChangeNumder scCh;

    public void Start() 
    {
        num.SetNewCount();
        scCh.SetNewCount();
        pos.SetNewPosition(new Vector3(41, 3, 56));
        flag.setTrue();
    }

    public void startGame()
    {
        SceneManager.LoadScene("Intermediate");
    }
}
