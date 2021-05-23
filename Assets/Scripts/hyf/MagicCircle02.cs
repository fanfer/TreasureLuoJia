using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCircle02 : MonoBehaviour
{
    public ParticleSystem ps;
    public ParticleSystem flare01;
    public ParticleSystem flare02;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void psPlay()
    {
        if (ps!=null)
        {
            ps.Play();
            flare01.Play();
            flare02.Play();
            Destroy(ps.transform.parent.gameObject, 1.0f);
            Destroy(flare01.gameObject, 30.0f);
            Destroy(flare02.gameObject, 30.0f);

        }
        else
        {
            print("the ps is null!");
        }
            
    }
}
