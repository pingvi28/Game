using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsMovement : MonoBehaviour
{
    public float speedMove = 5.0f; //�������� �����
    public float jumpPower = 8.0f; // ���� ������
    public float distance = 1f;   // �������� �� ��, � ����� ����� �� �������� 

    private float gravityForce, dirZ; // ���������� �����
    private bool NeedToGo = true;
    private Vector3 moveVector; // ����������� ��������

    public CharacterController pl_controller;
    public Rigidbody rb;

    private void Start()
    {
        pl_controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
       PlayerMove();
       GamingGravity();
    }

    private void FixedUpdate() {
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().AnimEndGame();
        }

        if (rb.position.y < -4f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void Move()   // �����: ����� �� ���������
    {
        if (!NeedToGo)   // ���� �� �� ������������ � ������ ������
        {
            NeedToGo = true;   
        }
    }

    private void PlayerMove()
    {
        Move();

        if (NeedToGo)
        {
            if (Input.GetMouseButtonDown(0))   // ��������� �����
            {
                dirZ = speedMove;
            }
            else if (Input.GetMouseButtonDown(1))   // ��������� ������
            {
                dirZ = - speedMove;
            }

            NeedToGo = false;
        }

        moveVector.x =  distance;
        moveVector.z = dirZ * 0.5f;
        moveVector.y = gravityForce; //������ ���������� (������)
        pl_controller.Move(moveVector * Time.deltaTime);
    }

    // ����� �����
    private void GamingGravity()
    {
        if (!pl_controller.isGrounded) gravityForce -= 20f * Time.deltaTime;
        else gravityForce = -1f;

        // ������ ����� ���������
        if (Input.mouseScrollDelta.y > 0.0f && pl_controller.isGrounded)
        {
            gravityForce = jumpPower;
        }
    }
}