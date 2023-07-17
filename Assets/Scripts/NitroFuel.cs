using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroFuel : MonoBehaviour
{
    public int nitroIncreaseAmount = 25;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlaneMovement>().nitroValue += nitroIncreaseAmount;
        Debug.Log("You collected a Nitro Fuel!");
        Destroy(gameObject);
    }
}
