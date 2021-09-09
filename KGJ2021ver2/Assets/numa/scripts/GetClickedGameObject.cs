using UnityEngine;

public class GetClickedGameObject : MonoBehaviour
{

    public GameObject clickedGameObject;
    int mitilayer;
    private void Start()
    {
         mitilayer = 6;
    }
    
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            
            //ヒットした2Dオブジェクトを入れておく
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction,Mathf.Infinity,mitilayer);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;

            }
            
            Debug.Log("tag"+clickedGameObject.tag);
        }
    }
}