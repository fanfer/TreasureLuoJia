using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle03 : MonoBehaviour
{
    public AudioSource audio;
    public  ParticleSystem fire1;
    public  ParticleSystem fire2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        fire1.Stop();
        fire2.Stop();
    }
}
