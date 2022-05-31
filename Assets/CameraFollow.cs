using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraFollow : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject mainheart;
    public Transform target;
    public Text IGScore;
    private float topScore = 0.0f;

    private int igscore = 0;
    // Start is called before the first frame update
    private void LateUpdate()
    {

        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
            
            igscore = (int)transform.position.y;
            //IGScore.text = "Score: " + Mathf.Round(transform.position.y).ToString();
            IGScore.text = "Score: " + igscore.ToString();
            PlayerPrefs.SetInt("SCORE", igscore);
            PlayerPrefs.Save();
        }
        if (target.position.y + 7 < transform.position.y)
        {
            Time.timeScale = 0;
            // SceneManager.LoadScene("GameOver");
            mainheart.SetActive(false);
            GameOverUI.SetActive(true);
            //Pausemenu.GamObject.SetActive(true);
            //GameOver();

        }
       
    }
}
