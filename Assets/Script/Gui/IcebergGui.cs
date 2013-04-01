using UnityEngine;
using System.Collections;

public class IcebergGui : MonoBehaviour {
    public int[] IceScorePos = new int[5];
    public int[] IceTimePos = new int[5];
    public int[] IcePenguinCountPos = new int[5];
    public GUIStyle IceScoreStyle, IceTimeStyle, IcePenguinCountStyle;
    public float I_TimeCounter;
    public int IceScore;
    public int PenguinCounter;
    public float IceRoadRate;
    public int PenguinCount01, PenguinCount02;
	// Use this for initialization
	void Start () {
        I_TimeCounter = 0;
        IceScore = 0;
        PenguinCounter = 3;
        PenguinCount01 = 0;
        PenguinCount02 = 0;
	}
	
	// Update is called once per frame
	void Update () {
        I_TimeCounter += Time.deltaTime;
        IceScore = PenguinCount01 * 10 + PenguinCount02 * 15;

	}
}
