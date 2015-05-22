using UnityEngine;
using System.Collections;

public class Falling_Ground : MonoBehaviour {
	float time_Left = 0.5f;

	void OnCollisionStay2D (Collision2D Player)
	{
		if (Player.gameObject.name == "Player")
		{
			time_Left -= Time.deltaTime;
			if (time_Left <= 0f)
				GetComponent<Rigidbody2D>().isKinematic = false;
		}
	}
}
