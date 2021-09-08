using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSphere : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 mousePosition;
    GetClickedGameObject GetClickedGameObject;
    private void Start()
    {
        GetClickedGameObject = GetComponent<GetClickedGameObject>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&  GetClickedGameObject.clickedGameObject.CompareTag("miti"))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f;
            Instantiate(prefab, Camera.main.ScreenToWorldPoint(mousePosition), Quaternion.identity);
        }
    }
}