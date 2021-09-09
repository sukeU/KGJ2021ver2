using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ClikMouseButton : MonoBehaviour
{
    private Vector3 mousePosition;
    private GameObject clickedGameObject;
    private Vector3 mousePos;
    [SerializeField]
    private Grid miti_tilemap;
    [SerializeField]
    private Grid wall_tilemap;
    [SerializeField]
    private GameObject[] plafabs;
    ItemChange Item;
    [SerializeField]
    private GameObject ItemgameObject;
    int heyaban;
    private void Start()
    {
        Item = ItemgameObject.GetComponent<ItemChange>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedGameObject = null;//click�����Q�[���I�u�W�F�N�g��null�ɓ����
            
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//�}�E�X�̍��W���擾


            //�q�b�g����2D�I�u�W�F�N�g�����Ă���
            Collider2D click_miti = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("miti"));//�}�E�X��click�����̂�miti�̎��ɓ����
            Collider2D click_wall = Physics2D.OverlapPoint(mousePos, LayerMask.GetMask("wall"));//�}�E�X��click�����̂�wall�̎��ɃI�u�W�F�N�g���L������
            if (click_miti)//����click���ꂽ�Ƃ�
            {
                clickedGameObject = click_miti.transform.gameObject;//miti�̃Q�[���I�u�W�F�N�g������
                mousePosition = Input.mousePosition;//�}�E�X�̃��[���h���W���L�^����
                mousePosition.z = 10.0f;
                mousePosition = miti_tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                heyaban=Item.num;
                GameObject chara = Instantiate(plafabs[heyaban], mousePosition, Quaternion.identity);
                chara.transform.position = new Vector2(chara.transform.position.x + 0.5f, chara.transform.position.y + 0.5f);
            }
            if (click_wall)
            {
                clickedGameObject = click_wall.transform.gameObject;
            }
            
            
        }
    }
}