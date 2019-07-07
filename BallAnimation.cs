using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimation : MonoBehaviour
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
            anim.Play("playeranimationwalk");
        }
        else
            anim.Play("playeranimation");
    }
}
