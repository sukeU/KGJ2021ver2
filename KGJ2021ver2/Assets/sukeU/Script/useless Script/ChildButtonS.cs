using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildButtonS : BaseButtonS
{
    protected override void OnClick(string name)
    {
        if ("Config"==name)
        {
            // Button1���N���b�N���ꂽ�Ƃ�
            this.ConfigClick();
        }
        else if ("Button2"== name)
        {
            // Button2���N���b�N���ꂽ�Ƃ�
            this.Button2Click();
        }
    }
    private void ConfigClick()
    {
        Debug.Log("Config Click");
        foreach (Transform child in transform)
        {
            if (child.name == "Panel")
            {
                child.gameObject.SetActive(true);
            }
        }
    }

    private void Button2Click()
    {
        Debug.Log("Button2 Click");
    }

}
