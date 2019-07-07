using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    
    private int score;
    public TextMeshProUGUI text;

    void Start()
    {
        text.SetText(score.ToString());
        score = 0;
    }

    void Update()
    {
       
    }

    void UpdateScore(int splash)
    {
        this.score += splash;
        text.SetText(score.ToString());
    }

}
