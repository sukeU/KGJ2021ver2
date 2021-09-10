using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerS : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void LoadResult()
    {
        SceneManager.LoadScene("result");
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("tutorial");
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
