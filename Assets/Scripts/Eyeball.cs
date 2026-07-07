using UnityEngine;

public class Eyeball : MonoBehaviour
{
    float angle = 0;
    public float speed;
    float width = 45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        angle += speed * Time.deltaTime;

        if (angle > width || angle < -width)
        {
            speed *= -1;
        }

        transform.eulerAngles = new Vector3(0f, 0f, angle);
    }
}
