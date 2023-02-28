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
        //    differentInfoCallback(1, " место");
        //}
        differentInfoCallback?.Invoke(1, " место"); //для игры с лидербордом
                                                    //(?.Invoke = проверка на null (т.е. мы будем ссылаться на метод для делегата только если он (метод) != null и присвоим его параметрам значения (1, " место")), это краткий аналог нескольких строк выше)
        differentInfoCallback?.Invoke(50, " монет"); //для сбора чего-либо в игре
        differentInfoCallback?.Invoke(19, " лет"); //для игры с возрастными ограничениями
    }
}
 
public class Delegate : MonoBehaviour //делегат - это ссылка на метод, который будет использоваться в том или ином случае (например, у нас есть кнопка, но
                                      //мы не знаем что с ней делать, поэтому вызываем делегат, который будет потом ссылаться на нужный метод, который будет выполнен при нажатии на кнопку)
{
    //private delegate int Anything(int number);

    private Stats _stats = new Stats(); //ссылаюсь на класс и сразу инициализирую его
    private Button _button;
    private Button _buttonTwo;
    void Start()
    {
        _button = GameObject.FindWithTag("ButtonOne").GetComponent<Button>();
        _buttonTwo = GameObject.FindWithTag("ButtonTwo").GetComponent<Button>();

        ////для магаза:
        //Anything anything = new(Shop); //делегат выполняет логику покупки в магазе
        //anything?.Invoke(50); //проверка на null (т.е. мы будем ссылаться на метод для делегата только если он (метод) != null и присвоим его параметру значение 50), это краткий аналог нескольких строк выше
        //anything += LeaderBoard; //а, забыла! пусть делегат ещё выводит имя победителя в соревнованиях (также можно отписываться от методов, которые может выполнять делегат)
        ////для доски лидеров:
        //anything?.Invoke(1);

        _button.onClick.AddListener(OnClickButton);
        _buttonTwo.onClick.AddListener(OnClickTwoButton);
    }

    void OnClickButton()
    {
        _stats.ReturnDifferentInfo(Info); //благодаря этому будет вызываться всё, что добавлено в метод ReturnDifferentInfo, потому что делегат возвращает всё
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
        Debug.Log("Что-то ещё");
    }
}
