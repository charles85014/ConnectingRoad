using UnityEngine;
using System.Collections;

public class MonkeyGameOverGui : MonoBehaviour {
    public AudioSource NormalButton;
    public MonkeyGui MonGuiScore;
    public StageData stagedata;
    public GameObject endGuiPlane;
    public float[] YMScore = new float[5];
    public float[] YMScoreText = new float[5];

    public float[] HMScore = new float[5];
    public float[] HMScoreText = new float[5];

    public float[] YBananaCounter = new float[5];
    public float[] YDurianCounter = new float[5];

    public float[] HBananaCounter = new float[5];
    public float[] HDurianCounter = new float[5];

    public float[] ScoreText = new float[5];//五個分別是位置的寬分子、分母，高分子、分母，字型大小常數

    public float[] NextB = new float[6];//六個分別是位置的寬分子、分母，高分子、分母，圖片寬高常數
    public float[] BackTitleB = new float[6];
    public GUIStyle TitleScore, YScore, HScore, nextbs, backts,scoreTextS;
	// Use this for initialization
	void Start () {
	
	}
    void OnGUI()
    {
        if (MonGuiScore.M_TimeCounter <= 0)
        {

            Time.timeScale = 0.00000001f;
            endGuiPlane.gameObject.SetActive(true);
            if (ScoreRecord.Mo_Score[stagedata.StageCount - 1] < MonGuiScore.M_Score)
                ScoreRecord.Mo_Score[stagedata.StageCount - 1] = MonGuiScore.M_Score;

            if (ScoreRecord.Mo_BananaC[stagedata.StageCount - 1] < MonGuiScore.Banana_Counter)
                ScoreRecord.Mo_BananaC[stagedata.StageCount - 1] = MonGuiScore.Banana_Counter;

            if (ScoreRecord.Mo_DurianC[stagedata.StageCount - 1] < MonGuiScore.Durian_Counter)
                ScoreRecord.Mo_DurianC[stagedata.StageCount - 1] = MonGuiScore.Durian_Counter;

            GUI.Label(new Rect(Screen.width * YMScoreText[0] / YMScoreText[1], Screen.height * YMScoreText[2] / YMScoreText[3], 10,
                10), "你的紀錄", TitleScore);
            TitleScore.fontSize = Screen.height / (int)YMScoreText[4];

            GUI.Label(new Rect(Screen.width * HMScoreText[0] / HMScoreText[1], Screen.height * HMScoreText[2] / HMScoreText[3], 10,
                10), "最高紀錄", TitleScore);
            /////////////////////////////////////////////////////////////////

            GUI.Label(new Rect(Screen.width * YMScore[0] / YMScore[1], Screen.height * YMScore[2] / YMScore[3], 10,
                10), MonGuiScore.M_Score.ToString(), YScore);
            YScore.fontSize = Screen.height / (int)YMScore[4];

            GUI.Label(new Rect(Screen.width * YBananaCounter[0] / YBananaCounter[1], Screen.height * YBananaCounter[2] / YBananaCounter[3], 10,
                10), MonGuiScore.Banana_Counter.ToString(), YScore);

            GUI.Label(new Rect(Screen.width * YDurianCounter[0] / YDurianCounter[1], Screen.height * YDurianCounter[2] / YDurianCounter[3], 10,
                10), MonGuiScore.Durian_Counter.ToString(), YScore);
            //////////////////////////////////////////////////////////////////

            GUI.Label(new Rect(Screen.width * HMScore[0] / HMScore[1], Screen.height * HMScore[2] / HMScore[3], 10,
                10), ScoreRecord.Mo_Score[stagedata.StageCount-1].ToString(), HScore);
            HScore.fontSize = Screen.height / (int)HMScore[4];

            GUI.Label(new Rect(Screen.width * HBananaCounter[0] / HBananaCounter[1], Screen.height * HBananaCounter[2] / HBananaCounter[3], 10,
                10), ScoreRecord.Mo_BananaC[stagedata.StageCount - 1].ToString(), HScore);

            GUI.Label(new Rect(Screen.width * HDurianCounter[0] / HDurianCounter[1], Screen.height * HDurianCounter[2] / HDurianCounter[3], 10,
                10), ScoreRecord.Mo_DurianC[stagedata.StageCount - 1].ToString(), HScore);
            ////////////////////////////////////////////////////////////////////

            GUI.Label(new Rect(Screen.width * ScoreText[0] / ScoreText[1], Screen.height * ScoreText[2] / ScoreText[3], 10,
                10), "分數：", scoreTextS);
            scoreTextS.fontSize = Screen.height / (int)ScoreText[4];

            if (GUI.Button(new Rect(Screen.width * NextB[0] / NextB[1], Screen.height * NextB[2] / NextB[3], Screen.height * NextB[4],
                 Screen.height * NextB[5]), "", nextbs))
            {
                NormalButton.Play();
                Application.LoadLevel("Monkey01");
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
