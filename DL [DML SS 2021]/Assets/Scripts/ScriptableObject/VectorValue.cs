using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class VectorValue : ScriptableObject
{
    public Vector3 initialValue;
    public int count = 0;

    private void Awake() 
    {
        if (count == 0)
        {
            initialValue = new Vector3(50, 4, 48);
        }
    }

    public void SetNewPosition(Vector3 vec)
    {
        count++;
        initialValue = vec;
    }

    public void SetNewCount()
    {
        count = 0;
    }
}