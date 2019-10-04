using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour {

	public OVRCameraRig myCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// Captures the rotation of the player's headset
		Transform myCameraTransform = myCamera.centerEyeAnchor;

		// The sprite will always face the camera
		// transform.LookAt(myCameraTransform.position, Vector3.up);

		// The sprite will always be perpendicular to the camera
		transform.forward = myCameraTransform.forward;
	}
}
