using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldownTime = 1.5f; // Cooldown time
    private bool canSpawn = true;
    

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine (SpawnCoolDown());
        }
    }

    IEnumerator SpawnCoolDown()
{

canSpawn = false; // Disable spawning
yield return new WaitForSeconds (cooldownTime); // Wait cooldown time
canSpawn = true; // Re-enable spawning

}


}
