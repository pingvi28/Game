using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementWithClick : MonoBehaviour
{
    public LayerMask whatBeClickedOn;
    public VectorValue cam, pos;

    private NavMeshAgent myAgent;
    private Animator pl_animator;
    private Vector2 g1, g2, offset;
    private Vector2 worldPosition;
    private bool isMoved;

    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        pl_animator = GetComponent<Animator>();
        offset = new Vector2(cam.initialValue.x - pos.initialValue.x, cam.initialValue.y - pos.initialValue.y) ;
    }

    private void Update()
    {
        g1 = new Vector2(cam.initialValue.x, cam.initialValue.y);
        cam.SetNewPosition(transform.position);
        pos.SetNewPosition(transform.position);

        print("g1 " + g1.x + " " + g1.y);

        if (Input.GetMouseButtonDown(0))
        {
            isMoved = true;
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            pl_animator.SetBool("Move", true);

            if (Physics.Raycast(myRay, out hitInfo, 100, whatBeClickedOn))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }

        g2 = new Vector2(worldPosition.x - offset.x, worldPosition.y - offset.y);

        print("g2 " + g2.x + " " + g2.y);

        float distance = Vector2.Distance(g1, g2);

        if (distance < 5f && isMoved) 
        {
            pl_animator.SetBool("Move", false);
            isMoved = false;
        }

        print("dis " + distance);
    }
}
