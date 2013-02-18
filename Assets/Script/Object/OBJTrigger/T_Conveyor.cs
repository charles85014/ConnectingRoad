using UnityEngine;
using System.Collections;

public class T_Conveyor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "ConveyorTrigger")
        {
            this.transform.position += new Vector3(0.03f, 0, 0);
        }
     

    }
	// Update is called once per frame
	void Update () {
	
	}
}
