using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

    public static event Action Oncollected;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Oncollected?.Invoke();
            Debug.Log("You got a Point!");
            Destroy(gameObject);
        }
    }
}
