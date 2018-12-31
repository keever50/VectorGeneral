using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleUserControll : MonoBehaviour {
    public GameObject Npcs;


    // Use this for initialization
    public GameObject SelectionBox;
    RectTransform SelectionBoxRect;
    void Start () {
        SelectionBoxRect = SelectionBox.GetComponent<RectTransform>();

        Component[] NPCList = Npcs.GetComponentsInParent<Component>();
        print(NPCList.Length);
        foreach (Component NPC in NPCList)
        {
            print(NPC.tag);
        }
    }

    // Update is called once per frame
    Vector3 AimStart;
    Vector3 MouseStart;
	void FixedUpdate () {
        //Select + Group select
        if (Input.GetMouseButtonDown(0))
        {
            Ray NewRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            MouseStart = Input.mousePosition;
            RaycastHit hit;
            Physics.Raycast(NewRay, out hit, 10000);
            AimStart = hit.point;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Ray NewRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(NewRay, out hit, 10000);
            Vector3 AimEnd = hit.point;

            //When selection is made.
            if(AimStart != AimEnd)
            {
                Bounds SelectionBoundingBox = new Bounds();
                SelectionBoundingBox.center = AimStart + (ExtraVectors.Abs(( AimStart - AimEnd) )/2);
                SelectionBoundingBox.size = ExtraVectors.Abs((AimStart - AimEnd));
                
                print("Selection");
            }
            //When selection is not made. Just select
            else
            {
                print("Select");
            }

        }

    }
}
