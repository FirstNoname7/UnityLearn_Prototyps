using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public float speed = 50;
    private float horizontalInput;
    private float verticalInput;
    private float zBound = 12;

    public float HorizontalInput
    {
        get=>horizontalInput;
        set
        {
            horizontalInput = value;
            if (horizontalInput != 0) { MovePlayer(); }
        }
    }
    public float VerticalInput
    {
        get => horizontalInput;
        set
        {
            verticalInput = value;
            if (verticalInput != 0) { MovePlayer(); }
        }
    }

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal1");
        VerticalInput = Input.GetAxis("Vertical2");
    }

    //перемещение персонажа
    void MovePlayer()
    {
        transform.Translate(Vector3.forward * speed * verticalInput*Time.deltaTime);
        transform.Translate(Vector3.right * speed * horizontalInput*Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15, 15), 0, Mathf.Clamp(transform.position.z, -zBound, zBound)); //ограничение движения по X и Z
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.TryGetComponent(out MoveDown moveEnemy)) //если у того, с кем столкнулись, есть скрипт MoveDown
        {
            Debug.Log("Игрок столкнулся с врагом");
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent(out PowerUp1 powerup)) //если у того, с кем столкнулись, есть скрипт MoveDown
        {
            Destroy(other.gameObject);
        }
    }
}
