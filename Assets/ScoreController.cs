using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private int Score = 0;

	// Use this for initialization
	void Start () {
		Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int score) {
		Score += score;

		this.GetComponent<Text> ().text = "SCORE : " + Score;
	}
}
