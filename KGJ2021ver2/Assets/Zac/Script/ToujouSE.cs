using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToujouSE : MonoBehaviour {

    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (enabled == true)
        {
            audioSource.PlayOneShot(sound1);
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
