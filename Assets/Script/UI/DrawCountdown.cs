using UnityEngine;
using System.Collections;

/// <summary>
/// UI�]�p-ø�s�˼ƭp�ɹ�
/// </summary>
public class DrawCountdown : MonoBehaviour
{
    public GameManager.GameValue WhichGameValue;    //��GameManager����
    public Color color;                 //����
    public int GUIdepth;                //�K�ϲ`��(�ȶV�p�V��e)
    public Texture[] TextureResoure;    //�K�ϯ���
    public Vector2 TexturePosition;     //�K�Ϧ�m
    public GUIStyle TextureStyle;       //�K��style

    private int number;       //�ƭ���r��
    private int currentNumber = -1;
    void Start()
    {
    }

    void Update()
    {

    }

    void OnGUI()
    {
        if (GameManager.TotalTime < 4)
        {
            this.number = GameManager.GetGameValue(this.WhichGameValue);
            if (this.currentNumber != this.number)
            {
                this.animation.Stop();
                this.animation.Play();
                this.currentNumber = this.number;
            }

            GUI.color = color;
            GUI.depth = this.GUIdepth;

            GUI.Box(new Rect((this.TexturePosition.x - (this.TextureResoure[this.number].width / 2)) * GameManager.WidthOffset,
                            (this.TexturePosition.y - (this.TextureResoure[this.number].height / 2)) * GameManager.HeightOffset,
                            this.TextureResoure[this.number].width * GameManager.WidthOffset,
                            this.TextureResoure[this.number].height * GameManager.HeightOffset),
                        this.TextureResoure[this.number],
                        this.TextureStyle);
        }
    }
}