using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPerspectController : MonoBehaviour
{
    public bool isThirdPespect;
    //第三人称视角到第一人称视角的偏移量
    private Vector3 offsetPosition = new Vector3(0, -0.6f, 3.5f);
    // Start is called before the first frame update
    void Start()
    {
        isThirdPespect = true;
    }

    // Update is called once per frame
    void Update()
    {
        //设置K键改变视角的人称
        if (Input.GetKeyDown(KeyCode.K))
        {
            changePerspect();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            upRotation();
        }
        

    }
    
    public void changePerspect()
    {
        if (isThirdPespect)
        {
            transform.position += offsetPosition;
            isThirdPespect = !isThirdPespect;
            print("is third pespect!");
        }
        else
        {
            transform.position -= offsetPosition;
            isThirdPespect = !isThirdPespect;
            print("is first pespect!");
        }
    }

    public void upRotation()
    {
        transform.rotation =  Quaternion.Euler(new Vector3(-32f,0,0));
        Invoke("downRotation",10f);
    }

    public void downRotation()
    {
        transform.rotation = Quaternion.Euler(new Vector3(4.8f, 0, 0));
    }
        
    
}
