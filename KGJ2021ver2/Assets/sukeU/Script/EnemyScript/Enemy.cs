using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    int hitPoint;
    private int pointValve;
    public RouteS RouteS;
    private bool stan;
    private float stanTime=5f;
    private float stanElapseTime;
    ConfigS ConfigS;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = RouteS.points[0].transform.position;
        ConfigS = GameObject.Find("Config").GetComponent<ConfigS>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!ConfigS.handOver)
        {
            var Vector = RouteS.points[pointValve + 1].transform.position - RouteS.points[pointValve].transform.position;
            if (!stan)
            {
                transform.position += Vector.normalized * speed * Time.deltaTime;
            }
            else
            {
                stanElapseTime += Time.deltaTime;
                if (stanElapseTime > stanTime)
                {
                    stan = false;
                }
            }



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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "temp")
        {
            stanElapseTime = 0f;
            stan = true;
        }
    }
}
