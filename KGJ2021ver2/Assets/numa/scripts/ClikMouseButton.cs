using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class ClikMouseButton : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 mousePos;
    GameObject clickedGameObject;

    [SerializeField]
    GameObject[] plafabs;

    [SerializeField]
    GameObject ItemgameObject;

    [SerializeField]
    GameObject ItemmaxsetObject;

    [SerializeField]
    Grid miti_tilemap;

    [SerializeField]
    Grid wall_tilemap;
    int[] plafabs_count = new int[7];
    ItemChange Item;
    Itemmaxset Itemmaxset;
    ConfigS ConfigS;

    int heyaban;
    private void Start()
    {
        Item = ItemgameObject.GetComponent<ItemChange>();
        Itemmaxset = ItemmaxsetObject.GetComponent<Itemmaxset>();
        ConfigS = GameObject.Find("Config").GetComponent<ConfigS>();

    }
    void Update()
    {
        heyaban = Item.num;
        Debug.Log(Item.num);
        Itemmaxset.Set_NowInt(plafabs_count[heyaban], heyaban);
        if (Input.GetMouseButtonDown(0)&&!ConfigS.handOver)
        {
            clickedGameObject = null;//clickしたゲームオブジェクトをnullに入れる
            
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//マウスの座標を取得
            

            //ヒットした2Dオブジェクトを入れておく
            Collider2D click_miti = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("miti"));//マウスでclickしたのがmitiの時に入れる
            Collider2D click_wall = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("wall"));//マウスでclickしたのがwallの時にオブジェクトを記憶する
            if (click_miti && Itemmaxset.Get_isItemSet(plafabs_count[heyaban], heyaban))//道がclickされたとき
            {
                clickedGameObject = click_miti.transform.gameObject;//mitiのゲームオブジェクトを入れる
                mousePosition = Input.mousePosition;//マウスのワールド座標を記録する
                mousePosition.z = 10.0f;
                mousePosition = miti_tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                plafabs_count[heyaban]++;
                GameObject chara = Instantiate(plafabs[heyaban], mousePosition, Quaternion.identity);
                chara.transform.position = new Vector2(chara.transform.position.x + 0.5f, chara.transform.position.y + 0.5f);
            }
            if (click_wall)
            {
                clickedGameObject = click_wall.transform.gameObject;
            }
            
            
        }
    }
}