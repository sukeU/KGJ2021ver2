using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigS : MonoBehaviour
{
    GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnClick()
    {
        child.SetActive(true);
    }
}
