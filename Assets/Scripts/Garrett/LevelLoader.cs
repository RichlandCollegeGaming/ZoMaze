using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    /*

    public static SceneController instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Desstroy(gameObject);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneaSYNC(SceneManager.GetActiveScene().buildIndex + 1);
    }


 /*

    private void OnCollisionEnter2D(Collision2D other)
    {

            LoadNextLevel();


    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    */
}
