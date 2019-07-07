using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDies : MonoBehaviour
{
    public GameObject cube;
    public GameObject circle;
    public GameObject newCircle;
    public GameObject circle1;
    public GameObject circle2;
   // public GameObject sursaaudio;

    private GameObject GM;


    void Start()
    {
        GM = GameObject.Find("GameManager");
      
      
    }
    void OnTriggerEnter(Collider enemy)
    {
        if((enemy.CompareTag("player")) || (enemy.CompareTag("unbreakable")))
        {
            Vibration.Vibrate(20);
           // Instantiate(sursaaudio, transform.position, Quaternion.identity);
            transform.Translate(Vector3.up * 5f);
            circle1.transform.Translate(Vector3.up * 5f);
            circle2.transform.Translate(Vector3.up * 5f);
            //Destroy(cube);
             Destroy(circle, 0.05f);

            GM.SendMessage("UpdateScore", 5);
            SliderAdd.sliderValue.value += 1f;
            SliderPowerUp.sliderPowerValue.value += 1f;



        }
    }
   
}
