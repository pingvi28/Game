using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDontScript : MonoBehaviour
{
    public FlagTrigger flag;

    void Start()
    {
        gameObject.GetComponent<Scenes_withTrigger>().enabled = flag.status;
    }
}
