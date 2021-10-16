using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private static int highScore;
    #region Singleton

    private static ScoreManager _instance = null;

    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: GameFlowManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion
    private int currentScore;
    public int HighScore { get { return highScore; } }
    public int CurrentScore { get { return currentScore; } }

    
    private void Start()
    {
        ResetCurrentScore();
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public void IncrementCurrentScore()
    {
        currentScore++;
        
    }

    public void SetHighScore()
    {
        highScore = currentScore;
    }


   


    }
