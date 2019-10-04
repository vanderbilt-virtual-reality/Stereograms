using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeSwitcher : MonoBehaviour {

	public Camera camera_left;
	public Camera camera_right;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (camera_left.isActiveAndEnabled) {
			camera_left.enabled = false;
			camera_right.enabled = true;
		} else {
			camera_left.enabled = true;
			camera_right.enabled = false;
		}
	}
}
