using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10;
    Vector2 movement;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator.speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = 0;

        movement.x = Input.GetAxisRaw("Horizontal");
        if (movement.x == 0)
        {
            movement.y = Input.GetAxisRaw("Vertical");
        }
        
        //animator.SetFloat("walk_right", movement.x);
        //animator.SetFloat("walk_left", -movement.x);
        //animator.SetFloat("walk_down", -movement.y);
        //animator.SetFloat("walk_up", movement.y);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        //speed = 200 * Time.deltaTime;

       /*
        * if (Input.GetKey("left shift"))
        {
            speed = 200 * Time.deltaTime;
            //animator.speed = 1.5f;
        }
        else
        {
            speed = 110 * Time.deltaTime;
            //animator.speed = 1f;
        }
       */
    }
}
