using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10.4f;

    private bool JumpCooldownOn = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") && !JumpCooldownOn)
        {
            rb.AddForce(transform.up * 2);
            JumpCooldownOn = true;
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
       
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
