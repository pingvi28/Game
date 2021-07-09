using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class VectorValue : ScriptableObject
{
    public Vector3 initialValue;

    private void Awake() 
    {
        initialValue = new Vector3(50, 4, 48);
    }

    public void SetNewPosition(Vector3 vec)
    {
        initialValue = vec;
    }
}