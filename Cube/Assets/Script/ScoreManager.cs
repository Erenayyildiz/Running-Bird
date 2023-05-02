using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    float score = 0f;
    [SerializeField] float addScore = 5f;
    [SerializeField] TextMeshProUGUI scoreText;

    void Update()
    {
        DisplayScore();
    }

    void OnTriggerEnter(Collider other)
    {
        Apple apple = other.gameObject.GetComponent<Apple>();
        
        if(apple != null)
        {
            score += addScore;
            Destroy(other.gameObject);
        }
    }

    void DisplayScore()
    {
        scoreText.text = score.ToString();
    }

    public float ResetScore()
    {
        return score;
    }
}
