using UnityEngine;
using System.Collections;

public class Faking_Enemy : MonoBehaviour {
	public GameObject Enemy;

	void OnTriggerStay2D (Collider2D Player)
	{
		if (Player.name == "Player")
		{
			Destroy(Enemy.gameObject);
		}
	}
}