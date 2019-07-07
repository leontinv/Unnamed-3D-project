using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraanimation : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.Play("newcamerafast");
        }
        else
            anim.Play("newcameraslow");
    }
}
