using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalS : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            SceneManagerS SceneManager = GameObject.Find("SceneManager").GetComponent<SceneManagerS>();
            SceneManager.LoadResult();
        }
    }
}
