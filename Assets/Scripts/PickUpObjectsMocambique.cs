using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickUpObjectsMocambique : MonoBehaviour
{
    
    [SerializeField]
    private Text punctuation;
    private int count;

    public AudioSource audioSound;
    public AudioClip[] soundMusic;

    void Start()
    {
        count = 0;
        audioSound = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        punctuation.text = "Pontuação: " + count;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Image1>())
        {
            audioSound.clip = soundMusic[0];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image2>())
        {
            audioSound.clip = soundMusic[1];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image3>())
        {
            audioSound.clip = soundMusic[2];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image4>())
        {
            audioSound.clip = soundMusic[3];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image5>())
        {
            audioSound.clip = soundMusic[4];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image6>())
        {
            audioSound.clip = soundMusic[5];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image7>())
        {
            audioSound.clip = soundMusic[6];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image8>())
        {
            audioSound.clip = soundMusic[7];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image9>())
        {
            audioSound.clip = soundMusic[8];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image10>())
        {
            audioSound.clip = soundMusic[9];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image11>())
        {
            audioSound.clip = soundMusic[10];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image12>())
        {
            audioSound.clip = soundMusic[11];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image13>())
        {
            audioSound.clip = soundMusic[12];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }

        if (collision.GetComponent<Goop1>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop2>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop3>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop4>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop5>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop6>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop7>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop8>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop9>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Goop10>())
        {
            audioSound.clip = soundMusic[13];
            audioSound.Play();
            count -= 1;
            Destroy(collision.gameObject);
        }

       if (collision.GetComponent<FlagMocambique>())
       {
            if (count == 13)
            {
                Destroy(collision.gameObject);
                SceneManager.LoadScene("HappyBirthday");
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
