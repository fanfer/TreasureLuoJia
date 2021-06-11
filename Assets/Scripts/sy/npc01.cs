using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc01 : MonoBehaviour
{
    /*
    public Texture img1;
    public Texture img2;
    public Texture img3;
    public Texture img4;
    public Texture img5;

    */
    public GUIStyle style;

    public AudioSource audio;
    public AudioSource audio_message;
    public bool can_talk = false;
    public int count = 0;
    public bool ins = false;
    
    // Start is called before the first frame update
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
                count++;
                if (count <= 4)
                {
                    audio_message.Play();
                }
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
            audio.Play();
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
            if (ins == true&&count==0)
            {
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 500, 300), "Press the T key",style);

                
            }

            if (count == 1)
            {
                ins = false;
                //audio_message.Play();
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "欢迎你whuer来到珞珈虚拟世界  伴whuer一程，三生有幸",style);
            }
            if (count == 2)
            {
                //audio_message.Play();
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "whuer可以通过关卡，集齐whu碎片，达成成就哦", style);
            }
            if (count == 3)
            {
                //audio_message.Play();
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "途中如果遇到我的朋友，请尽情去撩，它会帮助你", style);
            }
            if (count == 4)
            {
               // audio_message.Play();
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "出发吧，whuer!", style);
            }
        }

    }
}
