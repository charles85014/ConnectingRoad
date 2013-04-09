using UnityEngine;
using System.Collections;

/// <summary>
/// UI�]�p-ø�s�i�۩w�q�Ϥ���Number list
/// </summary>
public class DrawCustomNumber : MonoBehaviour
{
    public Vector2 scale = new Vector2(1, 1);
    public Vector2 pivotPoint;

    public GameManager.GameValue WhichGameValue;    //��GameManager����
    public Color color;                 //����
    public int GUIdepth;                //�K�ϲ`��(�ȶV�p�V��e)
    public Texture[] TextureResoure;    //�K�ϯ���
    public Vector2 TexturePosition;     //�K�Ϧ�m
    public GUIStyle TextureStyle;       //�K��style

    private string numberToString;       //�ƭ���r��
    private Vector2 textureSize;        //�K�Ϥؤo
    void Start()
    {
        this.textureSize = new Vector2(this.TextureResoure[0].width, this.TextureResoure[0].height);
    }

    void Update()
    {
        this.numberToString = GameManager.GetGameValue(this.WhichGameValue).ToString();
    }

    void OnGUI()
    {
        GUI.color = color;
        GUI.depth = this.GUIdepth;

        GUIUtility.ScaleAroundPivot(this.scale, this.pivotPoint);

        for (int i = 0; i < this.numberToString.Length; i++)
        {
            GUI.Box(new Rect((this.TexturePosition.x + (this.textureSize.x) * i) * GameManager.WidthOffset,
                        this.TexturePosition.y * GameManager.HeightOffset,
                        this.textureSize.x * GameManager.WidthOffset,
                        this.textureSize.y * GameManager.HeightOffset),
                    this.TextureResoure[int.Parse(this.numberToString[i].ToString())],
                    this.TextureStyle);
        }

        GUIUtility.ScaleAroundPivot(new Vector2(1,1), this.pivotPoint);
    }
}