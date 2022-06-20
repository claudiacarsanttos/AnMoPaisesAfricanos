using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsTwo : MonoBehaviour
{
    float timer = 0.0f;
    int seconds = 0;

    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 20);

        if (seconds == 15){
            SceneManager.LoadScene("CreditsThree");
        }
    }
}
