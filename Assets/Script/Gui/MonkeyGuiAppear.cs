using UnityEngine;
using System.Collections;

public class MonkeyGuiAppear : MonoBehaviour {
    public GameObject MonGui_Value;
    public float MonWidth, MonHeight;

    public Texture[] TextureResoure_Time;    //�K�ϯ���
    public Vector2 TexturePosition_Time;     //�K�Ϧ�m

    public Texture[] TextureResoure_Score;    //�K�ϯ���
    public Vector2 TexturePosition_Score;     //�K�Ϧ�m

    public Vector2 TexturePosition_Banana;     //�K�Ϧ�m
    public Vector2 TexturePosition_Durian;     //�K�Ϧ�m

    public GUIStyle TextureStyle;       //�K��style

    public Vector2 scale_Time = new Vector2(1, 1);
    public Vector2 scale_Score = new Vector2(1, 1);
    public Vector2 scale_Fruit = new Vector2(1, 1);
    public Vector2 pivotPoint;

    private string numberToString_Time;       //�ƭ���r��
    private string numberToString_Score;       //�ƭ���r��
    private string numberToString_Banana;       //�ƭ���r��
    private string numberToString_Durian;       //�ƭ���r��
    private Vector2 textureSize;        //�K�Ϥؤo
	// Use this for initialization
	void Start () {
        this.textureSize = new Vector2(this.TextureResoure_Time[0].width, this.TextureResoure_Time[0].height);
        MonWidth = Screen.width / 1280.0f;
        MonHeight = Screen.height / 800.0f;
        this.numberToString_Banana = MonGui_Value.GetComponent<MonkeyGui>().Banana_Counter.ToString();
        this.numberToString_Durian = MonGui_Value.GetComponent<MonkeyGui>().Durian_Counter.ToString();
        this.numberToString_Score = MonGui_Value.GetComponent<MonkeyGui>().M_Score.ToString();
        this.numberToString_Time = MonGui_Value.GetComponent<MonkeyGui>().M_TimeCounter.ToString("00");
	}
	
	// Update is called once per frame
	void Update () {
        MonWidth = Screen.width / 1280.0f;
        MonHeight = Screen.height / 800.0f;
        MonGui_Value.GetComponent<MonkeyGui>().TimeCheck_Mon = true;
        this.numberToString_Banana = MonGui_Value.GetComponent<MonkeyGui>().Banana_Counter.ToString();
        this.numberToString_Durian = MonGui_Value.GetComponent<MonkeyGui>().Durian_Counter.ToString();
        this.numberToString_Score = MonGui_Value.GetComponent<MonkeyGui>().M_Score.ToString();
        this.numberToString_Time = MonGui_Value.GetComponent<MonkeyGui>().M_TimeCounter.ToString("00");
	}
    void OnGUI()
    {

        GUIUtility.ScaleAroundPivot(this.scale_Score, this.pivotPoint);

        for (int j = 0; j < this.numberToString_Score.Length; j++)
        {
            GUI.Box(new Rect((this.TexturePosition_Score.x + (this.textureSize.x) * j) * MonWidth,
                        this.TexturePosition_Score.y * MonHeight,
                        this.textureSize.x * MonWidth,
                        this.textureSize.y * MonHeight),
                    this.TextureResoure_Score[int.Parse(this.numberToString_Score[j].ToString())],
                    this.TextureStyle);
        }

        GUIUtility.ScaleAroundPivot(this.scale_Fruit, this.pivotPoint);

        for (int k = 0; k < this.numberToString_Banana.Length; k++)
        {
            GUI.Box(new Rect((this.TexturePosition_Banana.x + (this.textureSize.x) * k) * MonWidth,
                        this.TexturePosition_Banana.y * MonHeight,
                        this.textureSize.x * MonWidth,
                        this.textureSize.y * MonHeight),
                    this.TextureResoure_Time[int.Parse(this.numberToString_Banana[k].ToString())],
                    this.TextureStyle);

        }

        for (int u = 0; u < this.numberToString_Durian.Length; u++)
        {
            GUI.Box(new Rect((this.TexturePosition_Durian.x + (this.textureSize.x) * u) * MonWidth,
                        this.TexturePosition_Durian.y * MonHeight,
                        this.textureSize.x * MonWidth,
                        this.textureSize.y * MonHeight),
                    this.TextureResoure_Time[int.Parse(this.numberToString_Durian[u].ToString())],
                    this.TextureStyle);

        }


        GUIUtility.ScaleAroundPivot(this.scale_Time, this.pivotPoint);

        for (int i = 0; i < this.numberToString_Time.Length; i++)
        {
            GUI.Box(new Rect((this.TexturePosition_Time.x + (this.textureSize.x) * i) * MonWidth,
                        this.TexturePosition_Time.y * MonHeight,
                        this.textureSize.x * MonWidth,
                        this.textureSize.y * MonHeight),
                    this.TextureResoure_Time[int.Parse(this.numberToString_Time[i].ToString())],
                    this.TextureStyle);

        }


    }
}
