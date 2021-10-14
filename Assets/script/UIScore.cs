﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text Score;
    public ScoreManager ScoreManager;
   
    // Update is called once per frame
    void Update()
    {
        Score.text ="Score: " + ScoreManager.GetCurrentScore().ToString();
        
    }
}
