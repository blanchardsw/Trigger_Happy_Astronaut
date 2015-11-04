using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {
	
	public PlatformerCharacter2D character;	
	Vector3 originalPosition = new Vector3 (-100.0f, 1.8f, 0.0f);
	Vector3 checkPoint = new Vector3 (254.6f, 1.0f, 0.0f);

	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.gameObject.tag == "Player") {
			if (character.transform.position.x < 254)
				coll.gameObject.transform.position = originalPosition;
			if (character.transform.position.x > 254)
				coll.gameObject.transform.position = checkPoint;

			if (character.lives <= 0){
				Application.LoadLevel("Game Over");
			}
			else{
				character.DecLives();
				character.death.Play();
			}
		}
		
	}

}