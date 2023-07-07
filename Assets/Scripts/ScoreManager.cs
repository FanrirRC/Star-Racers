using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void OnEnable() => Collectables.Oncollected += OnCollectibleCollected;
    void OnDisable() => Collectables.Oncollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        text.text = (++count).ToString();
    }

}
