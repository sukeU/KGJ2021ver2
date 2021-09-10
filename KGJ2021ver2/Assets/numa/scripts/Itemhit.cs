using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemhit : MonoBehaviour
{//回数制の敵を倒すオブジェクトの設定。いいかんじのタイルを探す
    // Start is called before the first frame update
    [SerializeField]
    int HpTime;
    [SerializeField]
    float downspeed;
    float time;
    ConfigS ConfigS;

    private void Start()
    {
        ConfigS = GameObject.Find("Config").GetComponent<ConfigS>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!ConfigS.handOver)
        {
            time += Time.deltaTime;
            if (HpTime < time)
            {
                Destroy(this.gameObject);

            }
        }
    }
    public float GetDownspeed()
    {
        return downspeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            switch (gameObject.name) {
                
                case "サングラス(Clone)":
                    enemy.SpeedDown(downspeed);
                    break;
                case "ダンベル(Clone)":
                    enemy.Destroy();
                    break;
                case "カンガルーおかん(Clone)":
                    enemy.Destroy();
                    break;
                case "サンオイル(Clone)":
                    enemy.Destroy();
                    break;
                

                    //caseを各アイテムごとに書く

                    //enemy.Destroy()はマッチョを破壊する奴
            }

        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            switch (gameObject.name)
            {
                case "ささみ(Clone)":
                    enemy.Stan(); ;
                    break;
                case "マッスル雑誌(Clone)":
                    enemy.Stan();
                    break;
                case "プロテイン(Clone)":
                    enemy.Stan();
                    break;
                    //enemy.Stan();はスタンさせるタイプのやつ
            }
        }
    }
}
