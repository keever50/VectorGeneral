using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_engine_sound : MonoBehaviour {

    // Use this for initialization
    public AudioSource AS;
	void Start () {
        //AS = this.GetComponent<AudioSource>();   	
	}

    // Update is called once per frame
    public float IdlePitch = 0.1f;
    public float MaxPitch = 1f;
    public float TopSpeed = 1.5f;
    float posdeltamag = 0f;
    void FixedUpdate () {
        //float Speed = this.GetComponent<Rigidbody>().velocity.magnitude;
        float posmag = Mathf.Abs(this.transform.position.x) + Mathf.Abs(this.transform.position.y) + Mathf.Abs(this.transform.position.z);
        float Speed = Mathf.Abs(posmag - posdeltamag)*Time.fixedTime;
        AS.pitch = IdlePitch + ( (Speed / TopSpeed) * (MaxPitch - IdlePitch) );
        posdeltamag = Mathf.Abs(this.transform.position.x)+ Mathf.Abs(this.transform.position.y)+ Mathf.Abs(this.transform.position.z);
    }
}
