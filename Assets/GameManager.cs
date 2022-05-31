using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject platformPrefab;
    public GameObject mainCamera;
    public GameObject Highbounce;
    public GameObject mainHeart;
    public GameObject one1;
    public GameObject two2;
    public GameObject three3;
    public GameObject GameOverUI;
   

    public Queue<GameObject> Platforms;

     int currentHealth;
    public int platformCount;
    public  Rigidbody2D rb2d;
    public Vector3 spawnPosition;

    void Awake()
    {
       
        rb2d = GetComponent<Rigidbody2D>();
    
         spawnPosition = new Vector3();
        currentHealth = 3;

        Platforms = new Queue<GameObject>();
        //Platforms.Enqueue(platformPrefab);

        
        
        for (int i = 0; i < platformCount; i++)
        {
            
            spawnPosition.y += Random.Range(1f, 4f);
            spawnPosition.x = Random.Range(-5f, 5f);
            GameObject clone = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            Platforms.Enqueue(clone);

        }
       
    }
    // Start is called before the first frame update

    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {


        if (Platforms.Count > 0 && Platforms.Peek().transform.position.y + 6 < mainCamera.transform.position.y)
      
        {
     
                Destroy(Platforms.Peek().gameObject);
                Platforms.Dequeue();

                spawnPosition.y += Random.Range(.5f, 2f);
                spawnPosition.x = Random.Range(-5f, 5f);

            if (Random.Range(1, 7) == 1)
            {
                GameObject clone = Instantiate(Highbounce, spawnPosition, Quaternion.identity);
                clone.SetActive(true);
                Platforms.Enqueue(clone);
            }
            else
            {
                GameObject clone = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
                Platforms.Enqueue(clone);
            } 
        }

       
    }
    public void TakeDamage(int amount)
    {
        
        //OnPlayerDamaged?.Invoke();
        if (currentHealth <= 1)
        {
            Debug.Log("Im DEAD");
            // Im dead
            //playdead animation
            Time.timeScale = 0;
            GameOverUI.SetActive(true);
            mainHeart.SetActive(false);
            

            //show game over screen
        }
        else
        {
            
       
            // bar.DrawHeart();
            if (currentHealth == 1)
            {
                one1.SetActive(false);
                two2.SetActive(false);
                three3.SetActive(false);
            }
            else if(currentHealth == 2){
                one1.SetActive(true);
                two2.SetActive(false);
                three3.SetActive(false);
            } 
            else if (currentHealth == 3)
            {
                one1.SetActive(true);
                two2.SetActive(true);
                three3.SetActive(false);
            }
            else if (currentHealth == 3)
            {
                one1.SetActive(true);
                two2.SetActive(true);
                three3.SetActive(true);
            }
            currentHealth -= amount;
        }
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("restart");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
