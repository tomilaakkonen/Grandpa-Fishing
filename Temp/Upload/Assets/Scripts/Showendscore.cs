using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showendscore : MonoBehaviour {
    public Text scoretext;

    public float scoreCount;
    // Use this for initialization
    void Start () {
        scoreCount = PlayerPrefs.GetFloat("Player Score");
    }
	
	// Update is called once per frame
	void Update () {
        scoretext.text = "Your score: " + scoreCount + "kg";
    }
}
