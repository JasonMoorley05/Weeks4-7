using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public GameObject existingRunner;
    public Vector3 spawnPosition;
    public float spawnSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void onSpawnPress()
    {

        ////Spawn a runner!
        //Instantiate(runnerPrefab);

        ////Spawn a runner that is a child of this object
        //Instantiate(runnerPrefab, transform);

        //Spawn a runner at a specific position
        GameObject spawnedObject = Instantiate(runnerPrefab, transform.position, Quaternion.identity);

        SpriteRenderer spawnedSpriteRenderer = spawnedObject.GetComponent<SpriteRenderer>();
        if (spawnedSpriteRenderer != null)
        {
            spawnedSpriteRenderer.color = Color.red;
        }



        Runner spawnedRunner = spawnedObject.GetComponent<Runner>();
        if (spawnedRunner != null)
        {
            spawnedRunner.speed = spawnSpeed;
        }

        Destroy(spawnedObject, 3f);

     
    }
}
