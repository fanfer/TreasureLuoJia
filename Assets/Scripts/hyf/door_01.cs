using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_01 : MonoBehaviour
{
    private float minY;
    private bool isTriggered;
    // Start is called before the first frame update
    void Start()
    {
        minY = this.transform.position.y - 9.0f;
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {
            Down();
        }
    }

    //第一道关卡墙面开始下移
    private void Down()
    {
        if (transform.position.y>=minY)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y-0.002f,transform.position.z);

        }
    }

    //对外接口
    public void setTrigger()
    {
        isTriggered = true;
    }
}
