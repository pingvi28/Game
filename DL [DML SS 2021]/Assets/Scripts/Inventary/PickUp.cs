using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject slotBut;
    public int id;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(slotBut, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
