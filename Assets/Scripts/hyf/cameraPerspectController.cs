using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPerspectController : MonoBehaviour
{
    public bool isThirdPespect;
    //�����˳��ӽǵ���һ�˳��ӽǵ�ƫ����
    private Vector3 offsetPosition = new Vector3(0, -0.6f, 3f);
    // Start is called before the first frame update
    void Start()
    {
        isThirdPespect = true;
    }

    // Update is called once per frame
    void Update()
    {
        //����K���ı��ӽ�
        if (Input.GetKey(KeyCode.K))
        {
            changePerspect();
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
}
