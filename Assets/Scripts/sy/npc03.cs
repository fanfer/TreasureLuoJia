using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc03 : MonoBehaviour
{
    public bool can_talk;
    public int count = 0;
    public GUIStyle style;
    public AudioSource audio_message;
    // Start is called before the first frame update
    void Start()
    {
        style.fontSize = 20;
        style.normal.textColor = new Color(255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (can_talk == true)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (count <= 4)
                {
                    audio_message.Play();
                }
                count++;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "unitychan")
        {
            can_talk = true;
            Debug.Log("OnCollisionEnter碰撞触发");
        }
    }



    void OnGUI()

    {

        if (can_talk)

        {
            

            if (count == 1)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "你好，whuer", style);
            if (count == 2)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "我是珞珈虚拟世界的珈珈", style);
            if (count == 3)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "珞珞如玉，珈珈如石，是为珞珈", style);
            if (count == 4)
            {
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "不知道whuer的碎片有没有收集成功呢？", style);
            }
            /*
            if (count == 5)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "恭喜whuer又收获新的碎片！");
            if (count == 6)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "哦对了，不要放过遇见过的魔法阵哦，去找找新发现吧");
            */
        }

    }
}


