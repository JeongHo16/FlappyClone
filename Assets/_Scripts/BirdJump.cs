using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; 
    AudioSource ac;
    public float jumpPower;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ac = GetComponent<AudioSource>();
    }

    void Update()
    {
        //GetMouseButtonDown 는 스마트폰 터치와 같음.
        if (Input.GetMouseButtonDown(0)) //0 == 왼쪽
        {
            ac.Play();
            rb.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Score.score > Score.bestScore) Score.bestScore = Score.score;
        SceneManager.LoadScene("GameOver");
    }
}
