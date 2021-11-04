using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text highscoreText;
    public Text scoreText;
    private GameObject obsacle;

    float score = 0;
    float highscore = 0;
    int scorestorage = 0;

   
  
    void Start()
    {
       highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "Highscore: " + highscore.ToString();
    }
   
    void Update()
    {
        
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            scorestorage = (int)score;

        if(highscore < scorestorage) 
        PlayerPrefs.SetInt("highscore", scorestorage);
  
    }

}
