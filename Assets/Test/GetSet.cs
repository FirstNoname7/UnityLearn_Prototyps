using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����� ���������, ��� ��� ��������, ������ � ������ ������ �� ����� � ����� ����� � ������ �����
public class GetSet : MonoBehaviour
{
    private int speed = 0; //������ ����������
    public int Speed 
    {
        get => speed; //�� ��� ����� ���������� �������� ����������
        set
        {
            speed = value; //����� ����������� �������� ���� ���������� (������ Speed)
            if (speed > 10) //���� ����� ��������� ���������, ��� ���������� ����� 10, ��:
            {
                Speedrun(); //��������� ����� �������
            }
            else //� �������� ������
            {
                Turtle(); //���� � ������ �����
            }
        }
    }
    void Start()
    {
        Speed = 105; //��� ������
    }
    void Speedrun()
    {
        Debug.Log("��� ��� ��������!");
    }
    void Turtle()
    {
        Debug.Log("��������� ��� ��������");
    }
}
