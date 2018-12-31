using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraVectors : MonoBehaviour {

    static public Vector3 Abs( Vector3 V )
    {
        float X = Mathf.Abs(V.x);
        float Y = Mathf.Abs(V.y);
        float Z = Mathf.Abs(V.z);
        return new Vector3(X,Y,Z);
    }
}
