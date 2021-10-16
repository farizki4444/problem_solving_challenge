using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore78 : MonoBehaviour
{
    public Text score;
    public ScoreManager78 scoreControl;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        score.text = scoreControl.GetCurrentScore().ToString();
    }
}
