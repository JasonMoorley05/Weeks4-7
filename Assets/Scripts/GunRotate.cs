using UnityEngine;
using UnityEngine.InputSystem;

public class GunRotate : MonoBehaviour
{
    public Camera gameCamera;
    Vector3 pivotToMouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0;

        pivotToMouse = worldMousePosition - transform.position;
        transform.right = pivotToMouse;
    }
}
