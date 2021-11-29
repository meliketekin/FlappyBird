using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class FinalManager : MonoBehaviour
{
    
    [SerializeField]
    private Text scoreText;
   
    void Start()
    {
        Time.timeScale = 1;
        scoreText.text = BirdManager.score.ToString();
    }
 
    public void playAgain()
    {  
        SceneManager.LoadScene("GameScene");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("GameMenuScene");
    }
}
