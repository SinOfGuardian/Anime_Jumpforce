using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static event Action isPlayerDamaged;
    public static event Action onPlayerDamaged;
    public static event Action isPlayerDeath;


    public Bar bar;

    public int maxHealth;
     public int currentHealth;

    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //Debug.Log("Im Hit");
    }

    public void TakeDamage(int amount)
    {

        currentHealth -= amount;
        // bar.DrawHeart();
        Debug.Log("Im Hit");
        onPlayerDamaged?.Invoke();

        //OnPlayerDamaged?.Invoke();
        if (currentHealth <= 0)
        {
           
            currentHealth = 0;
          
           
            Debug.Log("Im DEAD");
            // Im dead
            //playdead animation
            anim.SetBool("isPlayerDamaged",true);
            isPlayerDeath?.Invoke();
            //show game over screen
        }
    }

    




}
