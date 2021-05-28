 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireCntroller : MonoBehaviour
{
    public  float maxZ;
    public float minZ;
    public float maxX;
    public float minX;

    //1代表右移，0代表左移；
    private int moveRight = 1;
    private int moveforward = 1;

    // Start is called before the first frame update
    void Start()
    {
        maxZ = 27.6f;
        minZ = 20.0f;
        maxX = 27.0f;
        minX = 24.0f;
    }

    // Update is called once per frame
    void Update()
    {
        showFireLineZ();
        //showFireLineX();
    }

    public void showFireLineZ()
    {
        if (transform.position.z >= maxZ)
        {
            moveRight = 0;
        }
        else if(transform.position.z<=minZ)
        {
            moveRight = 1;
        }
        switch (moveRight)
        {
            case 1:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
                break;
            case 0:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);
                break;
            default:
                print("error:the fire is wrong !");
                break;
        }

    }

    public void showFireLineX()
    {
        if (transform.position.z >= maxX)
        {
            moveforward = 0;
        }
        else if (transform.position.z <= maxX)
        {
            moveforward = 1;
        }
        switch (moveRight)
        {
            case 1:
                transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z );
                break;
            case 0:
                transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
                break;
            default:
                print("error:the fire is wrong !");
                break;
        }



    }

}
