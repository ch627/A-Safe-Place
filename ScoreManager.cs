using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int scoreCount;
    public static int highScoreCount;
    public Text scoreText; public GameObject normalZombie;
    public CanvasGroup score;
    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0; // set the score to 0 at the start of the game
        highScoreCount = PlayerPrefs.GetInt("HighScore", highScoreCount); // store the highScore
        score.alpha = 1;
        score.interactable = true;
        score.blocksRaycasts = true;

    }

    // Update is called once per frame
    void Update()
    {

        
        if (normalZombie == null)
        {
            scoreCount += scoreCount + 100;





        }
        scoreText.text = "Score: " + scoreCount.ToString(); // display the player's score

        if (scoreCount > highScoreCount)
        {
            scoreCount = highScoreCount;
            PlayerPrefs.SetInt("HighScore", highScoreCount);
            PlayerPrefs.Save();
        }

        if (Time.timeScale == 0)
        {
            score.alpha = 0;
            score.interactable = false;
            score.blocksRaycasts = false;
        }

            




    }
}
