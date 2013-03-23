using UnityEngine;
using System.Collections;

public class ReScoreCounter : MonoBehaviour {
    public GameObject[] ReOBJWrong;
    public GameObject ReOBJRight;
   
    public int RightCount;
    // Use this for initialization
    void Start()
    {
        RightCount = 0;

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == ReOBJWrong[0].name + "(Clone)" || other.gameObject.name == ReOBJWrong[1].name + "(Clone)")
            Destroy(other.gameObject);
        if (other.gameObject.name == ReOBJRight.name + "(Clone)")
        {
            RightCount ++;
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
