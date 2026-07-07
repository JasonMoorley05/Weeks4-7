using UnityEngine;

public class Boulder : MonoBehaviour
{
    float speed = 5f;
    Vector3 pos = Vector3.zero;
    float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        timer += Time.deltaTime;
        if (timer > 5)
        {
            Destroy(gameObject);
        }
    }
}
