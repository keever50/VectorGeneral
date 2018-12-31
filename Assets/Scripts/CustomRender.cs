using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomRender : MonoBehaviour {

    void OnPreRender()
    {
       GL.wireframe = true;
    }

    void OnPostRender()
    {
       GL.wireframe = false;
    }

    // Use this for initialization
    private Camera Cam;
    void Start () {
        Cam = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    public GameObject LookingAt;

    void Update () {
        
        if (Input.mouseScrollDelta.y != 0f)
        {
            Cam.fieldOfView = Cam.fieldOfView - Input.mouseScrollDelta.y;
        }



	}
}
