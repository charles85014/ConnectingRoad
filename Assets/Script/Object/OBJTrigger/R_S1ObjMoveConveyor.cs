using UnityEngine;
using System.Collections;

public class R_S1ObjMoveConveyor : MonoBehaviour {
    int RS1_MoveYNum01 = 0;
    int RS1_MoveYNum02 = 0;
    float Zdis = 0;
    public GameObject MoveConveyor01,MoveConveyor02;
    StageData StageCounter;
    ReGui ObjSpeed;
	// Use this for initialization
	void Start () {
        MoveConveyor01 = GameObject.Find("MoveConveyor01");
        MoveConveyor02 = GameObject.Find("MoveConveyor02");
        ObjSpeed = GameObject.Find("ReST_GUIValue").GetComponent<ReGui>();
        StageCounter = GameObject.Find("StageData").GetComponent<StageData>();
        if (StageCounter.StageCount == 1)
            this.gameObject.GetComponent<R_S1ObjMoveConveyor>().enabled = true;
        else
            this.gameObject.GetComponent<R_S1ObjMoveConveyor>().enabled = false;
	}
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "MoveConveyorTrigger01")
        {
            Zdis = this.gameObject.transform.position.z - MoveConveyor01.transform.position.z;
          
            RS1_MoveYNum01 = 1;
            
        }
        else
        {
            RS1_MoveYNum01 = 0;
        }

        if (other.gameObject.name == "MoveConveyorTrigger02")
        {
            Zdis = this.gameObject.transform.position.z - MoveConveyor02.transform.position.z;
         
            RS1_MoveYNum02 = 1;

        }
        else
        {
            RS1_MoveYNum02 = 0;
        }

    }
	// Update is called once per frame
	void Update () {
        if (RS1_MoveYNum01 == 1)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + ObjSpeed.ObjSpeed, this.gameObject.transform.position.y, MoveConveyor01.transform.position.z + Zdis);
        }
        if (RS1_MoveYNum02 == 1)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + ObjSpeed.ObjSpeed, this.gameObject.transform.position.y, MoveConveyor02.transform.position.z + Zdis);
        }
	}
}
