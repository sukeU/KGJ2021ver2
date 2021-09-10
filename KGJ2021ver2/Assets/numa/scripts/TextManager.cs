using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextManager : MonoBehaviour
{
    [SerializeField]
    GameObject Text_object;

    [SerializeField]
    GameObject ItemmaxsetObj;

    Text kangaru_text;
    Itemmaxset itemmaxset;
    // Start is called before the first frame update
    void Start()
    {
        kangaru_text = Text_object.GetComponent<Text>();
        itemmaxset = ItemmaxsetObj.GetComponent<Itemmaxset>();
    }

    // Update is called once per frame
    void Update()
    {
        kangaru_text.text = "このアイテムの\n残り個数   " + itemmaxset.Get_NowItemInt();
    }
}
