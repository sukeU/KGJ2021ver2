using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemmaxset : MonoBehaviour
{
    [SerializeField]
    int[] MaxItem = new int[6];
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public bool Get_isItemSet(int plefab_count,int heyaban)
    {
        if (plefab_count < MaxItem[heyaban])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
