using UnityEngine;
using System.Collections;
using Phidgets;
public class R_Stage1MoveControl : MonoBehaviour {
    public GameObject[] MoveConveyor;
    InterfaceKit ifKit;
    public float[] phidgetvalue;
    // Use this for initialization
    void Start()
    {
        ifKit = new InterfaceKit();
        ifKit.open();
        ifKit.waitForAttachment(1000);

    }

    // Update is called once per frame
    void Update()
    {
        if (ifKit != null)
        {
            phidgetvalue[0] = ifKit.sensors[0].Value;
            phidgetvalue[1] = ifKit.sensors[3].Value;
        }
        MoveConveyor[0].transform.position = new Vector3(MoveConveyor[0].transform.position.x, MoveConveyor[0].transform.position.y, 2.75f - phidgetvalue[0] / 999 * 7.75f);
        MoveConveyor[1].transform.position = new Vector3(MoveConveyor[1].transform.position.x, MoveConveyor[1].transform.position.y, 2.75f - phidgetvalue[1] / 999 * 7.75f);
    }
    void OnDisable()
    {
        this.ifKit.close();
    }
}
