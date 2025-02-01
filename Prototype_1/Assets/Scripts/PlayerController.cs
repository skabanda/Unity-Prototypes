using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // private variables
    private float speed = 10.0f;
    private float turnSpeed = 100f; 
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //Assign input for left/right
      horizontalInput=Input.GetAxis("Horizontal");

      //Assign input for forward/back
      forwardInput=Input.GetAxis("Vertical");
      
      // We'll move the vehicle forward
        transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
      
      // turn the vehicle  
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
