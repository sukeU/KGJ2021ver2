using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemhit : MonoBehaviour
{//�񐔐��̓G��|���I�u�W�F�N�g�̐ݒ�B�������񂶂̃^�C����T��
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
                
                case "�T���O���X(Clone)":
                    enemy.SpeedDown(downspeed);
                    break;
                case "�_���x��(Clone)":
                    enemy.Destroy();
                    break;
                case "�J���K���[������(Clone)":
                    enemy.Destroy();
                    break;
                case "�T���I�C��(Clone)":
                    enemy.Destroy();
                    break;
                

                    //case���e�A�C�e�����Ƃɏ���

                    //enemy.Destroy()�̓}�b�`����j�󂷂�z
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
                case "������(Clone)":
                    enemy.Stan(); ;
                    break;
                case "�}�b�X���G��(Clone)":
                    enemy.Stan();
                    break;
                case "�v���e�C��(Clone)":
                    enemy.Stan();
                    break;
                    //enemy.Stan();�̓X�^��������^�C�v�̂��
            }
        }
    }
}
