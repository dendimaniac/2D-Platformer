using UnityEngine;
using System.Collections;

public class Sign_Control : MonoBehaviour {
	public GameObject sign_Text;

	// Use this for initialization
	void Awake ()
	{
		sign_Text.SetActive (false);
	}

	void OnTriggerStay2D (Collider2D Player)
	{
		if (Player.name == "Player")
			sign_Text.SetActive (true);
	}

	void OnTriggerExit2D (Collider2D Player)
	{
		if (Player.name == "Player")
		{
			if (Player.gameObject != null)
				sign_Text.SetActive (false);
		}
	}
}
