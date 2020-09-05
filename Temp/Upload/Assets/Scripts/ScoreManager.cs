using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetFloat("HighScore") != null)
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
	}
	
	// Update is called once per frame
	void Update () {

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }
        scoreText.text = "Score: " + scoreCount + "kg";
        hiScoreText.text = "High Score: " + hiScoreCount + "kg";

	}

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
        PlayerPrefs.SetFloat("Player Score", scoreCount);
    }
}
