using UnityEngine;

public class PlayerCamera : MonoBehaviour

{
public GameObject player;
private Vector3 offset = new Vector3(0, 7, -4);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset camera position - place behind player
        transform.position = player.transform.position + offset; 
    }
}
