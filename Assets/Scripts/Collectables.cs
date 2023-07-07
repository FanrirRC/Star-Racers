using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("You got a Point!");
            Destroy(this.gameObject);
        }
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
