using UnityEngine;
using System.Collections;

public class ReGui : MonoBehaviour {
    public int SWup,SWdown,SHup,SHdown,ScoreG_W,ScoreG_H,SWFontS;//����UI��m�B��ù��e�פ��l,�ù��e�פ���,�ù����פ��l,�ù����פ���,�K�ϼe��,�K�ϰ���,�r���j�p�ܼ�
    public int TWup,TWdown,THup,THdown,TimeG_W,TimeG_H,TWFontS;//�ɶ�UI��m�B��...�P�W
    public GUIStyle styleS,styleT;//����Style �ɶ�Style
    public float TimeCounter = 60;//�˼Ʈɶ�
    public int ReScore;
    public float ObjSpeed = 0.03f;
    public float ObjCreatRate = 3;
    public float MoreObjSpeed = 0.05f;
    public float MoreObjCreatRate = 2.3f;
    private ReScoreCounter[] ReSct;
    public GameObject[] ReRB; 
	// Use this for initialization
	void Start () {
        TimeCounter = 60;
        ReScore = 0;
        ReSct = new ReScoreCounter[ReRB.Length];
        this.ReSct[0] = ReRB[0].GetComponent<ReScoreCounter>();
        this.ReSct[1] = ReRB[1].GetComponent<ReScoreCounter>();
        this.ReSct[2] = ReRB[2].GetComponent<ReScoreCounter>();
	}
    void OnGUI() 
    {
        GUI.Label(new Rect(Screen.width * SWup / SWdown, Screen.height * SHup / SHdown, ScoreG_W, ScoreG_H), "���ơG" + " " + ReScore, this.styleS);
        GUI.Label(new Rect(Screen.width * TWup / TWdown, Screen.height * THup / THdown, TimeG_W, TimeG_H), TimeCounter.ToString("00"), this.styleT);
        styleS.fontSize = Screen.height / SWFontS;
        styleT.fontSize = Screen.height / TWFontS;
    }
	// Update is called once per frame
	void Update () {
        TimeCounter -= Time.deltaTime;
       // print(ReSCt_CD.RightCount  +""+  ReSCt_Paper.RightCount +""+  ReSCt_Battery.RightCount);
        ReScore = (ReSct[0].RightCount + ReSct[1].RightCount + ReSct[2].RightCount) * 50;
        if (TimeCounter < 20) {
            ObjSpeed = MoreObjSpeed;
            ObjCreatRate = MoreObjCreatRate;
        }
	}
}
