using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //���� ������ ���������� ��������� ����� (����������� � ����) ��� �������� ������� ��������
    private float speed = 10f; //�������� �����������
    private PlayerController_6 playerControllerScript;
    private float leftBound = -20.0f; //��������� �����������, ��� ������� �� ��� �� ����� �� �����

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController_6>();
        EventManager.OnGameAction();
    }

    //void OnEnable()
    //{
    //    EventManager.OnGameAction();
    //}

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            Move();
        }

        if (transform.position.x < leftBound)  
        {            
            Destroy(gameObject);
            //EventManager.GameAction -= Move;
        }
        //else
        //{
        //    EventManager.GameAction += Move;
        //}

    }

    //void FixedUpdate()
    //{
    //    EventManager.OnGameAction();
    //    EventManager.GameAction += Move;

    //}

    //void OnDestroy()
    //{
    //    EventManager.GameAction -= Move;
    //}

    //void OnDisable()
    //{
    //    EventManager.GameAction -= Move;
    //}

    void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);        
    }
}
