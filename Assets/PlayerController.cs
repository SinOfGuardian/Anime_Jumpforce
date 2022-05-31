using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Animator anim;
    public Rigidbody2D rb;

    private GameManager gm;
    private Animator animator;
    private float moveInput;
    private float moveX = 0f;
    private float moveY = 0f;
    private float velocity;


    // Start is called before the first frame update
    void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        // Animate();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //processInputs();
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
       // HandleMovement();
       


    }
    private void HandleMovement()
    {
       
        moveX = Input.GetAxis("Horizontal") * moveSpeed;



    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        /*  if (collision.tag != "chimera")
          {
              gameObject.transform.parent = collision.gameObject.transform;
            Destroy(rigidbody);
        GetComponent<BoxCollider2D>().enabled = false;

          }*/
        if (collision.CompareTag("Monster"))
        {
           // var monsterdamage = collision.GetComponent<GameManager>();
                gm.TakeDamage(1);

        }
    }
    private void FixedUpdate()
    {
       Vector2 moveDir = new Vector2(moveX, moveY).normalized;
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;

        animator.SetFloat("Anya_move", moveDir.x);
        Debug.Log("ERROR");
    }


}

