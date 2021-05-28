using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc01 : MonoBehaviour
{
    public bool can_talk = false;
    public int count = 0;
    public bool ins = false;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (can_talk == true)
        {
            if (Input.GetKeyDown(KeyCode.T))
                {
                count++;
                ins = false;
                }
        }
    }


    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "unitychan")
        {
            can_talk = true;
            Debug.Log("OnCollisionEnter碰撞触发");
            ins=true;
          
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "unitychan")
        {
            can_talk = true;
            Debug.Log("OnTriggerEnter碰撞触发");
        }
    }

    void OnGUI()

    {

        if (can_talk)

        {
            if (ins == true)
            {
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "Press T to talk with me");
                
            }
              
            if (count==1)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "欢迎你whuer来到珞珈虚拟世界  伴whuer一程，三生有幸");
             if(count==2)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "whuer可以通过关卡，集齐whu碎片，达成成就哦");
            if (count == 3)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "途中如果遇到我的朋友，请尽情去撩，它会帮助你");
             if (count == 4)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "出发吧，whuer!");
        }

    }
}
