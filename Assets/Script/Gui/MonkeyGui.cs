using UnityEngine;
using System.Collections;

public class MonkeyGui : MonoBehaviour {
    public int[] MonkeyScore = new int[7];
    public int[] MonkeyTime = new int[7];
    public int[] BananaCount = new int[7];
    public int[] DurianCount = new int[7];
    public GUIStyle MonScore, MonTime, BananaS, DurianS;
    public float M_TimeCounter;
    public int M_Score;
    public int Banana_Counter, Durian_Counter, MonkeyPass_Counter;
    public float MonkeyChangPic, MoreMonkeyChangPic;
    public float MonkeySpeed,MoreMonkeySpeed;
    public float MonkeyCreatRate, MoreMonkeyCreatRate;
    public float BanaCreatRate, MoreBanaCreatRate;
    public float DuriCreatRate, MoreDuriCreatRate;
    
	// Use this for initialization
	void Start () {
        M_TimeCounter = 60;
        M_Score = 0;
        Banana_Counter = 0;
        Durian_Counter = 0;
        MonkeyPass_Counter = 0;
	}

    void OnGUI() {
        GUI.Label(new Rect(Screen.width * MonkeyScore[0] / MonkeyScore[1], Screen.height * MonkeyScore[2] / MonkeyScore[3],
            Screen.height / MonkeyScore[4], Screen.height / MonkeyScore[5]), "¤À¼Æ¡G" + M_Score, this.MonScore);
        this.MonScore.fontSize = Screen.height / MonkeyScore[6];

        GUI.Label(new Rect(Screen.width * MonkeyTime[0] / MonkeyTime[1], Screen.height * MonkeyTime[2] / MonkeyTime[3],
            Screen.height / MonkeyTime[4], Screen.height / MonkeyTime[5]), M_TimeCounter.ToString("00"), this.MonTime);
        this.MonTime.fontSize = Screen.height / MonkeyTime[6];

        GUI.Label(new Rect(Screen.width * BananaCount[0] / BananaCount[1], Screen.height * BananaCount[2] / BananaCount[3],
            Screen.height / BananaCount[4], Screen.height / BananaCount[5]), "x " + Banana_Counter, this.BananaS);
        this.BananaS.fontSize = Screen.height / BananaCount[6];

        GUI.Label(new Rect(Screen.width * DurianCount[0] / DurianCount[1], Screen.height * DurianCount[2] / DurianCount[3],
            Screen.height / DurianCount[4], Screen.height / DurianCount[5]), "x " + Durian_Counter, this.DurianS);
        this.DurianS.fontSize = Screen.height / DurianCount[6];

    }
	// Update is called once per frame
	void Update () {
        if (M_TimeCounter > 0)
            M_TimeCounter -= Time.deltaTime;
        if (M_TimeCounter < 20) {
            MonkeyChangPic = MoreMonkeyChangPic;
            MonkeySpeed = MoreMonkeySpeed;
            MonkeyCreatRate = MoreMonkeyCreatRate;
            BanaCreatRate = MoreBanaCreatRate;
            DuriCreatRate = MoreDuriCreatRate;
        
        }
        M_Score = Banana_Counter * 50 - Durian_Counter * 30 + MonkeyPass_Counter * 15;
	}
}
