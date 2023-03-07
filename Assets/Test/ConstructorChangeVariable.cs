using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//как через конструктор менять что-то в другом скрипте (прост как вариация ссылки на другой скрипт)
public class ConstructorChangeVariable : MonoBehaviour
{
    private int speedForChanged = 200;
    void Start()
    {
        //вариант обновления переменной Speed из другого скрипта. Это всё равно если бы ты создала перемнную с типом данных GetSet и поменяла переменную Speed таким образом: testConstructor.Speed = speedForChanged;
        GetSet testConstructor = new GetSet()
        {
            Speed = speedForChanged
        };
        Debug.Log(testConstructor.Speed);
    }

}
