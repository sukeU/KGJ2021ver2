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
        SceneManagerS.LoadTitle();
    }

    public void EscOnClick()
    {
#if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
#elif (UNITY_STANDALONE) 
    Application.Quit();
#elif (UNITY_WEBGL)
    Application.OpenURL("about:blank");
#endif
    }
}
