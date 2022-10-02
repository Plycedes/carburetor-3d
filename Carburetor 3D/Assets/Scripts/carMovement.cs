using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    
    public Rigidbody rb;

    public int velocity = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, velocity * Time.deltaTime);
    }
}
