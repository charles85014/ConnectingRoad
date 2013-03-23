using UnityEngine;
using System.Collections;

public class T_Conveyor : MonoBehaviour {
    ReGui ObjSpeed;
	// Use this for initialization
	void Start () {
        ObjSpeed = GameObject.Find("ReST_GUIValue").GetComponent<ReGui>();
	}
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "ConveyorTrigger")
        {
            this.transform.position += new Vector3(ObjSpeed.ObjSpeed, 0, 0);
        }
     

    }
	// Update is called once per frame
	void Update () {
	
	}
}
