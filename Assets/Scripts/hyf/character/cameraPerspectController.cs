using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPerspectController : MonoBehaviour
{
    public bool isThirdPespect;
    //�����˳��ӽǵ���һ�˳��ӽǵ�ƫ����
    private Vector3 offsetPosition = new Vector3(0, -0.6f, 3.5f);
    // Start is called before the first frame update
    void Start()
    {
        isThirdPespect = true;
    }

    // Update is called once per frame
    void Update()
    {
        //����K���ı��ӽǵ��˳�
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
