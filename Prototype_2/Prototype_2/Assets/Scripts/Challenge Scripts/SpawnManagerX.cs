using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float minSpawnInterval = 1.0f;
    private float maxSpawnInterval = 4.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
       StartCoroutine (SpawnBallRoutine());

    }

   IEnumerator SpawnBallRoutine()
   {

    while (true) //infiniate loop
    {

        float randomTime = Random.Range(minSpawnInterval, maxSpawnInterval);
        yield return new WaitForSeconds (randomTime); // Waiting for random interval
        SpawnRandomBall();

    }


   }


   
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    
        //spawn at random time
        ;
    
    }

    

}
