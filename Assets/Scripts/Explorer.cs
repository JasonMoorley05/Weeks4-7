using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Explorer : MonoBehaviour
{
    public float health;
    public float speed;
    public int treasure;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToMove = Vector3.zero;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            directionToMove.x -= 1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            directionToMove.x += 1f;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            directionToMove.y += 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            directionToMove.y -= 1f;
        }

        directionToMove.Normalize();

        transform.position += directionToMove * speed * Time.deltaTime;
    }

    public void TakeDamage()
    {
        health -= 10;
    }

    public void SlowDown()
    {
        speed /= 2f;
    }

    public void SpeedUp()
    {
        speed *= 2f;
    }

    public void SpottedByEye()
    {
        Debug.Log("You've been spotted!");
    }
}
