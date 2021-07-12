using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPound : MonoBehaviour
{
    public SceneChangeNumder scCh;
    private int count;
    public GameObject pound;
    public GameObject rob;
    public GameObject rob2;

    void Start()
    {
        count = scCh.sceneChangeCount;
        if (count ==  5)
        {
            rob.SetActive(false);
            rob2.SetActive(false);
            pound.SetActive(true);
        }
    }
}
