using UnityEngine;
using System.Collections;

public class Pausing : MonoBehaviour {
	int count = 0;
	public GUIText pause;

	void Awake()
	{
		if (Application.loadedLevelName == "Level 4")
			Time.timeScale = 1;
		pause.enabled = false;
	}

	void Update () {
		if (Input.GetButtonDown ("Cancel"))
		{
			count++;
			if (count == 1)
			{
				Time.timeScale = 0;
				pause.enabled = true;
				gameObject.AddComponent<GameOverScript> ();
			}
			else
			{
				Time.timeScale = 1;
				pause.enabled = false;
				Destroy(gameObject.GetComponent<GameOverScript>());
			}
			if (count == 2)
				count = 0;
		}
	}
}
