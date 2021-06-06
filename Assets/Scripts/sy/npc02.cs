using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc02 : MonoBehaviour
{
    public bool can_talk = false;
    public int count = 0;
    public GUIStyle style;

    //hyf:烟花
    public AudioSource AudioSource;
    public ParticleSystem fire1;
    public ParticleSystem fire2;

    public platformController platform;
    // Start is called before the first frame update
    void Start()
    {
        style.fontSize = 20;
        style.normal.textColor = new Color(255, 255, 255);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "unitychan")
        {
            can_talk = true;
            Debug.Log("OnCollisionEnter碰撞触发");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (can_talk == true)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                count++;
            }
        }

    }

    void OnGUI()

    {

        if (can_talk)

        {

            if (count == 1)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "你好，whuer",style);
            if (count == 2)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "听说，来武大看一次人海，是每朵樱花的梦想", style);
            if (count == 3)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "给whuer看一场烟花，是我的梦想", style);
            if (count == 6)
            {
                //烟花
                playFire();
                platform.SendMessage("characterPressT");

                //捡碎片
            }
            if (count == 4)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "恭喜whuer又收获新的碎片！", style);
            if (count == 5)
                GUI.Label(new Rect(Screen.width * 0.52f, (float)(Screen.height * 0.5), 300, 100), "哦对了，不要放过遇见过的魔法阵哦，去找找新发现吧", style);
     
        }
       



    }

    public void playFire()
    {
        print("firework! ");
        fire1.Play();
        fire2.Play();
        AudioSource.Play();
        Invoke("stopFire", 15f);
    }

    public void stopFire()
    {
        fire1.Stop();
        fire2.Stop();
        AudioSource.Stop();
    }
}
