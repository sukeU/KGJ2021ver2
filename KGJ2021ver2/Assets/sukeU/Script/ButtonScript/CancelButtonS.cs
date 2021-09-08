using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButtonS : MonoBehaviour
{
    GameObject parent;
    GameObject grandParent;
    ConfigS ConfigS;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
        grandParent = transform.parent.parent.gameObject;
        ConfigS = grandParent.GetComponent<ConfigS>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CancelOnClick()
    {
         ConfigS.PauseRelease();
        
    }
}
