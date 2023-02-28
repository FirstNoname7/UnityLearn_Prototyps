using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    //���� ������ ���������� ��������� ����� (����������� � ����) ��� �������� ������� ��������
    private float speed = 10.0f; //�������� �����������
    //private PlayerController_6 playerControllerScript; 

    void Start()
    {
        EventManager.GameOver += NotMove;
    }

    void Update()
    {
        MoveBG();
    }

    void MoveBG()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    void NotMove()
    {
        speed = 0;
        EventManager.GameOver -= NotMove;
    }

}
