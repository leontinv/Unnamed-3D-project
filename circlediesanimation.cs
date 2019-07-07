using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class circlediesanimation : MonoBehaviour
{
    public static Animator anime;
   
    

    void Start()
    {
        anime = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
   void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("player"))
        {
            anime.Play("circledies");
            Debug.Log("cancer");
            //SceneManager.LoadScene(0);
        }
    }

}
