using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {

	public GUIStyle info;
	public GUISkin MainMenu;
	public MovieTexture demo;

	void OnGUI(){

		GUI.Label (new Rect (Screen.width * .85f, 0, Screen.width * .1f, Screen.width * .1f), "Trigger-Happy Astronaut\nCMPS327\nFall 2014\nStephen Blanchard\n", info);

		GUI.skin = MainMenu;

		if (GUI.Button (new Rect (0, 0, Screen.width * .05f, Screen.width * .02f), "")) {
			Application.LoadLevel("Menu");
		}
	}
}
