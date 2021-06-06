using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour
{


    public float minY;
 
    public cameraPerspectController camera;
    public wallController[] wallControllers;

    // Start is called before the first frame update
    void Start()
    {
        minY = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void characterPressT()
    {
            InvokeRepeating("Down", 2f,0.1f);
           // playFire();
            camera.SendMessage("upRotation");
            //ÒÆ¶¯¸ôÇ½
            InvokeRepeating("moveWalls", 3f, 0.1f);
    }

    public void Down()
    {
        if (transform.position.y>=minY)
        {
            print("platform is down!");
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.04f, transform.position.z);
        }
    }

    /*public void playFire()
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
*/
    public void moveWalls()
    {
        wallControllers[0].SendMessage("moveRight");
        wallControllers[1].SendMessage("moveRight");
    }
}
