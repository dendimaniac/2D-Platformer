using UnityEngine;
using System.Collections;

public class Gifting_Control : MonoBehaviour {
	public GUIText Score;

	void OnTriggerStay2D (Collider2D Player)
	{
		Destroy (gameObject);
		Score.text = "Score: 1000";
	}
}
