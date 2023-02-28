using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 30.0f; //�������� ����������� �������, � �������� ���������� ���� ������
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed); 

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //����� ����� ���������� �� ����, � �� �� ����
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }

}
