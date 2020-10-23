// Author: Kevin Nguyen (Character movement)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{


    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    Vector2 movement;



    private bool facingRight = true; 

    public GameObject bullet; 
    Animator animator;





    private void Start()
    {

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        float move = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey("w") || Input.GetKey("d") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("down") || Input.GetKey("up") || Input.GetKey("right") || Input.GetKey("left"))
        {
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey("space"))
        {
            animator.SetBool("isAttack", true);
        }

        else if (!Input.GetKey("space"))
        {
            animator.SetBool("isAttack", false);


        }


        //if ( move <0 && facingRight)
        //{
        //    Flip(); 
        //}
        //else if (move > 0 && !facingRight)
        //{
        //    Flip(); 

        //}
        else
        {
            animator.SetBool("isWalking", false);
        }


    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 

    }
    void Flip ()
    {
        transform.Rotate(0f, 180f, 0f); 
    }

    
}
