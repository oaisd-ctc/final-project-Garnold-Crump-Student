using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    

    private void Awake()
    {
     if (Instance)
        {
            Destroy(this);
        }   
     else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
   public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public static void Quit()
    {
        Application.Quit();
    }
}
