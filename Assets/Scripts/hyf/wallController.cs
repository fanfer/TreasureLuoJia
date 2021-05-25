using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallController : MonoBehaviour
{
    private float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        maxZ = transform.position.z + 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveRight()
    {
        if (transform.position.z<=maxZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
        }
    }
}
