using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyballController : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public MaxVelocity = 5;
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
        Vector2 velocity = rb.velocity;
        Debug.Log(velocity);
        
    }
}
