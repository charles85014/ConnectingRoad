using UnityEngine;
using System.Collections;

public class StartGUI : MonoBehaviour {
 
    public GUIStyle StartS, ExitS, BackS, RecycleS, MonkeyS, IcebergS;
    public int ChangGUI=0;
    public float T1w_up, T1w_down, T1h_up, T1h_down;
    public float T2w_up, T2w_down, T2h_up, T2h_down;
    public float T3w_up, T3w_down, T3h_up, T3h_down;
    public float T4w_up, T4w_down, T4h_up, T4h_down;
    public float T5w_up, T5w_down, T5h_up, T5h_down;
    public float T6w_up, T6w_down, T6h_up, T6h_down;
    public float S1_w, S1_h, S2_w, S2_h;
	// Use this for initialization
	void Start () {
        ChangGUI = 0;
	}
    void OnGUI() {
        if (ChangGUI == 0)
        {
            if (GUI.Button(new Rect(Screen.width * T1w_up / T1w_down,Screen.height * T1h_up / T1h_down,Screen.width * S1_w,Screen.height * S1_h),"",StartS))
            {
                ChangGUI = 1;
            }
            if (GUI.Button(new Rect(Screen.width * T2w_up / T2w_down, Screen.height * T2h_up / T2h_down,Screen.width * S1_w,Screen.height * S1_h),"",ExitS))
            {
                Application.Quit();
            }
        }
        if (ChangGUI == 1) {
            if (GUI.Button(new Rect(Screen.width * T3w_up / T3w_down, Screen.height * T3h_up / T3h_down, Screen.width * S1_w, Screen.height * S1_h),"",BackS))
            {
                ChangGUI = 0;
            }
            if (GUI.Button(new Rect(Screen.width * T4w_up / T4w_down, Screen.height * T4h_up / T4h_down, Screen.width * S2_w, Screen.height * S2_h),"",RecycleS))
            {
                Application.LoadLevel("R_Two01");
            }
            if (GUI.Button(new Rect(Screen.width * T5w_up / T5w_down, Screen.height * T5h_up / T5h_down, Screen.width * S2_w, Screen.height * S2_h),"",MonkeyS))
            {
                
            }
            if (GUI.Button(new Rect(Screen.width * T6w_up / T6w_down, Screen.height * T6h_up / T6h_down, Screen.width * S2_w, Screen.height * S2_h),"",IcebergS))
            {
                
            }
        }
        
    }
	// Update is called once per frame
	void Update () {
	
	}
}