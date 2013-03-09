using UnityEngine;
using System.Collections;

public class ReGui : MonoBehaviour {
    public int SWup,SWdown,SHup,SHdown,ScoreG_W,ScoreG_H,SWFontS;//分數UI位置處於螢幕寬度分子,螢幕寬度分母,螢幕高度分子,螢幕高度分母,貼圖寬度,貼圖高度,字型大小變數
    public int TWup,TWdown,THup,THdown,TimeG_W,TimeG_H,TWFontS;//時間UI位置處於...同上
    public GUIStyle styleS,styleT;//分數Style 時間Style
    public float TimeCounter = 60;//倒數時間
    public int ReScore;
    private ReScoreCounter ReSCt_CD,ReSCt_Paper,ReSCt_Battery;
	// Use this for initialization
	void Start () {
        TimeCounter = 60;
        ReScore = 0;
        this.ReSCt_CD = GameObject.Find("CD_RB").GetComponent<ReScoreCounter>();
        this.ReSCt_Paper = GameObject.Find("PaperRB").GetComponent<ReScoreCounter>();
        this.ReSCt_Battery = GameObject.Find("BatteryRB").GetComponent<ReScoreCounter>();
	}
    void OnGUI() 
    {
        GUI.Label(new Rect(Screen.width * SWup / SWdown, Screen.height * SHup / SHdown, ScoreG_W, ScoreG_H), "分數：" + " " + ReScore, this.styleS);
        GUI.Label(new Rect(Screen.width * TWup / TWdown, Screen.height * THup / THdown, TimeG_W, TimeG_H), TimeCounter.ToString("00"), this.styleT);
        styleS.fontSize = Screen.height / SWFontS;
        styleT.fontSize = Screen.height / TWFontS;
    }
	// Update is called once per frame
	void Update () {
        TimeCounter -= Time.deltaTime;
       // print(ReSCt_CD.RightCount  +""+  ReSCt_Paper.RightCount +""+  ReSCt_Battery.RightCount);
        ReScore = (ReSCt_CD.RightCount + ReSCt_Battery.RightCount + ReSCt_Paper.RightCount) * 50;

	}
}
