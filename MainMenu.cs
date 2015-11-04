using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUISkin Play;
	public GUISkin Demo;
	public GUISkin GameInfo;
	public GUISkin Exit;


	void OnGUI(){

		GUI.skin = Play;

		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .45f, Screen.width * .5f, Screen.height * .15f), "")) {
			Application.LoadLevel("Level1");
		}

		GUI.skin = Demo;

		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .55f, Screen.width * .5f, Screen.height * .15f), "")) {
			Application.LoadLevel ("Demo");
		}

		GUI.skin = GameInfo;

		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .65f, Screen.width * .5f, Screen.height * .15f), "")) {
			Application.LoadLevel ("Controls");
		}

		GUI.skin = Exit;

		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .75f, Screen.width * .5f, Screen.height * .15f), "")) {
			Application.Quit();
		}
	}

}
