using UnityEngine;
using System.Collections;

public class bird_motion : MonoBehaviour {
	public Vector3 x;
	public Vector3 v;

	public float g;
	public int rounds_passed;
	public bool start_game;

	public GameObject prefab;

	// Use this for initialization
	void Start () {
		g = 9.8f;
		rounds_passed = 0;
	
		x = new Vector3 (0, 2, 0);
		v = new Vector3 (8.0f, 0, 0);

		start_game = false;
	}
	
	// Update is called once per frame
	void Update () {
		float t = .02f;
		if (Input.GetKeyDown ("space")) {
			start_game = true;
		}

		if (!start_game) {
			x += t* v;
			transform.position = x;
		} else if(start_game) {
			if(Input.GetKeyDown("space")) { // add a constant amount
				v.y += 10.0f;
			}

			// add gravity to linear velocity
			v.y -= g*t;

			// update position by linear velocity
			x += t*v;

			//update transformations' position
			transform.position = x;
		}

		// if x.y = 0, end game
			// display the # of rounds
			// prompt play again
	
	}

	void Create_Pipes() {
		//GameObject go1 = (GameObject)Instantiate;
	}
}
