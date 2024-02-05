using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AppleCatchGameDirector : MonoBehaviour
{
    [SerializeField] public Text scoreText;
    [SerializeField] public float score;
    public void AddScore()
    {
        this.score = score + 100;
        UpdateScoreText();
    }
    public void DecreaseScore()
    {
        this.score = score - 100;
        UpdateScoreText();

    }
    public void UpdateScoreText()
    {
        if (this.score != null)
        {          
            scoreText.text = score.ToString();
        }
    }
}
