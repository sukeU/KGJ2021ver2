using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearFlag : MonoBehaviour
{
    bool GameOver;
    Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
        Text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameOver = GoalS.getFlag();
        if (GameOver)
        {
            if (gameObject.name == "GameClear")
            {
                gameObject.SetActive(false);
            }else if (gameObject.name == "GameOver")
            {
                gameObject.SetActive(true);
            }
        }
        else
        {
            if (gameObject.name == "GameClear")
            {
                gameObject.SetActive(true);
            }
            else if (gameObject.name == "GameOver")
            {
                gameObject.SetActive(false);
            }
        }
    }
}
