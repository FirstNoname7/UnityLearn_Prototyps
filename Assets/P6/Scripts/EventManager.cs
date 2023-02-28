using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static event Action GameOver;

    public static void OnGameOver()
    {
        GameOver?.Invoke();
    }

    public static event Action GameAction;

    public static void OnGameAction()
    {
        GameAction?.Invoke();
    }

}
