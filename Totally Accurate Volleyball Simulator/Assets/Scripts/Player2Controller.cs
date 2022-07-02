using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 8f;

    private bool JumpCooldownOn = false;
    private bool JumpTimer = false;

    float timeRemaining = 3;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(JumpCooldownOn);
        Vector3 pos = transform.position;

        if (Input.GetKey("up") && !JumpCooldownOn)
        {
            rb.AddForce(transform.up * 5000);
            JumpCooldownOn = true;
            JumpTimer = true;
        }

        if (Input.GetKey("right"))
        {
            pos.x += speed * Time.deltaTime;
        }


        if (Input.GetKey("left"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;



        if (JumpTimer)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                JumpCooldownOn = false;
                JumpTimer = false;
                timeRemaining = 3;
            }
        }
    }
}
