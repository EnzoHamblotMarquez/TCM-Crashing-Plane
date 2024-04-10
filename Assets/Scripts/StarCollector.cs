using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollector : MonoBehaviour
{
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Star"))
        {
            score++;
            Debug.Log($"Stars collected: {score}");

            DestroyStar destroyStar = FindObjectOfType<DestroyStar>();
            destroyStar.Destroy();

        }
        
    }
}
