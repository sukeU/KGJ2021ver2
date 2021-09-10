using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerT : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("numa");
    }

    public void LoadResult()
    {
        SceneManager.LoadScene("result");
    }
    
    public void LoadTitle()
    {
        SceneManager.LoadScene("title");
    }

    public void LoadCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void QuitGame()
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

