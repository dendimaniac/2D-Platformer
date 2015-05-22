using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 100;
		const int buttonHeight = 80;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRectStart = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);


		Rect buttonRectExit = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2) + (buttonHeight * 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		// Draw a button to start the game
		if(GUI.Button(buttonRectStart,"Start"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Introduction");
		}

		if (GUI.Button(buttonRectExit,"Exit"))
		{
			// On Click, quit the game.
			Application.Quit();
		}
	}
}