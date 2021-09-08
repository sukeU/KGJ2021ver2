using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseButtonS : MonoBehaviour
{
    public BaseButtonS buttonS;

    public void OnClick()
    {
        buttonS.OnClick(this.gameObject.name);
    }

    protected virtual void OnClick(string name)
    {
        Debug.Log("ベースボタンが押されました");
    }
}
   

