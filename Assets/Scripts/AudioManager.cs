using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private bool audioOn = true;
    public GameObject buttonOn, buttonOff;

    public void GameVolume()
    {
        audioOn = !audioOn;
        if(audioOn == true)
        {
            AudioListener.volume = 1;
            buttonOn.SetActive(true);
            buttonOff.SetActive(false);
        }
        else
        {
            AudioListener.volume = 0;
            buttonOn.SetActive(false);
            buttonOff.SetActive(true);
        }
    }
}
