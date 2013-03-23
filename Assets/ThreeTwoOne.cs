using UnityEngine;
using System.Collections;

public class ThreeTwoOne : MonoBehaviour {
    public GameObject StageGUI;
    public GameObject CreatObj;
    public int CTWup, CTWdown, CTHup, CTHdown, CT_GH, CT_GW,CT_FontSize;
    public GUIStyle CTStyle;
    float TimeCount, CountBack;
	// Use this for initialization
	void Start () {
        TimeCount = 0;
        CountBack = 3;
        StageGUI.gameObject.SetActive(false);
        CreatObj.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
        if (!IsInvoking("")) { 
            
        }
	}
}
