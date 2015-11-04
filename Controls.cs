using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public GUIStyle bluePlat;
	public GUIStyle greenPlat;
	public GUIStyle controls;
	public GUIStyle info;
	public GUIStyle bombs;

	public GUISkin Menu;

	void OnGUI(){

		GUI.skin = Menu;

		if (GUI.Button (new Rect (Screen.width * .001f, Screen.height *.95f, Screen.width * .05f, Screen.width * .02f), "")) {
			Application.LoadLevel("Menu");
		}

		GUI.Label (new Rect (Screen.width*.84f, Screen.height*.62f, Screen.width * .1f, Screen.height * .1f), "You can jump on these", bluePlat);
		GUI.Label (new Rect (Screen.width*.84f, Screen.height*.79f, Screen.width * .1f, Screen.height * .1f), "You can pass through these", greenPlat);
		GUI.Label (new Rect (0, 0, Screen.width * .1f, Screen.width * .1f), "W S A D - Move\nSpacebar - Jump\nLeft Mouse - Shoot\nEscape - Main Menu\n(Shoot platforms to toggle state)\n\nF12 - Advance to checkpoint", controls);
		GUI.Label (new Rect (Screen.width * .85f, 0, Screen.width * .1f, Screen.width * .1f), "Trigger-Happy Astronaut\nCMPS327\nFall 2014\nStephen Blanchard\n", info);
		GUI.Label (new Rect (Screen.width*.82f, Screen.height*.55f, Screen.width * .1f, Screen.height * .1f), "Shoot bombs to destroy them", bombs);
	}
}
