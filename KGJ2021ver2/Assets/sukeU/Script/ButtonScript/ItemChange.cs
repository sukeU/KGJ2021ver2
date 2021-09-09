using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemChange : MonoBehaviour
{
    public GameObject displayItem;
    int i=0;
    private Image image;
    public Sprite[] sprite=new Sprite[5];
    void Start()
    {
        displayItem = transform.GetChild(2).gameObject;
        image = displayItem.GetComponent<Image>();
    }
    private void Update()
    {
        image.sprite = sprite[i];
    }
    public void CenterOnClick()
    { 
        //displayItem = items[i];
    }
    public void RightOnClick()
    {
        if (i != 4)
        {
            i += 1;
        }
    }
    public void LeftOnClick()
    {
        if (i != 0)
        {
            i -= 1;
        }
    }
}
