using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    
    void Start()
    {
        score = 0;  
    }
    public void ScoreUp()
    {
        score++;
        GetComponent<Text>().text = score.ToString();
    }
}
