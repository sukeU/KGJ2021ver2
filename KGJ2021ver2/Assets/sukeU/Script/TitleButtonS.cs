using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButtonS : MonoBehaviour
{
    SceneManagerS SceneManagerS;
    GameObject SceneManager;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager = GameObject.Find("SceneManager");
        SceneManagerS = SceneManager.GetComponent<SceneManagerS>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("Title‚ğƒ[ƒh‚µ‚Ü‚·");
        SceneManagerS.LoadTitle();
    }
}
