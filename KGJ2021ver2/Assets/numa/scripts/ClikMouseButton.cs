using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClikMouseButton : MonoBehaviour
{
    public GameObject kangaroo;
    private Vector3 mousePosition;
    private GameObject clickedGameObject;
    private Vector3 mousePos;

    private void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedGameObject = null;

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            //ヒットした2Dオブジェクトを入れておく
            Collider2D click_miti = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("miti"));
            Collider2D click_wall = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("wall"));
            if (click_miti)
            {
                clickedGameObject = click_miti.transform.gameObject;
                mousePosition = Input.mousePosition;
                mousePosition.z = 10.0f;
                Instantiate(kangaroo, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
            }
            if (click_wall)
            {
                clickedGameObject = click_wall.transform.gameObject;
            }

            Debug.Log("tag" + clickedGameObject.layer);
            
        }
    }
}