using UnityEngine;
using System.Collections;

public class DeadLine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "DeadLine")
        {
            Destroy(gameObject);
        }
      


    }
	// Update is called once per frame
	void Update () {
	
	}
}
