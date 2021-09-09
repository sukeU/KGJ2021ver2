using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    int hitPoint;
    private int pointValve;
    public RouteS RouteS;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = RouteS.points[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var Vector = RouteS.points[pointValve + 1].transform.position - RouteS.points[pointValve].transform.position;
        transform.position += Vector.normalized * speed * Time.deltaTime;

        var PlayerVector = transform.position - RouteS.points[pointValve].transform.position;
        if (PlayerVector.magnitude >= Vector.magnitude)
        {
            pointValve++; //次のPointへ
            if (pointValve >= RouteS.points.Length - 1)//最後まで到達した
            {
                Destroy(gameObject);
                //TODO プレイヤーにダメージ
            }
        }

    }
}
