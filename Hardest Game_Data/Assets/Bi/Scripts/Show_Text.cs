using UnityEngine;
using System.Collections;

public class Show_Text : MonoBehaviour {
	public GUIText show_Text;
	
	void Awake ()
	{
		show_Text.enabled = false;
	}
	
	void OnCollisionEnter2D (Collision2D player)
	{
		if (player.gameObject.tag == "Player")
		{
			Destroy (player.gameObject);
			show_Text.enabled = true;
			transform.parent.gameObject.AddComponent<GameOverScript>();
		}
	}
}
