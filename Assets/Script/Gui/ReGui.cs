using UnityEngine;
using System.Collections;

public class ReGui : MonoBehaviour {
    public int ScoreG_X,ScoreG_Y,ScoreG_W,ScoreG_H;
    public int TimeG_X, TimeG_Y, TimeG_W, TimeG_H;
    public GUIStyle styleS,styleT;
    public float TimeCounter = 60;
    private int ReScore;
	// Use this for initialization
	void Start () {
	
	}
    void OnGUI() 
    {   
        GUI.Label(new Rect(ScoreG_X, ScoreG_Y, ScoreG_W, ScoreG_H), "¤À¼Æ¡G" + " " + ReScore,styleS);
        GUI.Label(new Rect(TimeG_X, TimeG_Y, TimeG_W, TimeG_H), TimeCounter.ToString("00.00"), styleT);
    }
	// Update is called once per frame
	void Update () {
        TimeCounter -= Time.deltaTime;
	}
}
