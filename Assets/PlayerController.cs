using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Animator anim;
    public Rigidbody2D rb;


    private Animator animator;
    private float moveInput;
    private float moveX = 0f;
    private float moveY = 0f;
    private float velocity;


    // Start is called before the first frame update
    void Awake()
    {
       
        rb = GetComponent<Rigidbody2D>();
        // Animate();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //processInputs()
        //moveX = Input.GetAxis("Horizontal") * moveSpeed;
        HandleMovement();
       


    }
    private void HandleMovement()
    {
       
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
        
       /*if (animator != null)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) )
            {
                animator.SetTrigger("Anya_left");
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetTrigger("Anya_right");
            }

        }*/
      

    }

    private void FixedUpdate()
    {
        Vector2 moveDir = new Vector2(moveX, moveY).normalized;
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;

        animator.SetFloat("horizontalMovement", moveDir.x);
    }

}
