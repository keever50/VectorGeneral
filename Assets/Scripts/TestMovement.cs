using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TestMovement : MonoBehaviour {
    public NavMeshAgent agent;
    public AudioSource EngineSound;
	// Use this for initialization
	void Start () {
        agent = this.GetComponent<NavMeshAgent>();
       
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                agent.SetDestination(hit.point);
            }
        }
        if(agent.remainingDistance > 10)
        {
            EngineSound.pitch = Mathf.Lerp(EngineSound.pitch, 1, 0.02f);
        }
        else
        {
            EngineSound.pitch = Mathf.Lerp(EngineSound.pitch, 0.40f, 0.01f);
        }
    }
}
