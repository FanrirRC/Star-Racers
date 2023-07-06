using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public static int movespeed = 4; //Affects Acceleration speed
    public float rotationSpeed = 40f; //Affects rotation speed

    void Update()
    {
        //continuous acceleration
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);

        //Rotating movement
        if (Input.GetKey("w"))
        {
            transform.Rotate(rotationSpeed * Time.deltaTime * 4, 0f, 0f);
            Debug.Log("Up arrow key is held down");
        }

        if (Input.GetKey("s"))
        {
            transform.Rotate(-rotationSpeed * Time.deltaTime * 4, 0f, 0f);
            Debug.Log("Down arrow key is held down");
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0f, -rotationSpeed * Time.deltaTime * 8, 0f);
            Debug.Log("Left arrow key is held down");
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime * 8, 0f);
            Debug.Log("Right arrow key is held down");
        }
    }
}
