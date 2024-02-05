using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    
    public void GameOver()
    {
        if(this.score <= -300)
        {
            SceneManager.LoadScene("AppleCatchRetry");
        }
    }

}
