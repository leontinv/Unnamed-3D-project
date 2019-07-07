using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public float spiny;
    

   
    void Update()
    {
        transform.Rotate(0f, spiny, 0f);
    }
}
