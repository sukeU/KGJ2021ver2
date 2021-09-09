using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemChange : MonoBehaviour
{
    public GameObject displayItem;
    int i=0;
    private Image image;
    public Sprite[] sprite=new Sprite[5];

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
        if (i != 4)
        {
            i += 1;
        }else if (i == 4)
        {
            i = 0;
        }
    }
    public void LeftOnClick()
    {
        audioSource.PlayOneShot(sound1);
        if (i != 0)
        {
            i -= 1;
        }else if (i == 0)
        {
            i = 4;
        }
    }
}
