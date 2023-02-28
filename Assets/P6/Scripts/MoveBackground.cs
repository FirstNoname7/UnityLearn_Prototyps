using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    //этот скрипт показывает прокрутку влево (препятствий и фона) для создания эффекта движения
    private float speed = 10.0f; //скорость перемещения
    //private PlayerController_6 playerControllerScript; 

    void Start()
    {
        EventManager.GameOver += NotMove;
    }

    void Update()
    {
        MoveBG();
    }

    void MoveBG()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    void NotMove()
    {
        speed = 0;
        EventManager.GameOver -= NotMove;
    }

}
