using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    public FlagTrigger flag;

    void Start()
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = flag.status;
    }
}
