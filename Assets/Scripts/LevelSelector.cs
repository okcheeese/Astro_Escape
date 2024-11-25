using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class LevelSelector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Lvl1()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }

    public void Lvl2()
    {
        SceneManager.LoadSceneAsync("Level 2");
    }
    public void Lvl3()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }
    public void Lvl4()
    {
        SceneManager.LoadSceneAsync("Level 4");
    }
    public void Lvl5()
    {
        SceneManager.LoadSceneAsync("Level 5");
    }

}