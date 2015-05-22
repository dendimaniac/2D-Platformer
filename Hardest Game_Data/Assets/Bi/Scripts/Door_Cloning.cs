using UnityEngine;
using System.Collections;

public class Door_Cloning : MonoBehaviour {
	public GameObject Gift;
	public GameObject Door_Checking;
	public GameObject Door;

	void OnTriggerStay2D (Collider2D Player)
	{
		if (Player.name == "Player")
		{
			Destroy(Gift.gameObject);
			Instantiate(Door, Door.transform.position, Quaternion.identity);
		}
	}
}
