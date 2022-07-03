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
        //rb.AddTorque(5f, ForceMode2D.Force);
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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player1")
        {
            rb.AddTorque(-2.5f, ForceMode2D.Force);
        }
        else if (col.gameObject.tag == "Player2")
        {
            rb.AddTorque(2.5f, ForceMode2D.Force);
        }
    }
}
