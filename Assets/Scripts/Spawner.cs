using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Factory factory;
    public Vector3 spawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (factory != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                factory.GetProduct(spawnPosition);
            }
        }
    }
}
