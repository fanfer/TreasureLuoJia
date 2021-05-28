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
            Debug.Log("OnCollisionEnter��ײ����");
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
            if (ins == true)
            {
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "Press T to talk with me");
                
            }
              
            if (count==1)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "��ӭ��whuer����������������  ��whuerһ�̣���������");
             if(count==2)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "whuer����ͨ���ؿ�������whu��Ƭ����ɳɾ�Ŷ");
            if (count == 3)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), ";����������ҵ����ѣ��뾡��ȥ�ã����������");
             if (count == 4)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "�����ɣ�whuer!");
        }

    }
}
