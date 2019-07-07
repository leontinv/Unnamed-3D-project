using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderPowerUp : MonoBehaviour
{
    public static Slider sliderPowerValue;
    public GameObject powerUp;
    public GameObject player;
    private float time = 10f;


    void Start()
    {
        sliderPowerValue = GetComponent<Slider>();
        sliderPowerValue.value = 0f;
    }

    void Update()
    {
        if (sliderPowerValue.value == 10f)
        {
            powerUp.SetActive(true);
            player.tag = "unbreakable";
        }
    }


  
}
