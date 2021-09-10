using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick: MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
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
    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}
