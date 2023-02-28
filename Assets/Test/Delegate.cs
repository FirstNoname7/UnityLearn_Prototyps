using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats
{
    public delegate void DifferentInfoCallback(int number, string name);
    public void ReturnDifferentInfo(DifferentInfoCallback differentInfoCallback)
    {
        //if(differentInfoCallback != null)
        //{
        //    differentInfoCallback(1, " �����");
        //}
        differentInfoCallback?.Invoke(1, " �����"); //��� ���� � �����������
                                                    //(?.Invoke = �������� �� null (�.�. �� ����� ��������� �� ����� ��� �������� ������ ���� �� (�����) != null � �������� ��� ���������� �������� (1, " �����")), ��� ������� ������ ���������� ����� ����)
        differentInfoCallback?.Invoke(50, " �����"); //��� ����� ����-���� � ����
        differentInfoCallback?.Invoke(19, " ���"); //��� ���� � ����������� �������������
    }
}
 
public class Delegate : MonoBehaviour //������� - ��� ������ �� �����, ������� ����� �������������� � ��� ��� ���� ������ (��������, � ��� ���� ������, ��
                                      //�� �� ����� ��� � ��� ������, ������� �������� �������, ������� ����� ����� ��������� �� ������ �����, ������� ����� �������� ��� ������� �� ������)
{
    //private delegate int Anything(int number);

    private Stats _stats = new Stats(); //�������� �� ����� � ����� ������������� ���
    private Button _button;
    private Button _buttonTwo;
    void Start()
    {
        _button = GameObject.FindWithTag("ButtonOne").GetComponent<Button>();
        _buttonTwo = GameObject.FindWithTag("ButtonTwo").GetComponent<Button>();

        ////��� ������:
        //Anything anything = new(Shop); //������� ��������� ������ ������� � ������
        //anything?.Invoke(50); //�������� �� null (�.�. �� ����� ��������� �� ����� ��� �������� ������ ���� �� (�����) != null � �������� ��� ��������� �������� 50), ��� ������� ������ ���������� ����� ����
        //anything += LeaderBoard; //�, ������! ����� ������� ��� ������� ��� ���������� � ������������� (����� ����� ������������ �� �������, ������� ����� ��������� �������)
        ////��� ����� �������:
        //anything?.Invoke(1);

        _button.onClick.AddListener(OnClickButton);
        _buttonTwo.onClick.AddListener(OnClickTwoButton);
    }

    void OnClickButton()
    {
        _stats.ReturnDifferentInfo(Info); //��������� ����� ����� ���������� ��, ��� ��������� � ����� ReturnDifferentInfo, ������ ��� ������� ���������� ��
    }

    void OnClickTwoButton()
    {
        //var differentInfo = _stats.DifferentInfoCallback;
        //differentInfo += ExtraInfo;
        _stats.ReturnDifferentInfo(ExtraInfo);
    }

    void Info(int number, string name)
    {
        Debug.Log(number + name);
    }

    void ExtraInfo(int number, string name)
    {
        Debug.Log(number + name);
        Debug.Log("���-�� ���");
    }
}
