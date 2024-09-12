using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<Text>();

        UpdateScoreText();
        InvokeRepeating("AddScoreEverySecond",1.0f,1.0f);
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Update is called once per frame
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    void AddScoreEverySecond()
    {
        AddScore(2);
    }
}
