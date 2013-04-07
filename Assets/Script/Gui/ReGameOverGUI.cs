using UnityEngine;
using System.Collections;

public class ReGameOverGUI : MonoBehaviour {
    public AudioSource NormalButton;
    public ReGui ReGUIScore;
    public StageData stagedata;
    public GameObject endGuiplane;
    public float[] YScorepos = new float[6];
    public float[] HScorepos = new float[6];
    public float[] NextB = new float[6];
    public float[] BackTitleB = new float[6];
    public GUIStyle YScore,HScore,nextbs, backts;
    public int YScoreFontS, HScoreFontS;
	// Use this for initialization
	void Start () {
	
	}
    void OnGUI() {
        if (ReGUIScore.TimeCounter <= 0) {
            
            Time.timeScale = 0.00000001f;
            endGuiplane.gameObject.SetActive(true);
            if (ScoreRecord.Re_Score[stagedata.StageCount-1] < ReGUIScore.ReScore)
                ScoreRecord.Re_Score[stagedata.StageCount-1] = ReGUIScore.ReScore;
            GUI.Label(new Rect(Screen.width * YScorepos[0] / YScorepos[1], Screen.height * YScorepos[2] / YScorepos[3], Screen.height * YScorepos[4],
                Screen.height * YScorepos[5]), "你的分數：  " + ReGUIScore.ReScore.ToString(),YScore);
            YScore.fontSize = Screen.height / YScoreFontS;

            GUI.Label(new Rect(Screen.width * HScorepos[0] / HScorepos[1], Screen.height * HScorepos[2] / HScorepos[3], Screen.height * HScorepos[4],
                Screen.height * HScorepos[5]), "最高分數：  " + ScoreRecord.Re_Score[stagedata.StageCount-1],HScore);
            HScore.fontSize = Screen.height / HScoreFontS;

            if (GUI.Button(new Rect(Screen.width * NextB[0] / NextB[1], Screen.height * NextB[2] / NextB[3], Screen.height * NextB[4],
                 Screen.height * NextB[5]), "", nextbs))
            {
                if (stagedata.StageCount == 2)
                {
                    NormalButton.Play();
                    Application.LoadLevel("Start");
                }
                else
                {
                    NormalButton.Play();
                    Application.LoadLevel("R_0" + (stagedata.StageCount + 1));
                }
            }

            if (GUI.Button(new Rect(Screen.width * BackTitleB[0] / BackTitleB[1], Screen.height * BackTitleB[2] / BackTitleB[3], Screen.height * BackTitleB[4],
                Screen.height * BackTitleB[5]), "", backts))
            {
                NormalButton.Play();
                Application.LoadLevel("Start");
            }
                   
        }
    
    }
	// Update is called once per frame
	void Update () {
        
	}
}
