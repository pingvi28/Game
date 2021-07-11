using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPound : MonoBehaviour
{
    public SceneChangeNumder scCh;
    private int count;
    public GameObject pound;

    void Start()
    {
        count = scCh.sceneChangeCount;
        if (count ==  5)
        {
            pound.SetActive(true);
        }
    }
}
