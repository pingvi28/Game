using UnityEngine;
using System.Collections;

// "слежка" за игроком (без поворота)
public class FollowCamera : MonoBehaviour
{
    public GameObject player; // тут объект игрока
    public Transform target;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(5, 5, -5);

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(target);
    }
}