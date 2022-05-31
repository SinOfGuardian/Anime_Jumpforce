using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimera : MonoBehaviour
{

 
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      /*  if (collision.tag != "chimera")
        {
            gameObject.transform.parent = collision.gameObject.transform;
          Destroy(rigidbody);
      GetComponent<BoxCollider2D>().enabled = false;
            
        }*/
        if (collision.CompareTag("Player"))
        {
            var healthComponent = collision.GetComponent<Health>();

            if (healthComponent != null)
            {
                healthComponent.TakeDamage(1);
                
            }
        }
    }

}
