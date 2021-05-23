using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterController : MonoBehaviour
{
    private bool isSeen = true;//初始可以被看见
    public float minY = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSeen()
    {
        if (isSeen)
        {
            gameObject.SetActive(false);
            isSeen = false;
        }
        else
        {
            gameObject.SetActive(true);
            isSeen = true;
        }
    }

    public void Down()
    {
        if (transform.position.y>=minY)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);
        }
    }
}
