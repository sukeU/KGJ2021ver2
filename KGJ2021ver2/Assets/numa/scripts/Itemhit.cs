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
 
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (HpTime < time)
        {
            Destroy(this.gameObject);
           
        }
    }
    public float GetDownspeed()
    {
        return downspeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
