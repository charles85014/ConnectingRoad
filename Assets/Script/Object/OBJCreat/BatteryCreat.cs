using UnityEngine;
using System.Collections;

public class BatteryCreat : MonoBehaviour {

   public Transform Battery;
    float i = 0;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        i = i +  Time.deltaTime;
      
        if (i >= 3)
        {
            print("GGG");
            Instantiate(Battery, new Vector3(this.transform.position.x,this.transform.position.y - 1,this.transform.position.z), Battery.transform.rotation);
            i = 0;
        }
	}
}
