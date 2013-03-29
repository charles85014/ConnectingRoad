using UnityEngine;
using System.Collections;

public class MonPicChangTrigger : MonoBehaviour {
    public MonkeyGui FruitCount;
	// Use this for initialization
	void Start () {
        FruitCount = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Banana(Clone)")
        {
            FruitCount.Banana_Counter++;
         
            Destroy(other.gameObject);
            this.gameObject.GetComponent<NPicChang>().enabled = false;
            this.gameObject.GetComponent<DPicChang>().enabled = false;
            this.gameObject.GetComponent<BPicChang>().enabled = true;
        }
        else if (other.gameObject.name == "Durian(Clone)")
        {
            FruitCount.Durian_Counter++;
           
            Destroy(other.gameObject);
            this.gameObject.GetComponent<NPicChang>().enabled = false;
            this.gameObject.GetComponent<BPicChang>().enabled = false;
            this.gameObject.GetComponent<DPicChang>().enabled = true;
        }
        if (other.gameObject.name == "MonkeyPassRoad") {
            FruitCount.MonkeyPass_Counter++;
            Destroy(this.gameObject);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
