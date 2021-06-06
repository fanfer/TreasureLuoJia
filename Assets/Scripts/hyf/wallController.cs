using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallController : MonoBehaviour
{
    private float minY;
    // Start is called before the first frame update
    void Start()
    {
        minY = transform.position.y - 7.8f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveRight()
    {
        if (transform.position.z>=minY)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y-0.1f, transform.position.z );
        }
    }
}
