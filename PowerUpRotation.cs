using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRotation : MonoBehaviour
{
    [SerializeField]
    private float spinx;
       
    void Update()
    {
        transform.Rotate(spinx, 0f, 0f);  
    }
}
