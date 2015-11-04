using UnityEngine;
using System.Collections;

public class MyUnitySingleton : MonoBehaviour {
	
	public AudioClip newMusic;
	GameObject playThis;
	
	void Awake() {
		
				playThis = GameObject.Find ("Game Music");
				playThis.audio.clip = newMusic;
				if (playThis.audio.isPlaying == false)
					playThis.audio.Play ();
		}
}
