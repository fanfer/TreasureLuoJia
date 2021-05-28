using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioContral : MonoBehaviour
{
    private AudioSource audioMgr;
    private int nStatus = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioMgr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nStatus == 1)
        {
            nStatus = audioMgr.isPlaying ? 1 : 2;
        }
    }
    public bool IsPlayOver
    {
        get { return nStatus == 2; }
    }
    
    public void PlayAudio(string fname)
    {
        AudioClip clip = Resources.Load(fname, typeof(AudioClip)) as AudioClip;
        nStatus = 1;
        audioMgr.PlayOneShot(clip);
    }
   
    public void StopAudio()
    {
        nStatus = 0;
        audioMgr.Stop();
    }    

}
