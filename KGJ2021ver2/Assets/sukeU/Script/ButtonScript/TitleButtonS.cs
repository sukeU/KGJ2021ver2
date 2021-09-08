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

    public void TitleOnClick()
    {
        Debug.Log("Titleをロードします");
        SceneManagerS.LoadTitle();
    }

    public void EscOnClick()
    {
        Debug.Log("ゲームを終了します");
        Application.Quit();
    }
}
