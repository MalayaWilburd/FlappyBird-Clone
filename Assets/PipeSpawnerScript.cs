using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 8; //seconds between spawns
    private float timer = 0; //can be private because we're not changing it anywhere else
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; //count's up by 1 every frame and works the same for every frame rate
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }  
    
    void spawnPipe() //make function so you don't have to update the code in multiple places if needing to change
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);   //Vector is used when you're specifying your own numbers for a vector.
    }
}
