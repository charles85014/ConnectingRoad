using UnityEngine;
using System.Collections;

public class IcebergGui : MonoBehaviour {
    public AudioSource ChangeRateAudio;
    public int[] IceScorePos = new int[5];
    public int[] IceTimePos = new int[5];
    public int[] IcePenguinCountPos = new int[5];
    public GUIStyle IceScoreStyle, IceTimeStyle, IcePenguinCountStyle;
    public float I_TimeCounter;
    public int IceScore;
    public int PenguinCounter;
    public float IceRoadRate,RateRange;
    public int PenguinCount01, PenguinCount02;
    public int Penguin01_ScoreRange, Penguin02_ScoreRange;
    public float TrapCreatRate,TrapCreatRateRange;
	// Use this for initialization
	void Start () {
        I_TimeCounter = 0;
        IceScore = 0;
        PenguinCounter = 3;
        PenguinCount01 = 0;
        PenguinCount02 = 0;
        Penguin01_ScoreRange = 10;
        Penguin02_ScoreRange = 15;
	}
    void RateRangeChamg() {
        ChangeRateAudio.Play();
        IceRoadRate += RateRange;
        TrapCreatRate -= TrapCreatRateRange;
        RateRange /= 2;
        TrapCreatRateRange /= 2;
        Penguin01_ScoreRange += 10;
        Penguin02_ScoreRange += 15;
        
    }
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width * IceScorePos[0] / IceScorePos[1], Screen.height * IceScorePos[2] / IceScorePos[3],
            10, 10), "¤À¼Æ¡G" + IceScore, this.IceScoreStyle);
        this.IceScoreStyle.fontSize = Screen.height / IceScorePos[4];

        GUI.Label(new Rect(Screen.width * IceTimePos[0] / IceTimePos[1], Screen.height * IceTimePos[2] / IceTimePos[3],
            10, 10), I_TimeCounter.ToString("0000"), this.IceTimeStyle);
        this.IceTimeStyle.fontSize = Screen.height / IceTimePos[4];

        GUI.Label(new Rect(Screen.width * IcePenguinCountPos[0] / IcePenguinCountPos[1], Screen.height * IcePenguinCountPos[2] / IcePenguinCountPos[3],
            10, 10), "x " + PenguinCounter, this.IcePenguinCountStyle);
        this.IcePenguinCountStyle.fontSize = Screen.height / IcePenguinCountPos[4];

        

    }
	// Update is called once per frame
	void Update () {
        I_TimeCounter += Time.deltaTime;
        IceScore = PenguinCount01 * Penguin01_ScoreRange + PenguinCount02 * Penguin02_ScoreRange;
        if (!IsInvoking("RateRangeChamg")) {
            Invoke("RateRangeChamg", 20);
        }
	}
}
