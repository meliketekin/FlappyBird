using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdManager : MonoBehaviour
{
    [SerializeField]
    Text scoreText;
    public float speed;
    Rigidbody2D rigidbody;
    public static int score;

   
    void Start()
    {
        score = 0;
        Time.timeScale = 1; 
        rigidbody = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Column"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipe"))
        {
            Time.timeScale = 0; //freeze the game
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
