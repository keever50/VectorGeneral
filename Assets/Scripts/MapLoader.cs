using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoader : MonoBehaviour {

    // Use this for initialization
    [Header(".prefab map relative to Assets/Resources/")]
    public string MapPath;
    private GameObject LoadedMap;
	void Start () {
        Debug.Log("Loading map... " + MapPath);
        LoadedMap = Instantiate( Resources.Load<GameObject>(MapPath) );
        Debug.Log("Done. " + LoadedMap.GetComponentsInChildren<Component>().Length + " components.");
        
        LoadedMap.transform.SetParent(GameObject.Find("Map").transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
