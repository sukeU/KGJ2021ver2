using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ClikMouseButton : MonoBehaviour
{
    private Vector3 mousePosition;
    private GameObject clickedGameObject;
    private Vector3 mousePos;
    [SerializeField]
    private Grid miti_tilemap;
    [SerializeField]
    private Grid wall_tilemap;
    [SerializeField]
    private GameObject[] plafabs;
    ItemChange Item;
    [SerializeField]
    private GameObject ItemgameObject;
    int heyaban;
    private void Start()
    {
        Item = ItemgameObject.GetComponent<ItemChange>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedGameObject = null;//clickしたゲームオブジェクトをnullに入れる
            
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//マウスの座標を取得


            //ヒットした2Dオブジェクトを入れておく
            Collider2D click_miti = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("miti"));//マウスでclickしたのがmitiの時に入れる
            Collider2D click_wall = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("wall"));//マウスでclickしたのがwallの時にオブジェクトを記憶する
            if (click_miti)//道がclickされたとき
            {
                clickedGameObject = click_miti.transform.gameObject;//mitiのゲームオブジェクトを入れる
                mousePosition = Input.mousePosition;//マウスのワールド座標を記録する
                mousePosition.z = 10.0f;
                mousePosition = miti_tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                heyaban=Item.num;
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