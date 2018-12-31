using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private Vector3 CameraVelocity = new Vector3(0,0,0);
    private Vector3 CameraApplyVelocity;
	void FixedUpdate () {
        //Drag
        CameraVelocity = CameraVelocity / 2f;

        //Controll
        CameraApplyVelocity.Set(0,0,0);
        if (Input.GetKey(KeyCode.W))
        {
            CameraApplyVelocity = CameraApplyVelocity + this.transform.forward * 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            CameraApplyVelocity = CameraApplyVelocity + this.transform.forward * -1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            CameraApplyVelocity = CameraApplyVelocity + this.transform.right * -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            CameraApplyVelocity = CameraApplyVelocity + this.transform.right * 1f;
        }

        //Apply velocity
        CameraVelocity = CameraApplyVelocity;

        //Movement
        if (CameraVelocity.magnitude > 0.1f)
        {
            this.transform.position = this.transform.position + CameraVelocity;
        }
	}
}
