using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private float scorevalue = 1;
    private float speed = 1.1f;
    private float lastTimeMeasure;
    private float lastTimeMeasureScore;

    Text scoreboard;
    private float bestScore;


    void Awake()
    {
        scoreboard = GetComponent<Text>();
        bestScore = PlayerPrefs.GetFloat("Recorde", 0);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTimeMeasure >= 5f)
        {
            speed = speed * 1.1f;
            lastTimeMeasure = Time.time;
        }

        if (Time.time - lastTimeMeasureScore >= 0.1f)
        {
            scorevalue = (float)Math.Floor(scorevalue + 1 * speed);
            bestScore = Math.Max(bestScore, scorevalue);
            scoreboard.text = "Pontuação: " + Math.Floor(scorevalue) + "\nRecorde: " + bestScore;
            lastTimeMeasureScore = Time.time;
            PlayerPrefs.SetFloat("Recorde", bestScore);
        }
    }
}
