using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class watertrigger : MonoBehaviour
{
    public GameObject panelquit;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "unitychan")
        {
            Debug.Log(Time.time + ":进入该触发器的对象是：" + other.gameObject.name);
            SceneManager.LoadScene("over");
            
        }
    }
   
}
