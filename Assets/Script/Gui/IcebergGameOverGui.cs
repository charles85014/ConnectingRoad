using UnityEngine;
using System.Collections;

public class IcebergGameOverGui : MonoBehaviour {
    public GameObject IceBergGuiObj;
    public IcebergGui IcebergGuiScore;
    public StageData stagedata;
    public GameObject endGuiPlane;
    public int PenguinDefeatCount;

    public int[] YRecordTextPos = new int[5];
    public int[] HRecordTextPos = new int[5];

    public int[] ScoreTextPos = new int[5];
    public int[] TimeTextPos = new int[5];

    public int[] YScorePos = new int[5];
    public int[] HScorePos = new int[5];

    public int[] YTimePos = new int[5];
    public int[] HTimePos = new int[5];//五個分別是位置的寬分子、分母，高分子、分母，字型大小常數

    public float[] NextB = new float[6];//六個分別是位置的寬分子、分母，高分子、分母，圖片寬高常數
    public float[] BackTitleB = new float[6];
    public GUIStyle TitleScore, YScore, HScore, nextbs, backts, scoreTextS;
	// Use this for initialization
	void Start () {
        IceBergGuiObj = GameObject.Find("IcebergGui");
        IcebergGuiScore = IceBergGuiObj.GetComponent<IcebergGui>();
	}
    void OnGUI()
    {
        if (PenguinDefeatCount <= -2)
        {
            
            Time.timeScale = 0;
            endGuiPlane.gameObject.SetActive(true);
            if (ScoreRecord.Ice_Score[stagedata.StageCount - 1] < IcebergGuiScore.IceScore)
                ScoreRecord.Ice_Score[stagedata.StageCount - 1] = IcebergGuiScore.IceScore;

            if (ScoreRecord.Ice_Time[stagedata.StageCount - 1] < IcebergGuiScore.I_TimeCounter)
                ScoreRecord.Ice_Time[stagedata.StageCount - 1] = (int)IcebergGuiScore.I_TimeCounter;

            GUI.Label(new Rect(Screen.width * YRecordTextPos[0] / YRecordTextPos[1], Screen.height * YRecordTextPos[2] / YRecordTextPos[3], 10,
                10), "你的紀錄", TitleScore);
            TitleScore.fontSize = Screen.height / (int)YRecordTextPos[4];

            GUI.Label(new Rect(Screen.width * HRecordTextPos[0] / HRecordTextPos[1], Screen.height * HRecordTextPos[2] / HRecordTextPos[3], 10,
                10), "最高紀錄", TitleScore);
            /////////////////////////////////////////////////////////////////

            GUI.Label(new Rect(Screen.width * ScoreTextPos[0] / ScoreTextPos[1], Screen.height * ScoreTextPos[2] / ScoreTextPos[3], 10,
                10), "分數：", scoreTextS);
            scoreTextS.fontSize = Screen.height / (int)ScoreTextPos[4];

            GUI.Label(new Rect(Screen.width * TimeTextPos[0] / TimeTextPos[1], Screen.height * TimeTextPos[2] / TimeTextPos[3], 10,
                10), "時間：", scoreTextS);

    
            //////////////////////////////////////////////////////////////////

            GUI.Label(new Rect(Screen.width * YScorePos[0] / YScorePos[1], Screen.height * YScorePos[2] / YScorePos[3], 10,
                10), IcebergGuiScore.IceScore.ToString(), YScore);
            YScore.fontSize = Screen.height / (int)YScorePos[4];

            GUI.Label(new Rect(Screen.width * YTimePos[0] / YTimePos[1], Screen.height * YTimePos[2] / YTimePos[3], 10,
                10), ((int)IcebergGuiScore.I_TimeCounter).ToString(), YScore);

    
            ////////////////////////////////////////////////////////////////////

            GUI.Label(new Rect(Screen.width * HScorePos[0] / HScorePos[1], Screen.height * HScorePos[2] / HScorePos[3], 10,
                10), ScoreRecord.Ice_Score[stagedata.StageCount - 1].ToString(), HScore);
            HScore.fontSize = Screen.height / (int)HScorePos[4];

            GUI.Label(new Rect(Screen.width * HTimePos[0] / HTimePos[1], Screen.height * HTimePos[2] / HTimePos[3], 10,
                10), ScoreRecord.Ice_Time[stagedata.StageCount - 1].ToString(), HScore);


            ///////////////////////////////////////////////////////////////////

            if (GUI.Button(new Rect(Screen.width * NextB[0] / NextB[1], Screen.height * NextB[2] / NextB[3], Screen.height * NextB[4],
                 Screen.height * NextB[5]), "", nextbs))
                Application.LoadLevel("Start");

            if (GUI.Button(new Rect(Screen.width * BackTitleB[0] / BackTitleB[1], Screen.height * BackTitleB[2] / BackTitleB[3], Screen.height * BackTitleB[4],
                Screen.height * BackTitleB[5]), "", backts))
                Application.LoadLevel("Start");

            IceBergGuiObj.GetComponent<IcebergGui>().enabled = false;
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
