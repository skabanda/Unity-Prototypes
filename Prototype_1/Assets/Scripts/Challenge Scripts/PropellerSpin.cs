using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make propellers spin
        transform.Rotate(0, 0, 3);
    }
}
