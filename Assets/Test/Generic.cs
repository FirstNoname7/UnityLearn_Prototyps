using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��������� �������� ������ ��� ��������� �����, �� ������ ����������: ��� ��������� � �������������� �����, �.�. �� ���� ������ �������� ������ ��� ������
public class Generic : MonoBehaviour
{
    void Start()
    {
        MethodGeneric ("kuler", "kek"); //����� ���������� ���� string
        MethodGeneric(1, "kill"); //��� ������ �������� � �������� 1 int ����������, � ������ ���� string
    }


    void MethodGeneric <P1, P2>(P1 parameterOne, P2 parameterTwo) //������� ���� �������� � ����������� �������, ����� ��������� ������ ����� ���������� � ���� ������,
                                                                  //�����, ��� ������, � ������� �������, ������ ����� ������ ��������� ��� ���������� � �� ��������
    {
        Debug.Log(parameterOne);
        Debug.Log(parameterTwo);
    }
}
