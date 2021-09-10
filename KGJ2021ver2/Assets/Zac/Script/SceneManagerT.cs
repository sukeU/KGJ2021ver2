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
    }

