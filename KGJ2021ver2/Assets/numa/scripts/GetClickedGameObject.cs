using UnityEngine;

public class GetClickedGameObject : MonoBehaviour
{

    public GameObject clickedGameObject;
   
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //�q�b�g����2D�I�u�W�F�N�g�����Ă���
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
            }
            Debug.Log(clickedGameObject);
        }
    }
}