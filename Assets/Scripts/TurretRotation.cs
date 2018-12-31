using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour {

    // Use this for initialization
    AudioSource SpinSound;
    
    
	void Start () {

        SpinSound = gameObject.AddComponent<AudioSource>();
        SpinSound.clip = Resources.Load<AudioClip>("Sounds/Other/turret4");
        SpinSound.maxDistance = 50;
        SpinSound.spatialBlend = 1;
        SpinSound.loop = true;
        SpinSound.Play();
    }

    // Update is called once per frame
    public float damping;
    private Vector3 target;
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                target = hit.point;
            }
        }
        var lookPos = target - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        var Slerp = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        transform.rotation = Slerp;

        //Sound effect
        float diff = Mathf.Abs(Mathf.Abs(Slerp.y) - Mathf.Abs(rotation.y));
        SpinSound.pitch = diff * 2 ;
    }
}
