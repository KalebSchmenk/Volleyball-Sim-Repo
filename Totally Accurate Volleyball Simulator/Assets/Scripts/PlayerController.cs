using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0.01f;

    private bool JumpCooldownOn = false;
    private bool JumpTimer = false;

    float timeRemaining = 4;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(JumpCooldownOn);
        Vector3 pos = transform.position;

        if (Input.GetKey("w") && !JumpCooldownOn)
        {
            rb.AddForce(transform.up * 3500);
            JumpCooldownOn = true;
            JumpTimer = true;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }


        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;


        animator.SetFloat("Jump", rb.velocity.magnitude);

        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }



        if (JumpTimer)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                JumpCooldownOn = false;
                JumpTimer = false;
                timeRemaining = 4;
            }
        }
    }
}
