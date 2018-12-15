using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour {
    public static int ScoreValue = 0;
    
    Text Score;

    // Use this for initialization
    void Start()
    {
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score : " + ScoreValue;
        
    }
}
