using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCount;
    void Awake()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < platformCount; i++)
        {
            Debug.Log(i);
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-5f, 5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
    // Start is called before the first frame update

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
