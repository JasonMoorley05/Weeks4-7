using UnityEngine;

public class SpawnBoulderScript : MonoBehaviour
{
    public GameObject Boulder;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void SpottedByEye()
    {
        Vector3 spawnPosition = new Vector3(-13, Random.Range(-4, 4), 0);
        Instantiate(Boulder, spawnPosition, Quaternion.identity);
    }

}
