using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] animalPreFabs;
    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 20.0f; 
    private float startDelay = 2.0f;
    private float spawnInternal = 1.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Random spawn at timed intervals
      InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInternal);

    }

    // Update is called once per frame
    void Update()
    {
        
   
    }

    void SpawnRandomAnimal ()
    {
            // Randomly generate Game Objects at random intervals
           
            Vector3 spawnPos = new Vector3(Random.Range (-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            int animalIndex = Random.Range(0, animalPreFabs.Length); 
            

            Instantiate(animalPreFabs[animalIndex], spawnPos, animalPreFabs[animalIndex].transform.rotation);



    }
}
