using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveDown : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Rigidbody objectRb;

    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        objectRb.AddForce(Vector3.back * speed);

        if (transform.position.z < -25)
        {
            Destroy(gameObject); 
        }
    }


}
