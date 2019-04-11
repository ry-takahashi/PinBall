using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScore : MonoBehaviour {

	[SerializeField]
	private int score;

	private GameObject scoreText;

	// Use this for initialization
	void Start () {

		this.scoreText = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other)
	{
		this.scoreText.GetComponent<ScoreController> ().AddScore (score);
	}
}
