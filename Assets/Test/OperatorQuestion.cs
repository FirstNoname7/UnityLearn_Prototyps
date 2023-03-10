using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorQuestion : MonoBehaviour
{
    //знак вопроса после типа данных означает, что в этой переменной возможно значение NULL
    private GameObject? canBeNull;
    void Start()
    {
        Debug.Log(canBeNull);
    }
}
