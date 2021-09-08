using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigS : MonoBehaviour
{
    GameObject child;
    bool pause;
    public bool handOver { get { return pause; } }

    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame

    public void ConfigOnClick()
    {
            child.SetActive(true);
            pause = true;   
    }
    
    public void PauseRelease()
    {
            child.SetActive(false);
            pause = false;
    }
}
