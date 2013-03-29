using UnityEngine;
using System.Collections;

public class FruitCreat01 : MonoBehaviour {
    public GameObject BananaC, DurianC;
    public MonkeyGui FruitRate;
    public int BFcolumn, BFrow;//�������B��
    public int DFcolumn, DFrow;//�h�Ѫ��B��
    public float[] Bananai, Bananaj, BananajTwo;//���G�X�{����m�Ai����ءAi=0��j�����ءAi=1��J���C��
    public float[] Duriani, Durianj, DurianjTwo;//���G�X�{����m�Ai����ءAi=0��j�����ءAi=1��J���C��
	// Use this for initialization
	void Start () {
        FruitRate = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();
	}
    void creatBanana() { 
        BFcolumn = Random.Range(0,2);
       
        if(BFcolumn == 0){
            BFrow = Random.Range(0,5);
            Instantiate(BananaC, new Vector3(Bananai[BFcolumn], 6.5f + BFrow / 100, Bananaj[BFrow]),BananaC.transform.rotation);
        }
        else if (BFcolumn == 1) {
            BFrow = Random.Range(0, 7);
            Instantiate(BananaC, new Vector3(Bananai[BFcolumn], 6.5f + BFrow / 100, BananajTwo[BFrow]), BananaC.transform.rotation);
        }
    }
    void creatDurian()
    {
        DFcolumn = Random.Range(0, 2);
        if (DFcolumn == 0)
        {
            DFrow = Random.Range(0, 5);
            Instantiate(DurianC, new Vector3(Duriani[DFcolumn], 6.5f + DFrow / 100, Durianj[DFrow]), DurianC.transform.rotation);
        }
        else if (DFcolumn == 1)
        {
            DFrow = Random.Range(0, 7);
            Instantiate(DurianC, new Vector3(Duriani[DFcolumn], 6.5f + DFrow / 100, DurianjTwo[DFrow]), DurianC.transform.rotation);
        }
    }
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("creatBanana")) {
            Invoke("creatBanana", FruitRate.BanaCreatRate);
        }
        if (!IsInvoking("creatDurian"))
        {
            Invoke("creatDurian", FruitRate.DuriCreatRate);
        }
	}
}
