using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincharacter : MonoBehaviour
{
    public AudioSource audio;
    public AudioSource audio02;

    /*public wallController[] wallControllers;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ))
        {
        print("the sound is playing!");
        playSound();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            audio02.Play();
        }

        //临时使用打开侧门
      /*  if (Input.GetKeyDown(KeyCode.U))
        {
            InvokeRepeating("moveWalls",3f,0.1f);
        }*/
        
    }

    public void playSound()
    {
        audio.Play();
    }

   /* public void moveWalls()
    {
        wallControllers[0].SendMessage("moveRight");
        wallControllers[1].SendMessage("moveRight");
    }*/

    
}
