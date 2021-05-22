using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Maincharacter maincharacter;
    public door_01 door;
    public switchController switchController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        //排除地面碰撞导致的机关触发
        //抬起按钮，并且上升推门
        if (collision.gameObject.name!="Plane") 
        {
        door.SendMessage("setTrigger");
        print(collision.gameObject.name);
           switchController.SendMessage("liftCube");
        }
        
        
    }
}
