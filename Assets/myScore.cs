using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScore : MonoBehaviour {

	private int score;

	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find("ScoreText");

		// タグによってスコアを設定
		if (tag == "SmallStarTag") {
			score = 10;

		} else if (tag == "LargeStarTag") {
			score = 40;

		} else if (tag == "SmallCloudTag") {
			score = 20;

		} else if (tag == "LargeCloudTag") {
			score = 50;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other)
	{
		this.scoreText.GetComponent<ScoreController> ().AddScore (score);
	}
}
