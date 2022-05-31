using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highbounce : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0 )
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);

        }
    }
}
