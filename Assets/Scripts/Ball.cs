using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public int ballNumber;
    public Color ballColor;
    public TextMeshPro ballText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().material.color = ballColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetupBall(int number, Color color)
    {
        ballNumber = number;
        ballColor = color;
        GetComponent<Renderer>().material.color = ballColor;

        ballText.text = number.ToString();
    }
}
