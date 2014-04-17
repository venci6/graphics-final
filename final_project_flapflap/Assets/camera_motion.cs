using UnityEngine;
using System.Collections;

public class camera_motion : MonoBehaviour {
	GameObject bird;
	float new_x, y, z;

	void Start () {
		bird = GameObject.Find ("bird");
		new_x = 0.0f;
		
		y = transform.position.y;
		z = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		// want camera to follow bird (x's only)
		new_x = bird.transform.position.x;

		transform.position = new Vector3 (new_x, y, z);
	}
}
