using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
	public Text score;
	public float scoreCount;
	public float pointsPerSecond;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreCount += pointsPerSecond * Time.deltaTime;
		score.text = "Score: " + Mathf.Round(scoreCount); 
	}
}
