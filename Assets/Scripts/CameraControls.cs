using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    private Vector3 targetPosition;

    // Nitro On
    void Update()
    {
        if (Input.GetKey("space") && Input.GetKey("left shift"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f);
        }
    }
}
