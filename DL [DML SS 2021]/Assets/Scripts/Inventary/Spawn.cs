using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    public VectorValue pos;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector3 playerPos = new Vector3(player.transform.position.x - 10, player.transform.position.y + 5, player.transform.position.z - 40);
        //Vector3 playerPos = new Vector3(40, 4, 27);
        //playerPos.x = playerPos.x - 3;
        //playerPos.z = playerPos.z - 3;
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
