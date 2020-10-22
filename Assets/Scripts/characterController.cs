using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{


    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    Vector2 movement;

    Animator animator; 
         




    private void Start()
    {

        animator = GetComponent<Animator>(); 
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKey("w") || Input.GetKey("d") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("down") || Input.GetKey("up") || Input.GetKey("right") || Input.GetKey("left"))
        {
            animator.SetBool("isWalking", true);
        }
        if ( Input.GetKey ("space"))
        {
            animator.SetBool("isAttack", true);
        }

        if ( ! Input.GetKey("space"))
        {
            animator.SetBool("isAttack", false);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }


    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 

    }
}
