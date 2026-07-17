using System;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour
{
    public GameObject ballPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject ball1 = Instantiate(ballPrefab, new Vector3(-5, 0, 0), Quaternion.identity);

        Ball ballScript = ball1.GetComponent<Ball>();
        ballScript.SetupBall(7, new Color(0.8962264f, 0.4345364f, 0.06341223f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
