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
            Debug.Log("OnCollisionEnter��ײ����");
            audio.Play();
            ins=true;
          
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "unitychan")
        {
            can_talk = true;
            Debug.Log("OnTriggerEnter��ײ����");
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
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "��ӭ��whuer����������������  ��whuerһ�̣���������",style);
            }
            if (count == 2)
            {
                //audio_message.Play();
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "whuer����ͨ���ؿ�������whu��Ƭ����ɳɾ�Ŷ", style);
            }
            if (count == 3)
            {
                //audio_message.Play();
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), ";����������ҵ����ѣ��뾡��ȥ�ã����������", style);
            }
            if (count == 4)
            {
               // audio_message.Play();
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "�����ɣ�whuer!", style);
            }
        }

    }
}
