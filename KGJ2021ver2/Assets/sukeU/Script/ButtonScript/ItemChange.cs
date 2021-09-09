using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemChange : MonoBehaviour
{
    public GameObject displayItem;
    int i=0;
    int MaxItem = 6, Itemzero = 0;
    private Image image;
    public Sprite[] sprite;


    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        displayItem = transform.GetChild(2).gameObject;
        image = displayItem.GetComponent<Image>();
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        image.sprite = sprite[i];
    }
    public void CenterOnClick()
    {
        audioSource.PlayOneShot(sound1);
    }
    public void RightOnClick()
    {
        audioSource.PlayOneShot(sound1);
        if (i != MaxItem)
        {
            i += 1;
        }else if (i == MaxItem)
        {
            i = Itemzero;
        }
    }
    public void LeftOnClick()
    {
        audioSource.PlayOneShot(sound1);
        if (i != Itemzero)
        {
            i -= 1;
        }else if (i == Itemzero)
        {
            i = MaxItem;
        }
    }
    public int num
    {
        get { return i; }
    }
}
