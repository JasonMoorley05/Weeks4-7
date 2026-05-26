using UnityEngine;
using UnityEngine.InputSystem;

public class TankMover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position -= transform.right * Time.deltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += transform.right * Time.deltaTime;
        }


    }
}
