using UnityEngine;
using System.Collections;

public class pipe_script : MonoBehaviour {
	public Transform Pipe;

	// Use this for initialization
	void Start () {
		int x = 10;
		while(x<=100) {
			Instantiate (Pipe, new Vector3(x, 5, 0), Quaternion.identity);
			x+=5;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
