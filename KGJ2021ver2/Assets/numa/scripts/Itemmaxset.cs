using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemmaxset : MonoBehaviour
{
    [SerializeField]
    int[] MaxItem = new int[7];
    int NowItemInt;
    int NowMaxItem;
    int Nowplefab_count;

    // Start is called before the first frame update
    void Start()
    {
    }
    private void Update()
    {
        NowItemInt = NowMaxItem - Nowplefab_count;
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
    public int Get_NowItemInt()
    {
        return NowItemInt;
    }
    public void Set_NowInt(int plefab_count,int heyaban)
    {
        NowMaxItem = MaxItem[heyaban];
        Nowplefab_count = plefab_count;
    }
}
