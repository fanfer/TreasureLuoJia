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

    //��һ���ؿ�ǽ�濪ʼ����
    private void Down()
    {
        if (transform.position.y>=minY)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y-0.002f,transform.position.z);

        }
    }

    //����ӿ�
    public void setTrigger()
    {
        isTriggered = true;
    }
}
