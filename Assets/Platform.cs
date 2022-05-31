using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpforce;
    private float moveY = 0f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0 )
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                if(rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpforce;
                rb.velocity = velocity;
               
            }

        }
    }
   /* private void Update()
    {
        if (transform.position.y + 6 < )
        {
            Time.timeScale = 0;
            // SceneManager.LoadScene("GameOver");
            //PauseMenuUI.gameObject.SetActive(true);
            //GameOver();

        }
    }*/
}
