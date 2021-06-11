using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class down : MonoBehaviour
{
    bool jug = false;
    // Start is called before the first frame update
    void Start()
    {
        print(this.transform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        print(this.transform.localPosition.y);
       
       if (this.transform.localPosition.y<-20&&jug==false)
        {
           jug = true;
           SceneManager.LoadScene("over");
        }
    }




}
