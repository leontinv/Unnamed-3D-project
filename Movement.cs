using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public static float speed;
    public float decreaseSpeedMultiplier;
    public float accelerationMultiplier;

    private int isAccelerated;
    private bool isSlowed;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");
        speed = 2.5f;
        player = this.gameObject;
        isAccelerated = 0;
        isSlowed = false;
    }

    // Update is called once per frame
    void Update()
    {
        float actualSpeed = speed * (1 + isAccelerated * accelerationMultiplier) * (isSlowed ? decreaseSpeedMultiplier:1);


        if (Input.GetMouseButton(0))
        {
            isAccelerated = 1;
            isSlowed = false;
        
        }
        else
        {
            isSlowed = true;
            isAccelerated = 0;
        }
      
      

        transform.Translate(Vector3.forward * actualSpeed * Time.deltaTime);


    }


}
