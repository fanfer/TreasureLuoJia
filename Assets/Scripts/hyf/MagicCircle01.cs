using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCircle01 : MonoBehaviour
{

    public IronBars ironBars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
        ironBars.SendMessage("Lift");
        print("up!");
    }
  /*  public void OnTriggerExit(Collider other)w
    {
        ironBars.SendMessage("Down");
        print("down!");
    }*/
}
