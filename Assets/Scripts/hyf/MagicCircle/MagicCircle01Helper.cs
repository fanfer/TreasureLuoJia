using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCircle01Helper : MonoBehaviour
{
    public MagicCircle02 magicCircle;
    public bridgeController[] bridge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //在魔法阵附近并且触发J
    public void OnTriggerStay(Collider other)
    {
        print("the helper is triggered! ");
        if (Input.GetKeyDown(KeyCode.J))
        {
            magicCircle.SendMessage("psPlay");
            for (int i = 0; i < bridge.Length; i++)
            {
                bridge[i].SendMessage("recover");
            }
        }
    }
}
