using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GUISkin MainMenu;
	public GUISkin Exit;
	

	void OnGUI(){

		GUI.skin = Exit;

		if (GUI.Button (new Rect (Screen.width * .295f, Screen.height * .6f, Screen.width * .35f, Screen.height * .15f), "")) {
			Application.Quit ();
		}

		GUI.skin = MainMenu;

		if (GUI.Button (new Rect (Screen.width * .455f, Screen.height * .55f, Screen.width * .075f, Screen.height * .075f), "")) {
			Application.LoadLevel ("Menu");
		}
	}
}
