using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public static bool GameOver = false;
    public GameObject GameOverUI;
   // public GameObject sphere;
    public GameObject circle;
    

    void Update()
    {
        if (GameOver)
            GameOverUI.SetActive(true);
    }

    void OnTriggerEnter(Collider enemy)
    {
        if(enemy.CompareTag("player"))
        {
            GameOverUI.SetActive(true);
            Movement.speed = 0f;
           // Destroy(sphere);
            
        }

        if(enemy.CompareTag("unbreakable"))
        {
            transform.Translate(Vector3.up * 5f);
            Destroy(circle);
            
        }
    }
}
