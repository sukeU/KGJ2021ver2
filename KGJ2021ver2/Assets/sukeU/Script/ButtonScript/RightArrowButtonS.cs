using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowButtonS : MonoBehaviour
{
    ItemChange itemChange;
    // Start is called before the first frame update
    void Start()
    {
        itemChange = transform.parent.gameObject.GetComponent<ItemChange>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RightOnClick()
    {
        itemChange.RightOnClick();
    }
}
