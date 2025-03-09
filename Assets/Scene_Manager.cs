using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
   

    public void Start()
    {
        
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1.0f;
    }


}
