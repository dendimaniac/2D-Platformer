using UnityEngine;
using System.Collections;

public class Winning_Control : MonoBehaviour {
	public Transform winningCheck;
	public GUIText Score;

	bool winning = false;
	int previousScore;
	int currentScore;
	int winningScore = 1;
	int winningCount = 0;

	void Update ()
	{
		Debug.Log (currentScore + "," + previousScore);

		if (winning && winningCount == 0)
		{
			winningCount = 1;
			previousScore = currentScore;
			currentScore = previousScore + winningScore;
			Score.text = "Score: " + currentScore;
		}

		if (winning == false)
		{
			winningCount = 0;
		}
	}
}