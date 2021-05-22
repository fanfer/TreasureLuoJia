using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void liftCube()
    {
        transform.position = new Vector3(transform.position.x,0.7f,transform.position.z);
        print("the liftCube is working! "+transform.position.y);
    }
}
