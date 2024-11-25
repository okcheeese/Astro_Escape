using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }

    public void PickLevel()
    {
       SceneManager.LoadSceneAsync("Level Select");
    }
  
    public void ExitGame()
    {
        Application.Quit();
    }

}
