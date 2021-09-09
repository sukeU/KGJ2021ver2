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
    private float stanTime=0.1f;
    private float stanElapseTime;
    ConfigS ConfigS;
    //public bool tes=false;
    bool ready = false;
    float coolDownTime = 1.5f;
    float downElapseTime;
    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        transform.position = RouteS.points[0].transform.position;
        ConfigS = GameObject.Find("Config").GetComponent<ConfigS>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!ConfigS.handOver)//pause
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
                    stanElapseTime = 0f;
                }
            }
            /*
            if (tes)
            {
                SpeedDown(1);
            }
            */
            if (!ready)
            {
                 downElapseTime+= Time.deltaTime;
                if(downElapseTime> coolDownTime)
                {
                    ready = true;
                    downElapseTime = 0f;
                }
            }
            
            var PlayerVector = transform.position - RouteS.points[pointValve].transform.position;
            if (PlayerVector.magnitude >= Vector.magnitude)
            {
                pointValve++; 
                if (pointValve >= RouteS.points.Length - 1)
                {
                    Destroy(gameObject);
                    //TODO プレイヤーにダメージ
                }
            }
        }
    }

    public void SpeedDown(float downSpeed)
    {
        if (ready)
        {
            if (speed > 0.2)
            {
                speed = speed - downSpeed;    
            }
            ready = false;
        }


    }

    public void Stan()
    {
        stan = true;
      
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
