using System;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour
{
    public GameObject ballPrefab;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject ball7 = Instantiate(ballPrefab, new Vector3(-5, 0, 0), Quaternion.identity);
        Ball ballScript = ball7.GetComponent<Ball>();
        ballScript.SetupBall(7, new Color(0.8962264f, 0.4345364f, 0.06341223f));

        GameObject ball8 = Instantiate(ballPrefab, new Vector3(-4.2f, 0, 0), Quaternion.identity);
        ballScript = ball8.GetComponent<Ball>();
        ballScript.SetupBall(8, new Color(0,0,0));

        GameObject ball1 = Instantiate(ballPrefab, new Vector3(-3.4f, 0, 0), Quaternion.identity);
        ballScript = ball1.GetComponent<Ball>();
        ballScript.SetupBall(1, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball4 = Instantiate(ballPrefab, new Vector3(-3.8f, 0.2f, 0), Quaternion.identity);
        ballScript = ball4.GetComponent<Ball>();
        ballScript.SetupBall(4, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball2 = Instantiate(ballPrefab, new Vector3(-3.8f, -0.2f, 0), Quaternion.identity);
        ballScript = ball2.GetComponent<Ball>();
        ballScript.SetupBall(2, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball3 = Instantiate(ballPrefab, new Vector3(-4.6f, 0.2f, 0), Quaternion.identity);
        ballScript = ball3.GetComponent<Ball>();
        ballScript.SetupBall(3, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball5 = Instantiate(ballPrefab, new Vector3(-4.6f, -0.2f, 0), Quaternion.identity);
        ballScript = ball5.GetComponent<Ball>();
        ballScript.SetupBall(5, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball6 = Instantiate(ballPrefab, new Vector3(-4.6f, 0.6f, 0), Quaternion.identity);
        ballScript = ball6.GetComponent<Ball>();
        ballScript.SetupBall(6, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball9 = Instantiate(ballPrefab, new Vector3(-4.6f, -0.6f, 0), Quaternion.identity);
        ballScript = ball9.GetComponent<Ball>();
        ballScript.SetupBall(9, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball10 = Instantiate(ballPrefab, new Vector3(-4.2f, 0.4f, 0), Quaternion.identity);
        ballScript = ball10.GetComponent<Ball>();
        ballScript.SetupBall(10, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball11 = Instantiate(ballPrefab, new Vector3(-4.2f, -0.4f, 0), Quaternion.identity);
        ballScript = ball11.GetComponent<Ball>();
        ballScript.SetupBall(11, new Color(0.8962264f, 0.8345364f, 0.06341223f));

        GameObject ball12 = Instantiate(ballPrefab, new Vector3(-5, 0.4f, 0), Quaternion.identity);
        ballScript = ball12.GetComponent<Ball>();
        ballScript.SetupBall(12, new Color(0.8962264f, 0.4345364f, 0.06341223f));

        GameObject ball13 = Instantiate(ballPrefab, new Vector3(-5, 0.8f, 0), Quaternion.identity);
        ballScript = ball13.GetComponent<Ball>();
        ballScript.SetupBall(13, new Color(0.8962264f, 0.4345364f, 0.06341223f));

        GameObject ball14 = Instantiate(ballPrefab, new Vector3(-5, -0.4f, 0), Quaternion.identity);
        ballScript = ball14.GetComponent<Ball>();
        ballScript.SetupBall(14, new Color(0.8962264f, 0.4345364f, 0.06341223f));

        GameObject ball15 = Instantiate(ballPrefab, new Vector3(-5, -0.8f, 0), Quaternion.identity);
        ballScript = ball15.GetComponent<Ball>();
        ballScript.SetupBall(15, new Color(0.8962264f, 0.4345364f, 0.06341223f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
