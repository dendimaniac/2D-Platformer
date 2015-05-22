using UnityEngine;
using System.Collections;

public class Falling_Control : MonoBehaviour {
	public GameObject Player;

	void OnCollisionEnter2D (Collision2D Player)
	{
		if (Player.gameObject.name == "Player")
			Player.gameObject.AddComponent<GameOverScript> ();
		if (Player.gameObject.name == "Falling Ground")
			Destroy (Player.gameObject);
	}
}
