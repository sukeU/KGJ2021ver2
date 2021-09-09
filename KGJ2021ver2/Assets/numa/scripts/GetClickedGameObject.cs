using UnityEngine;

public class GetClickedGameObject : MonoBehaviour
{

    public GameObject clickedGameObject;
    Vector2 mousePos;
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
            Collider2D click_miti = Physics2D.OverlapPoint(mousePos,LayerMask.GetMask("miti"));
            Collider2D click_wall = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("wall"));
            if (click_miti)
            {
                clickedGameObject = click_miti.transform.gameObject;
            }
            if (click_wall)
            {
                clickedGameObject = click_wall.transform.gameObject;
            }

            Debug.Log("tag"+clickedGameObject.layer);
        }
    }
}