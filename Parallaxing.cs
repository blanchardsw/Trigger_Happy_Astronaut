using UnityEngine;
using System.Collections;

public class Paralaxing : MonoBehaviour {

	public Transform[] backgrounds;	//array of all back and foregrounds to be parallaxed
	private float[] parallaxScales;  //proportion of camera's movement to move backgrounds by
	public float smoothing = 1;			//how smooth the parallax is going to be.  Set this above 0.

	private Transform cam;			//reference to main camera's transform
	private Vector3 previousCamPos;	//the position of the camera in the previous frame

	//called before start
	void Awake () {
		//set up camera reference
		cam = Camera.main.transform;
	}


	void Start () {
	//the previous frame had the current frame's position
		previousCamPos = cam.position;

		parallaxScales = new float[backgrounds.Length];
		//assigning corresponding parallax scales
		for (int i = 0; i < backgrounds.Length; i++) {
			parallaxScales[i] = backgrounds[i].position.z*-1;
		}
	}


	void Update () {
		for (int i = 0; i < backgrounds.Length; i++) {
			//the parallax is the opposite of the camera movement because the previous frame multiplied by the scale
			float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

			//set a target x position which is the current position + the parallax
			float backgroundTargetPosX = backgrounds[i].position.x + parallax;

			//create a target position which is the background's current position with its target x position
			Vector3 backgroundTargetPos = new Vector3 (backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

			//fade between current position and target position
			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
		}

		//set previous cam Pos to camera's position at the end of the frame
		previousCamPos = cam.position;
	}
}
