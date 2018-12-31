using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    float Mover = 0;
	void Update () {
        Mover = Mover + 0.1f;
        this.transform.position = new Vector3(Mathf.Sin(Mover) *10f, 1, Mathf.Cos(Mover) * 10f);

        this.transform.Rotate(new Vector3(0,1f,0));	
	}
}
