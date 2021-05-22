using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeController : MonoBehaviour
{
    //格子只沿着x,y 旋转，初始值均为20
    private float x=20;
    private float y=20;
    public float resovleSpeed = 0.5f;

    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
         resolve();
    }

   

    public void resolve()
    {
        if (x==360||y==360)
        {
            x = 0;y = 0;
        }
        x = x + resovleSpeed;
        y = y + resovleSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(x, y, 0));
     
    }

}
