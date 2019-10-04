using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeSwitcherSingle : MonoBehaviour {

    private new Camera camera;

    // Use this for initialization
    void Awake () {
        camera = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (camera.stereoTargetEye == StereoTargetEyeMask.Left) {
            camera.stereoTargetEye = StereoTargetEyeMask.Right;
        } else
        {
            camera.stereoTargetEye = StereoTargetEyeMask.Left;
        }
	}
}
