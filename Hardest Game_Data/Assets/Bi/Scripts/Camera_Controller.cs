using UnityEngine;
using System.Collections;

public class Camera_Controller : MonoBehaviour {
	public GameObject Player;

	void Update ()
	{
		if (Player.gameObject != null)
		    transform.position = new Vector3 (Player.transform.position.x, transform.position.y, transform.position.z);
	}
}