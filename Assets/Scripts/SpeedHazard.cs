using UnityEngine;

public class SpeedHazard : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer playerExplorer;
    bool isCurrentlyOnTrap = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRenderer.bounds.Contains(transform.position) && !isCurrentlyOnTrap)
        {
            playerExplorer.speed /= 2f;
            isCurrentlyOnTrap = true;
        }

        if (!playerRenderer.bounds.Contains(transform.position) && isCurrentlyOnTrap)
        {
            isCurrentlyOnTrap = false;
            playerExplorer.speed *= 2f;
        }
    }
}
