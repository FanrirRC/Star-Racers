using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManger : MonoBehaviour
{
    public int screenWidth = 1920;
    public int screenHeight = 1080;

    void Start()
    {
        SetResolution(screenWidth, screenHeight);
    }

    public void SetResolution(int width, int height)
    {
        Screen.SetResolution(width, height, fullscreen: true);
    }
}
