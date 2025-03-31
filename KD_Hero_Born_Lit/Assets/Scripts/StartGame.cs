using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void InvokeNextLevel(float time)
    {

        Invoke("LoadNextLevel", time);

    }

    public void LoadFirstLevel()
    {

        SceneManager.LoadScene(1);

    }

    public void InvokeFirstLevel(float time)
    {

        Invoke("LoadFirstLevel", time);

    }

}
