using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNewCircle : MonoBehaviour
{
    public float spinx;



    void Update()
    {
        transform.Rotate(0f, spinx, 0f);
    }
}
