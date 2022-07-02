using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyballController : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public int MaxVelocity = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (rb.velocity.magnitude > MaxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxVelocity);
        }
            
    }
}
