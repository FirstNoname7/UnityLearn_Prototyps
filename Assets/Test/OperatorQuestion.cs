using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorQuestion : MonoBehaviour
{
    //���� ������� ����� ���� ������ ��������, ��� � ���� ���������� �������� �������� NULL
    private GameObject? canBeNull;
    void Start()
    {
        Debug.Log(canBeNull);
    }
}
