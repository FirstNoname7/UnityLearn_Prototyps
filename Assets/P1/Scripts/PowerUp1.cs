using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlayerController player))
        {
            other.gameObject.transform.localScale = new Vector3(2, 2, 2);
            Debug.Log("Подобрана супер сила");
        }
        
    }
}
