using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickUpReligion : MonoBehaviour
{
    [SerializeField]
    private Text punctuation;
    private int count;

    public AudioSource audioSound;
    public AudioClip[] soundReligion;

    float timer = 0.0f;
    int seconds = 0;

    void Start()
    {
        count = 0;
        audioSound = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        punctuation.text = "Pontuação: " + count;

        if (count == 13)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 10);

            if (seconds == 5){
                SceneManager.LoadScene("HappyBirthday");
            }
        }
    }  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Image1>())
        {
            audioSound.clip = soundReligion[0];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image2>())
        {
            audioSound.clip = soundReligion[1];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image3>())
        {
            audioSound.clip = soundReligion[2];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image4>())
        {
            audioSound.clip = soundReligion[3];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image5>())
        {
            audioSound.clip = soundReligion[4];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image6>())
        {
            audioSound.clip = soundReligion[5];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image7>())
        {
            audioSound.clip = soundReligion[6];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image8>())
        {
            audioSound.clip = soundReligion[7];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image9>())
        {
            audioSound.clip = soundReligion[8];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image10>())
        {
            audioSound.clip = soundReligion[9];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image11>())
        {
            audioSound.clip = soundReligion[10];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image12>())
        {
            audioSound.clip = soundReligion[11];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
        if (collision.GetComponent<Image13>())
        {
            audioSound.clip = soundReligion[12];
            audioSound.Play();
            count += 1;
            Destroy(collision.gameObject);
        }
    }
}
