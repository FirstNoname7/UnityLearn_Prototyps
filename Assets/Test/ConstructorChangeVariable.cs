using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ����� ����������� ������ ���-�� � ������ ������� (����� ��� �������� ������ �� ������ ������)
public class ConstructorChangeVariable : MonoBehaviour
{
    private int speedForChanged = 200;
    void Start()
    {
        //������� ���������� ���������� Speed �� ������� �������. ��� �� ����� ���� �� �� ������� ��������� � ����� ������ GetSet � �������� ���������� Speed ����� �������: testConstructor.Speed = speedForChanged;
        GetSet testConstructor = new GetSet()
        {
            Speed = speedForChanged
        };
        Debug.Log(testConstructor.Speed);
    }

}
