using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void loadScene(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void close()
    {
        Application.Quit();
    }
}
