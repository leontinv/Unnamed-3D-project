using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("player")) || (other.CompareTag("unbreakable")))
        {
            SceneManager.LoadScene(0);
        }
    }
}
