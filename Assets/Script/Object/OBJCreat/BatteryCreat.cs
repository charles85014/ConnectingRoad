using UnityEngine;
using System.Collections;

public class BatteryCreat : MonoBehaviour {

   public GameObject[] ObjCreat;
   public float Xseat;
   public float Yseat;
   public float[] Zseat;
   private float OBJCTime=2;
    int i = 0 , j = 0; // random number

	// Use this for initialization
	void Start () {
        
	}
    void CreatOBJ()
    {
        i = Random.Range(0, ObjCreat.Length);//Object random
        j = Random.Range(0, Zseat.Length);//Seat random
        print(ObjCreat[i]);
        Instantiate(ObjCreat[i], new Vector3(Xseat, Yseat - 1, Zseat[j]), ObjCreat[i].transform.rotation);
    }
	// Update is called once per frame
	void Update () {
        
        
      
        if (!IsInvoking("CreatOBJ"))
        {
            Invoke("CreatOBJ", OBJCTime);      
        }
	}
}
