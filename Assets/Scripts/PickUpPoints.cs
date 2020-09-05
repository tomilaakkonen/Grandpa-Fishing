using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPoints : MonoBehaviour {
    public int scoreToGive;
    public Transfer transfer;
    private ScoreManager theScoreManager;

	// Use this for initialization
	void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "ScoreBox")
        {
            theScoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);
            transfer.hookTag();
        }
    }
}
