using UnityEngine;
using System.Collections;

public class StartBGM : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<AudioSource>().Play();
	}

  
	// Update is called once per frame
	void Update () {
   
	}
}
