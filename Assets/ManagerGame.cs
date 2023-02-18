using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerGame : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("palyed");
        SceneManager.LoadScene("Level1");

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }


    public void Restart()
    {
       
        SceneManager.LoadScene("Start");
       
    }



}
