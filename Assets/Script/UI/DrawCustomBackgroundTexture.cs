using UnityEngine;
using System.Collections;

/// <summary>
/// UI�]�p-ø�s�@�i�۩w�q���K�ϯ���(�I���M��-����)
/// </summary>
public class DrawCustomBackgroundTexture : MonoBehaviour
{
    public Color color;                 //����
    public int GUIdepth;                //�K�ϲ`��(�ȶV�p�V��e)
    public Texture BackgroundTexture;   //�K�ϯ���

    void OnGUI()
    {
        if (this.BackgroundTexture != null)
        {
            GUI.color = color;
            GUI.depth = this.GUIdepth;
            GUI.DrawTexture(
                new Rect(0, 0, Screen.width, Screen.height),
                this.BackgroundTexture,
                ScaleMode.StretchToFill);
        }
    }
}
