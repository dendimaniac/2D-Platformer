using UnityEngine;
using System.Collections;

public class Show_Text_Losing : MonoBehaviour {
	public GUIText show_losing;

	void Awake ()
	{
		show_losing.enabled = false;
	}

	void OnCollisionEnter2D (Collision2D collider)
	{
		if (collider.gameObject.tag == "Enemy")
		{
			Destroy (gameObject);
			show_losing.enabled = true;
			collider.gameObject.AddComponent<GameOverScript> ();
		} 
		if (collider.gameObject.name == "Falling Detect")
		{
			Destroy (gameObject);
			show_losing.enabled = true;
			collider.gameObject.AddComponent<GameOverScript> ();
		}
	}
}
