using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	public GUISkin MainMenu;
	public GUISkin Exit;
	
	
	void OnGUI(){
		
		GUI.skin = MainMenu;
		
		if (GUI.Button (new Rect (0,0, Screen.width * .05f, Screen.height * .05f), "")) {
			Application.LoadLevel ("Menu");
		}
	}
}
