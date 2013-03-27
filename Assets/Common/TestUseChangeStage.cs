using UnityEngine;
using System.Collections;

public class TestUseChangeStage : MonoBehaviour {
    public StageData stage_data;
    public GUIStyle TUCS_Title, TUCS_Next;
	// Use this for initialization
	void Start () {
	
	}
    void OnGUI() {
        if (stage_data.Stage_name == 0)
        {
            if (GUI.Button(new Rect(Screen.width - 200, Screen.height - 100, 100, 40),"",TUCS_Title))
                Application.LoadLevel("Start");
            if (GUI.Button(new Rect(Screen.width - 100, Screen.height - 100, 100, 40),"",TUCS_Next)) {
                if (stage_data.StageCount == 1)
                    Application.LoadLevel("Start");
            }
        }
        else {
            if(GUI.Button(new Rect(Screen.width - 200, Screen.height - 200, 100, 40), "",TUCS_Title))
                Application.LoadLevel("Start");
        }
        
    }
	// Update is called once per frame
	void Update () {
	
	}
}
