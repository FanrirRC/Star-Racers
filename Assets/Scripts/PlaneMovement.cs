using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneMovement : MonoBehaviour
{
    private float movespeed = 5; 
    private float rotationSpeed = 10f; 
    private float nitroDepletionRate = 0.25f;

    public float maxNitroValue = 100;
    public float nitroValue = 100;
    public Slider nitroSlider;

    void Update()
    {
        //Acceleration, Reverse, and Nitro
        if (Input.GetKey("space"))
        {
            transform.Translate(- Vector3.forward * movespeed * Time.deltaTime * 1.5f);
        }
        else
        {
            if (nitroValue > 0 && (Input.GetKey("left shift") || Input.GetKey("right shift")))
            {
                transform.Translate((Vector3.forward * movespeed * Time.deltaTime) * 6f);
                nitroValue -= nitroDepletionRate;
                nitroValue = Mathf.Max(nitroValue, 0);
                UpdateNitroSlider();
            }
            else
            {
                transform.Translate(Vector3.forward * movespeed * Time.deltaTime * 3f);
            }
        }

        //Rotating movement
        if (Input.GetKey("w"))
        {
            transform.Rotate(rotationSpeed * Time.deltaTime * 6.5f, 0f, 0f);
        }

        if (Input.GetKey("s"))
        {
            transform.Rotate(-rotationSpeed * Time.deltaTime * 6.5f, 0f, 0f);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0f, -rotationSpeed * Time.deltaTime * 8, 0f);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime * 8, 0f);
        }

        //Rolling/Tilting movement
        if (Input.GetKey("q"))
        {
            float rollAngle = rotationSpeed * Time.deltaTime;
            transform.Rotate(0f, 0f, rollAngle * 4, Space.Self);
        }

        if (Input.GetKey("e"))
        {
            float rollAngle = -rotationSpeed * Time.deltaTime;
            transform.Rotate(0f, 0f, rollAngle * 4, Space.Self);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        UpdateNitroSlider();
    }

    void UpdateNitroSlider()
    {
        nitroValue = Mathf.Min(nitroValue, maxNitroValue);
        float sliderValue = (float)nitroValue / maxNitroValue;
        nitroSlider.value = sliderValue;
    }
}
