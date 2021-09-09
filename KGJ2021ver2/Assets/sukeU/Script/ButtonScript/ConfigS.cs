using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigS : MonoBehaviour
{
    GameObject child;
    bool pause;
    public bool handOver { get { return pause; } }

    public AudioClip[] sound=new AudioClip[2];
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(1).gameObject;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public void ConfigOnClick()
    {
        if (pause == false)
        {
            audioSource.PlayOneShot(sound[0]);
            child.SetActive(true);
            pause = true;
        }
    }
    
    public void PauseRelease()
    {
        audioSource.PlayOneShot(sound[1]);
        child.SetActive(false);
        pause = false;
    }
}
