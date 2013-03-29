using UnityEngine;
using System.Collections;

public class MonkeyCreat01 : MonoBehaviour {
    public GameObject MonkeyCreat;
    public MonkeyGui MonkeyCreatRate;
    int MonkeyZ;
	// Use this for initialization
	void Start () {
        MonkeyCreatRate = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();
	}
    void CreatMonkey() { 
        MonkeyZ = Random.Range(-6,2);
        Instantiate(MonkeyCreat, new Vector3(-17, 9.5f, MonkeyZ), MonkeyCreat.transform.rotation);
    
    }
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("CreatMonkey")) {
            Invoke("CreatMonkey", MonkeyCreatRate.MonkeyCreatRate);
        }
	}
}
