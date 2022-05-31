using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverMenu;
    public Health playHealth;
        
   /* public void OnEnable()
    {
        playHealth.isPlayerDeath += EnableGameOverMenu();

    }
    public void OnDisable()
    {
        playHealth.isPlayerDeath -= EnableGameOverMenu();

    }*/
    public void EnableGameOverMenu()
    {
        GameOverMenu.SetActive(true);

    }
}
