using UnityEngine;
using System.Collections;

public class Destroy_Ground : MonoBehaviour {
	float time_Left = 0.4f;
	
	void OnCollisionStay2D (Collision2D Player)
	{
		if (Player.gameObject.name == "Player")
		{
			time_Left -= Time.deltaTime;
			if (time_Left <= 0f)
				Destroy(gameObject);
		}
	}
}
