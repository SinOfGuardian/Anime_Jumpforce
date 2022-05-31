using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject mainCamera;
    public GameObject Highbounce;

    public Queue<GameObject> Platforms;

    public int platformCount;
    private Rigidbody2D rb2d;
    public Vector3 spawnPosition;

    void Awake()
    {
       
        rb2d = GetComponent<Rigidbody2D>();
         spawnPosition = new Vector3();
        

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
       
    }

    // Update is called once per frame
    void Update()
    {
       /* if(platformPrefab.activeSelf || platformPrefab.transform.position.y + 6 < mainCamera.transform.position.y  )
        {
            Destroy(platformPrefab.gameObject);
        }*/

       if (Platforms.Count > 0 && Platforms.Peek().transform.position.y + 6 < mainCamera.transform.position.y)
      
        {
            
            Debug.Log("Nahulog si platform");
            //Time.timeScale = 0;
            // SceneManager.LoadScene("GameOver");
            //PauseMenuUI.gameObject.SetActive(true);
            //GameOver();

            //gameoverPlatform = new GameOver..transform.position.y = collision.gameObject.transform.position.y;
            /*   if (Random.Range(1, 5) == 1)
               {

                   Destroy(platformPrefab.gameObject);
                   Highbounce.SetActive(true);
                   Instantiate(Highbounce, new Vector2(Random.Range(-5f, 5f), Random.Range(0.5f, 2.0f)), Quaternion.identity);

               }
               else
               {

                   platformPrefab.gameObject.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(0.5f, 2.0f));

               }*/
            

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
}
