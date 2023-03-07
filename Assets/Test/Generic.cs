using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//дженерики работают просто как параметры здесь, но важная особеность: это параметры с неопределенным типом, т.е. ты туда можешь положить вообще что угодно
public class Generic : MonoBehaviour
{
    void Start()
    {
        MethodGeneric ("kuler", "kek"); //кладу переменные типа string
        MethodGeneric(1, "kill"); //тут решила заменить и положить 1 int переменную, а вторую типа string
    }


    void MethodGeneric <P1, P2>(P1 parameterOne, P2 parameterTwo) //сначала надо объявить в треугольных скобках, какие параметры вообще будут находиться в этом методе,
                                                                  //потом, как обычно, в круглых скобках, вместо типов данных поставить эти переменные и их названия
    {
        Debug.Log(parameterOne);
        Debug.Log(parameterTwo);
    }
}
