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

    public void LoadTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    
    public void LoadTitle()
    {
        SceneManager.LoadScene("title");
    }
    }

