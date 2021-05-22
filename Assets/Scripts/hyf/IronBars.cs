using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBars : MonoBehaviour
{
   
    public float maxY=5.7f ;
    private float startY;


    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
        maxY = startY + 4.4f;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.J))
        {
            Lift();
            print("press J up!");
        }*/
        
    }

    public void Lift()
    {
 
        if (transform.position.y<=maxY)
        {
        //print("Lift is working!");
        transform.position = new Vector3(transform.position.x,transform.position.y+0.1f, transform.position.z);
        
        }
    }

    //注意进入和退出的区别
    public void Down()
    {
        while(transform.position.y >= startY)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);

        }
    }
}
