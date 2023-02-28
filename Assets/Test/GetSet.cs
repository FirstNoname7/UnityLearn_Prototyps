using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//чтобы проверить, как это работает, положи в пустой объект на сцене и мен€й число в методе старт
public class GetSet : MonoBehaviour
{
    private int speed = 0; //вводим переменную
    public int Speed 
    {
        get => speed; //на гет берем актуальное значение переменной
        set
        {
            speed = value; //можно настраивать значение этой переменной (именно Speed)
            if (speed > 10) //если после настройки оказалось, что переменна€ более 10, то:
            {
                Speedrun(); //открываем метод спидран
            }
            else //в обратном случае
            {
                Turtle(); //идем в другой метод
            }
        }
    }
    void Start()
    {
        Speed = 105; //дл€ дебага
    }
    void Speedrun()
    {
        Debug.Log("¬от это скорость!");
    }
    void Turtle()
    {
        Debug.Log("ѕлетешьс€ как черепаха");
    }
}
