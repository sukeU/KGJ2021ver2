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
}
